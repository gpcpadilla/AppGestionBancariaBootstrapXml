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
    public class CuentasCorrientes
    {
        private static List<Corrientes> data = new List<Corrientes>();
      
        
        public List<Corrientes> getCorrientes()
        {
          // Creamos la lista genérica de Personas
            List<Corrientes> lista = new List<Corrientes>();
            
           // Obtenemos la ruta de archivo XML
          string ruta = HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml");

          XDocument doc = XDocument.Load(ruta);

          var corrientec = from c in doc.Descendants("Corrientes") select c;
          
          foreach (XElement c in corrientec.Elements("Corriente"))
          {
              Corrientes corriente = new Corrientes(

                                                c.Element("Cliente").Value,
                                                c.Element("Identeficacion").Value,
                                                c.Element("IdCliente").Value,
                                                double.Parse(c.Element("Balance").Value),
                                                double.Parse(c.Element("LimitesCreditos").Value),
                                                double.Parse(c.Element("TasaInteres").Value)
                                               
                   
                   
                                            );
              lista.Add(corriente);

          }
          
   


         return lista;
        }

        public void add(Corrientes c)
        {
            data.Add(c);
            WriteXML(data);

        }

        private void WriteXML(List<Corrientes> list)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml"), System.Text.Encoding.UTF8);
            
            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Cuentas");
            //Call create nodes method
            foreach(Corrientes c in list)
            {
                xmlwriter.WriteStartElement("Corrientes");
                xmlwriter.WriteElementString("Cliente", c.Cliente);
                xmlwriter.WriteElementString("IDCliente", c.Idcliente);
                xmlwriter.WriteElementString("Identificacion", c.Identificacion);
                xmlwriter.WriteElementString("Balance", c.Balance.ToString());
                xmlwriter.WriteElementString("LimiteCreditos", c.LimitesCreditos.ToString());
                xmlwriter.WriteElementString("TasaInteres", c.TasaInteres.ToString());
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