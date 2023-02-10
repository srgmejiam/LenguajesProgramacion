using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajesProgramación
{
    public class Empleado : Persona
    {
        public int Salario;

        public Empleado(string Nombre, int Edad, int Salario) : base(Nombre, Edad)
        {
            this.Salario = Salario;
        }
    }
}
