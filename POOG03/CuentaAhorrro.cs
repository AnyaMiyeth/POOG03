using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOG03
{
    public class CuentaAhorrro : Cuenta
    {
        public CuentaAhorrro(decimal saldo):base(saldo)
        {

        }

        public override string Consignar(decimal valor)
        {
            if (valor > 0)
            {
                Saldo += valor;
                return $"Se realizó la transacción por el valor {valor} y su saldo es {Saldo}";
            }
            return "Solo se aceptan consignaciones superiores a $0";
        }

        public override string Retirar(decimal valor)
        {
                if (valor <= Saldo)
                {
                    Saldo -= valor;
                    return $"Se realizó la transacción por el valor de {valor} y su saldo es {Saldo}";
                }
                return $"Saldos insuficientes";
        }
    }
}
