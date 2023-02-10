using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajesProgramación
{
    public static class CuentaBancaria
    {
        private static decimal Saldo = 0;

        public static decimal ObtenerSaldo()
        {
            return Saldo;
        }

        public static void Depositar(decimal Monto)
        {
            Saldo += Monto;
        }

        public static void Retirar(decimal Monto)
        {
            Saldo -= Monto;
        }

    }
}
