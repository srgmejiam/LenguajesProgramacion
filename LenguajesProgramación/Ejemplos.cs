using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using static LenguajesProgramación.FactoriaRecursivo;
using static LenguajesProgramación.CuentaBancaria;
using System.Security;
using LenguajesProgramación.e.Polimorfismo;

namespace LenguajesProgramación
{
    public static class Ejemplos
    {
        public static void EjemploRecursividad()
        {
            bool Continuar = true;
            int Numero = 0;
            do
            {
                Console.WriteLine("Ingrese el numero");
                Numero = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(Factorial(Numero).ToString() + "\n");
                Console.WriteLine("Desea Calcular el factorial de otro numero, Presione s (SI) y n (NO)");
                Continuar = (Console.ReadLine() == "n") ? false : true;

            } while (Continuar);
        }
        public static void EjemploAbstraccion()
        {
            Automovil Car = new Toyota();

            for (int i = 0; i < 60; i++)
            {
                Car.Acelerar(1);
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(Car.OptenerVelocidad() + " km/h");
            }


            for (int i = 0; i < 60; i++)
            {
                Car.Decelerar(1);
                Thread.Sleep(200);
                Console.Clear();
                Console.WriteLine(Car.OptenerVelocidad() + " km/h");
            }
            Console.ReadLine();
        }
        public static void EjemploHerencia()
        {
            Empleado empleado = new Empleado("Francisco", 32, 50000);
            Console.WriteLine(empleado.Nombre);
            Console.WriteLine(empleado.Edad);
            Console.WriteLine(empleado.Salario);
            Console.ReadLine();
        }
        public static void EjemploEncapsulamiento()
        {
            bool Transaccion;
            do
            {

                Console.WriteLine("Qué operación desea realizar");
                Console.WriteLine("Consultar Saldo  - 1");
                Console.WriteLine("Deporsitar - 2");
                Console.WriteLine("Retirar - 3");
                Console.WriteLine("Salir - 0");
                int Opciones = Convert.ToInt32(Console.ReadLine());
                decimal Monto = 0;

                switch (Opciones)
                {
                    case 0:
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.WriteLine("Su saldo es: " + ObtenerSaldo().ToString());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el monto a depositar");
                        Monto = Convert.ToDecimal(Console.ReadLine());
                        Depositar(Monto);
                        Console.Clear();
                        Console.WriteLine("Su nuevo saldo es: " + ObtenerSaldo().ToString());
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el monto a retirar");
                        Monto = Convert.ToDecimal(Console.ReadLine());
                        Retirar(Monto);
                        Console.Clear();
                        Console.WriteLine("Su nuevo saldo es: " + ObtenerSaldo().ToString());
                        break;
                }

                Console.WriteLine("Desea realizar otra transacción. s (si) , n (no)");
                Transaccion = (Console.ReadLine() == "s");
            }
            while (Transaccion);
        }
        public static void EjemploPolimorfismo()
        {
            Perro Dog = new Perro();

            Console.WriteLine("Ingrese cuantas patas tiene un perro");
            Dog.setPatas(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Ingrese a que especie pertenece un perro");
            Dog.setEspecie(Console.ReadLine());

            Dog.ObtenerCantidadPatas();
            Dog.ObtenerEspecie();
            Console.ReadLine();
        }
    }

}
