using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajesProgramación
{
    public class PotenciacionRecursiva
    {
        public void Principal()
        {
            bool Continuar = true;
            int Base = 0;
            int Exponente = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Ingrese la base de la potencia");
                Base = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese el Exponente");
                Exponente = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Potencia(Base, Exponente).ToString() + "\n");
                Console.WriteLine("Desea Calcular otra potencia, Presione s (SI) y n (NO)");
                Continuar = (Console.ReadLine() == "n") ? false : true;

            } while (Continuar);

        }


        static int Potencia(int Base, int Exponente)
        {
            if (Exponente == 0)
            {
                return 1;
            }
            return Base * Potencia(Base, Exponente - 1);
        }
    }
}
