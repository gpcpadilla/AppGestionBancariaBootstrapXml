using App.Datos;
using App.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace App.Web
{
    public partial class CrearAhorro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e){     
        }
        protected void btnGuardar_Click(object sender, EventArgs e)        {
            double balance = double.Parse(txtBalance.Text);
            double tasaahorro = double.Parse(txtTasaAhorro.Text);//ahorro

            Ahorros t = new Ahorros(
                                        txtCliente.Text,
                                        txtIdentificacion.Text,
                                        txtIDcliente.Text,
                                        balance,
                                        tasaahorro
                                       );

            CuentasRepositorios dataahorros = new CuentasRepositorios();
            dataahorros.add(t);
        }
    }
}