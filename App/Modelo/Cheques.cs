using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace App.Modelo
{
  
   public class Cheques: Cuentas
    {
        #region "Atributos"
        private double tasacheques;
        private static int count = 0;
        private static int numeroTransaciones = 3;
        #endregion

        #region "Propiedades"

        public double TasaCheques
        {
            get { return tasacheques; }
            set { tasacheques = value; }
        }
        #endregion

        #region"Constructores"

        ///<summary>
        ///Contructor por defecto  de Cuenta de Ahorros
        ///</summary>
        ///
        public Cheques():base()
        {
            this.tasacheques = 0;
        }

        public Cheques(string cliente, string identificacion, string idcliente,double balance,double tasacheques)
                    :base( cliente,  identificacion,  idcliente, balance)
        {
            
        }

        #endregion

        #region "Metodos Sobre Escritos"

        public override string ToString()
        {
            return base.ToString() +
                   "\nTasa de Interes: " + this.tasacheques;
        }
        public override bool Equals(object obj)
        {
            Cheques o = (Cheques)obj;
            bool result = false;

            if ((base.Equals(o)) &&
               (this.tasacheques == o.tasacheques))
                result = true;

            return result;
        }

        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }


        public override string depositar(double valor)
        {
            this.Balance+= valor;
            return balanceActual(valor, 'D');
        }
        public override string retitar(double valor)
        {
            count++;
            if (count > numeroTransaciones)
                this.Balance = (this.Balance - (valor + this.tasacheques));

            else
                this.Balance = this.Balance - valor;


            return balanceActual(valor, 'R');
        }

        public override string balanceActual(double valor, char movimiento)
        {
            string result="";

            switch (movimiento)
            {
                case 'R' : 
                            result = "\n=======Movimiento Actual======"
                            + "\nFecha: " + DateTime.Now.ToShortDateString()
                            + "\nHora: " + DateTime.Now.ToShortTimeString()
                            + "\nRetiro por Valor : " + valor 
                            +"\nBalanca actual: " + this.Balance ;
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