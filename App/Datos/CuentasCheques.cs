using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;
using System.Xml;
using System.Web.Hosting;
using System.IO;
using System.Xml.Linq;
using App.Datos;


namespace App.Datos
{
    public class CuentasCheques
    {
        private static List<Cheques> datab = new List<Cheques>();
        public List<Cheques> getCheques()
        {
            // Creamos la lista genérica de Personas
            List<Cheques> listab = new List<Cheques>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml");

            XDocument doc = XDocument.Load(ruta);

            var chequess = from t in doc.Descendants("Cheques") select t;

            foreach (XElement t in chequess.Elements("Cheques"))
            {
                Cheques cheque = new Cheques(

                                                  t.Element("Cliente").Value,
                                                  t.Element("Identeficacion").Value,
                                                  t.Element("IdCliente").Value,
                                                  double.Parse(t.Element("Balance").Value),
                                                  double.Parse(t.Element("Tasadeinterest").Value)

                                              );
                listab.Add(cheque);

            }

            return listab;
        }

        public void add(Cheques t)
        {
            datab.Add(t);
            WriteXML(datab);

        }

        private void WriteXML(List<Cheques> listab)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 2;

            //ROOT Element
            xmlwriter.WriteStartElement("Cuentas");
            //Call create nodes method
            foreach (Cheques t in listab)
            {
                xmlwriter.WriteStartElement("Cheques");
                xmlwriter.WriteElementString("Cliente", t.Cliente);
                xmlwriter.WriteElementString("IDCliente", t.Idcliente);
                xmlwriter.WriteElementString("Identificacion", t.Identificacion);
                xmlwriter.WriteElementString("Balance", t.Balance.ToString());
                xmlwriter.WriteElementString("LimiteCreditos", t.Tasadeinteres.ToString());

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