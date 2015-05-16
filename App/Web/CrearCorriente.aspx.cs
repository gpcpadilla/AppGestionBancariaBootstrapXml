using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using App.Modelo;
using App.Datos;

namespace App.Web
{
    public partial class Crear : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            double balance = double.Parse(txtbalance.Text);
            double limitescreditos = double.Parse(txtLimitesCreditos.Text);
            double tasainteres = double.Parse(txtTasaInteres.Text);

            Corrientes c = new Corrientes(
                                        txtcliente.Text, 
                                        txtidentificacion.Text,
                                        txtidcliente.Text,
                                        balance,
                                        limitescreditos,
                                        tasainteres
                                                                              
                                       );

            CuentasRepositorios datacorrientes = new CuentasRepositorios();

            datacorrientes.add(c);
          

        }
    }
}