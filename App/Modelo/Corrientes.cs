using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
     public class Corrientes : Cuentas
    {
        #region "Atributos"
        private double limitescreditos;
        private double tasainteres;
        private static int count = 0;
        private static int numeroTransaciones = 3;
        #endregion

        #region "Propiedades"
        public double LimitesDeCreditos
        {
            get { return limitescreditos; }
            set { limitescreditos = value; }
        }
        public double TasaDeInteres
        {
            get { return tasainteres; }
            set { tasainteres = value; }
        }
        #endregion

        #region "Costructores"
        ///<summary>
        ///Contructor de Cuenta Corriente
        ///</summary>
        public Corrientes()
            : base()
        {
            this.limitescreditos = 0;
            this.tasainteres = 0;
        }
        public Corrientes(string cliente, string identificacion, string idcliente, double balance, double limitescreditos, double tasadeinteres)
            : base(cliente, identificacion, idcliente, balance)
        {
            
        }
        #endregion

        #region "Metodos Sobre Escritos"
        public override string ToString()
        {
            return base.ToString() +
                     "\nLimite de Creditos:  " + this.limitescreditos + "\n" +
                     "\nTasa de Interes:  " + this.tasainteres;
        }

        public override bool Equals(object obj)
        {
            Corrientes o = (Corrientes)obj;
            bool result = false;

            if ((base.Equals(o)) &&
                (this.limitescreditos == o.limitescreditos) &&
                (this.tasainteres == o.tasainteres))

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
            if ((count > numeroTransaciones) && (valor < this.limitescreditos))
                this.Balance = (this.Balance - (valor + this.tasainteres));

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