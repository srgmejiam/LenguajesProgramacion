using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajesProgramación
{
    abstract class Automovil
    {
        protected int Velocidad;
        public Automovil()
        {
            Velocidad = 0;
        }

        public abstract void Acelerar(int kmh);
        public abstract void Decelerar(int kmph);
        public int OptenerVelocidad()
        {
            return Velocidad;
        }
    }

    class Toyota : Automovil
    {
        public Toyota()
        {

        }

        public override void Acelerar(int kmh)
        {
            Velocidad   += kmh;
        }
        public override void Decelerar(int kmph)
        {
           Velocidad -= kmph;
        }
    }
}
