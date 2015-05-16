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
    public class CuentasRepositorios
    {

        #region "Cuenta Cheques"
        private static List<Cheques> datacheques = new List<Cheques>();
        public List<Cheques> getCheques()
        {
            // Creamos la lista genérica de Personas
            List<Cheques> listacheques = new List<Cheques>();

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
                                                  double.Parse(t.Element("TasaCheques").Value)

                                              );
                listacheques.Add(cheque);

            }

            return listacheques;
        }

        public void add(Cheques t)
        {
            datacheques.Add(t);
            WriteXML(datacheques);

        }

        private void WriteXML(List<Cheques> listacheques)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 0;

            //ROOT Element
            xmlwriter.WriteStartElement("Cuentas");
            //Call create nodes method
            foreach (Cheques t in listacheques)
            {
                xmlwriter.WriteStartElement("Cheques");
                xmlwriter.WriteElementString("Cliente", t.Cliente);
                xmlwriter.WriteElementString("IDCliente", t.Idcliente);
                xmlwriter.WriteElementString("Identificacion", t.Identificacion);
                xmlwriter.WriteElementString("Balance", t.Balance.ToString());
                xmlwriter.WriteElementString("TasaCheques", t.TasaCheques.ToString());

                xmlwriter.WriteEndElement();
            }

            xmlwriter.WriteEndElement();

            //End XML Document
            xmlwriter.WriteEndDocument();

            //Close Write
            xmlwriter.Close();
        }

        #endregion

        #region "Cuentas de Ahorros"
        private static List<Ahorros> dataahorros = new List<Ahorros>();
        public List<Ahorros> getAhorros()
        {
            // Creamos la lista genérica de Personas
            List<Ahorros> listaahorros = new List<Ahorros>();

            // Obtenemos la ruta de archivo XML
            string ruta = HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml");

            XDocument doc = XDocument.Load(ruta);

            var ahorrosa = from a in doc.Descendants("Ahorros") select a;

            foreach (XElement a in ahorrosa.Elements("Ahorros"))
            {
                Ahorros ahorro = new Ahorros(

                                                  a.Element("Cliente").Value,
                                                  a.Element("Identeficacion").Value,
                                                  a.Element("IdCliente").Value,
                                                  double.Parse(a.Element("Balance").Value),
                                                  double.Parse(a.Element("TasaAhorro").Value)

                                              );
                listaahorros.Add(ahorro);

            }

            return listaahorros;
        }

        public void add(Ahorros a)
        {
            dataahorros.Add(a);
            WriteXML(dataahorros);

        }

        private void WriteXML(List<Ahorros> listaahorros)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 0;

            //ROOT Element
            xmlwriter.WriteStartElement("Cuentas");
            //Call create nodes method
            foreach (Ahorros a in listaahorros)
            {
                xmlwriter.WriteStartElement("Ahorros");
                xmlwriter.WriteElementString("Cliente", a.Cliente);
                xmlwriter.WriteElementString("IDCliente", a.Idcliente);
                xmlwriter.WriteElementString("Identificacion", a.Identificacion);
                xmlwriter.WriteElementString("Balance", a.Balance.ToString());
                xmlwriter.WriteElementString("TasaAhorro", a.TasaAhorros.ToString());

                xmlwriter.WriteEndElement();
            }

            xmlwriter.WriteEndElement();

            //End XML Document
            xmlwriter.WriteEndDocument();

            //Close Write
            xmlwriter.Close();
        }
        #endregion

        #region "Cuentas Corrientes"

        private static List<Corrientes> datacorrientes = new List<Corrientes>();


        public List<Corrientes> getCorrientes()
        {
            // Creamos la lista genérica de Personas
            List<Corrientes> listacorrientes = new List<Corrientes>();

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
                                                  double.Parse(c.Element("LimitesDeCreditos").Value),
                                                  double.Parse(c.Element("TasaInteres").Value)



                                              );
                listacorrientes.Add(corriente);

            }




            return listacorrientes;
        }

        public void add(Corrientes c)
        {
            datacorrientes.Add(c);
            WriteXML(datacorrientes);

        }

        private void WriteXML(List<Corrientes> listacorrientes)
        {
            XmlTextWriter xmlwriter = new XmlTextWriter(HttpContext.Current.Server.MapPath("/Datos/Cuentas.xml"), System.Text.Encoding.UTF8);

            //Inicio XML Documento
            xmlwriter.WriteStartDocument(true);
            xmlwriter.Formatting = Formatting.Indented;
            xmlwriter.Indentation = 0;

            //ROOT Element
            xmlwriter.WriteStartElement("Cuentas");
            //Call create nodes method
            foreach (Corrientes c in listacorrientes)
            {
                xmlwriter.WriteStartElement("Corrientes");
                xmlwriter.WriteElementString("Cliente", c.Cliente);
                xmlwriter.WriteElementString("IDCliente", c.Idcliente);
                xmlwriter.WriteElementString("Identificacion", c.Identificacion);
                xmlwriter.WriteElementString("Balance", c.Balance.ToString());
                xmlwriter.WriteElementString("LimiteCreditos", c.LimitesDeCreditos.ToString());
                xmlwriter.WriteElementString("TasaInteres", c.TasaDeInteres.ToString());
                xmlwriter.WriteEndElement();
            }



            xmlwriter.WriteEndElement();

            //End XML Document
            xmlwriter.WriteEndDocument();

            //Close Write
            xmlwriter.Close();

        #endregion


        }
    }
}
