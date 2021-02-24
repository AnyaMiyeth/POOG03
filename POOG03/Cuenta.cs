using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOG03
{
    public abstract class Cuenta
    {
       

        public Cuenta(decimal saldo)
        {
            this.Saldo = saldo;
        }

        public decimal Saldo { set; get; }


        public abstract string Retirar(decimal valor);

        public abstract string Consignar(decimal valor);
        
        public decimal ConsultarSaldo() {
            return Saldo;
        }

    }
}
