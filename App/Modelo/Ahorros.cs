using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
    public class Ahorros : Cuentas
    {
        #region "Atributos"
        private double tasaahorro;
        private static int count = 0;
        private static int numeroTransaciones = 3;
        #endregion

        #region "Propiedades"

        public double TasaAhorros
        {
            get { return tasaahorro; }
            set { tasaahorro = value; }
        }
        #endregion

        #region"Constructores"

        ///<summary>
        ///Contructor por defecto  de Cuenta de Ahorros
        ///</summary>
        ///
        public Ahorros()
            : base()
        {
            this.tasaahorro = 0;
        }

        public Ahorros(string cliente, string identificacion, string idcliente, double balance, double tasaahorro)
            : base(cliente, identificacion, idcliente, balance)
        {
            
        }

        #endregion

        #region "Metodos Sobre Escritos"

        public override string ToString()
        {
            return base.ToString() +
                   "\nTasa de Interes: " + this.tasaahorro;
        }
        public override bool Equals(object obj)
        {
            Ahorros o = (Ahorros)obj;
            bool result = false;

            if ((base.Equals(o)) &&
               (this.tasaahorro == o.tasaahorro))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }


        public override string depositar(double valor)
        {
            this.Balance += valor;
            return balanceActual(valor, 'D');
        }
        public override string retitar(double valor)
        {
            count++;
            if (count > numeroTransaciones)
                this.Balance = (this.Balance - (valor + this.tasaahorro));

            else
                this.Balance = this.Balance - valor;


            return balanceActual(valor, 'R');
        }

        public override string balanceActual(double valor, char movimiento)
        {
            string result = "";

            switch (movimiento)
            {
                case 'R':
                    result = "\n=======Movimiento Actual======"
                    + "\nFecha: " + DateTime.Now.ToShortDateString()
                    + "\nHora: " + DateTime.Now.ToShortTimeString()
                    + "\nRetiro por Valor : " + valor
                    + "\nBalanca actual: " + this.Balance;
                    break;
                case 'D':
                    result = "\n=======Movimiento Actual======"
                    + "\nFecha: " + DateTime.Now.ToShortDateString()
                    + "\nHora: " + DateTime.Now.ToShortTimeString()
                    + "\nDeposito por Valor : " + valor
                    + "\nBalanca actual: " + this.Balance;
                    break;
                default:
                    result = "\n=======Movimiento Actual======"
                    + "\nFecha: " + DateTime.Now.ToShortDateString()
                    + "\nHora: " + DateTime.Now.ToShortTimeString()
                    + "\nBalanca actual: " + this.Balance;
                    break;

            }


            return result;
        }
        #endregion

    }
}