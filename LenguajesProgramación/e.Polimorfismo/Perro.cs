using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajesProgramación.e.Polimorfismo
{
    public class Perro:IAnimal
    {
        private int Patas = 0;
        private string Specie = "";

        public int setPatas(int Patas)
        {
            this.Patas = Patas;
            return this.Patas;
        }

        public string setEspecie(string Specie)
        {
            this.Specie = Specie;
            return this.Specie;
        }

        public void ObtenerCantidadPatas()
        {
            Console.WriteLine("El Perro tiene: " + this.Patas.ToString());
        }

        public void ObtenerEspecie()
        {
            Console.WriteLine("El Perro pertenece a la especie: "+this.Specie);
        }
    }
}
