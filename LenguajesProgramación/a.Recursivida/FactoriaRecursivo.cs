﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajesProgramación
{
    public class FactoriaRecursivo
    {
        public static int Factorial(int n)
        {
            if(n== 0)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }

    }
}
