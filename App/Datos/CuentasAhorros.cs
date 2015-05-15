using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;
using System.Xml;
using System.Web.Hosting;
using System.IO;
using System.Xml.Linq;

namespace App.Datos
{
    public class CuentasAhorros {    
    private static List<Ahorros> dataa = new List<Ahorros>();            
        public List<Ahorros> getAhorros()     {
          // Creamos la lista genérica de Personas
            List<Ahorros> listaa = new List<Ahorros>();
            
           // Obtenemos la ruta de archivo XML
          string ruta = HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml");

          XDocument doc = XDocument.Load(ruta);

          var ahorrosa = from a in doc.Descendants("Ahorros") select a;
          
          foreach (XElement a in ahorrosa.Elements("Ahorros"))
          {
              Ahorros ahorro= new Ahorros (

                                                a.Element("Cliente").Value,
                                                a.Element("Identeficacion").Value,
                                                a.Element("IdCliente").Value,
                                                double.Parse(a.Element("Balance").Value),
                                                double.Parse(a.Element("tasadeinteres").Value)
                      
                                            );
              listaa.Add(ahorro);

          }

         return listaa;
        }

        public void add(Ahorros a)
        {
            dataa.Add(a);
            WriteXML(dataa);

        }

        private void WriteXML(List<Ahorros> listaa)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml"), System.Text.Encoding.UTF8);
            
            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 1;

            //ROOT Element
            xmlwriter.WriteStartElement("Cuentas");
            //Call create nodes method
            foreach (Ahorros a in listaa)

            {
                xmlwriter.WriteStartElement("Ahorros");
                xmlwriter.WriteElementString("Cliente", a.Cliente);
                xmlwriter.WriteElementString("IDCliente", a.Idcliente);
                xmlwriter.WriteElementString("Identificacion", a.Identificacion);
                xmlwriter.WriteElementString("Balance", a.Balance.ToString());
                xmlwriter.WriteElementString("LimiteCreditos", a.Tasadeinteres.ToString());
                
                xmlwriter.WriteEndElement();
            }
               
            xmlwriter.WriteEndElement();

            //End XML Document
            xmlwriter.WriteEndDocument();

            //Close Write
            xmlwriter.Close();
        }

    }
}