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
            double limitesDeCreditos = double.Parse(txtlimitesDeCreditos.Text);
            double tasaInteres = double.Parse(txttasaInteres.Text);

            Corrientes c = new Corrientes(
                                        txtcliente.Text, 
                                        txtidentificacion.Text,
                                        txtidcliente.Text,
                                        balance,
                                        limitesDeCreditos,
                                        tasaInteres
                                                                              
                                       );

            CuentasCorrientes data = new CuentasCorrientes();

            data.add(c);
          

        }
    }
}