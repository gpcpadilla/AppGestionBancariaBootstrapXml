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
            double tasadeinteres = double.Parse(txtTasadeinteres.Text);//ahorro

            Ahorros a = new Ahorros(
                                        txtCliente.Text,
                                        txtIdentificacion.Text,
                                        txtIDcliente.Text,
                                        balance,
                                        tasadeinteres
                                       );

            CuentasAhorros dataa = new CuentasAhorros();
            dataa.add(a);
        }
    }
}