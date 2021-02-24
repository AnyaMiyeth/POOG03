using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOG03
{
    class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuenta = new CuentaAhorrro(10000);
            Console.WriteLine(cuenta.Retirar(10000000));
            Console.WriteLine(cuenta.Retirar(10000));
            Console.WriteLine(cuenta.Consignar(20000));
            Console.WriteLine(cuenta.Consignar(-1));
            Console.WriteLine(cuenta.ConsultarSaldo());



            Console.ReadKey();

        }
    }
}
