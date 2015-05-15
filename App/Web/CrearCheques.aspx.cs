﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using App.Modelo;
using System.Xml;
using System.Web.Hosting;
using System.IO;
using System.Xml.Linq;
using App.Datos;


namespace App.Web
{
    public partial class CrearCheques : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            double balance = double.Parse(txtBalance.Text);
            double tasadeinterest = double.Parse(txtTasadeinterest.Text);//chques

            Cheques t = new Cheques(
                                        txtCliente.Text,
                                        txtIdentificacion.Text,
                                        txtIDcliente.Text,
                                        balance,
                                        tasadeinterest
                                       );

            CuentasCheques datab = new CuentasCheques();
            datab.add(t);
        }

       
    }
}