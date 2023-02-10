using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajesProgramación.f.Listas
{
    public class Ejercicios
    {
        public void EjecutarEjemplo()
        {
            bool Continuar = true;
            int Opciones = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("¿Que operación desea realizar?");
                Console.WriteLine("Presione: ");
                Console.WriteLine("0: Salir ");
                Console.WriteLine("1: Imprimir lista de Clientes ");
                Console.WriteLine("2: Agregar Cliente ");
                Console.WriteLine("3: Actualizar Cliente ");
                Console.WriteLine("4: Eliminar Cliente ");

                try { Opciones = Convert.ToInt32(Console.ReadLine()); } catch { Opciones = 0; }

                Metodos metodos = new Metodos();

                switch (Opciones)
                {
                    case 0:
                        Continuar = false;
                        break;

                    case 1:
                        Console.Clear();
                        metodos.ImprimirClientes();
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Cliente clienteNuevo = new Cliente();
                        clienteNuevo.Id = metodos.CantidadClientes() + 1;

                        Console.WriteLine("Ingrese El Nombre del Cliente");
                        clienteNuevo.Nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese El Corro del Cliente");
                        clienteNuevo.Correo = Console.ReadLine();

                        Console.WriteLine("Ingrese El Celular del Cliente");
                        clienteNuevo.Celular = Console.ReadLine();

                        if (!metodos.AgregarCliente(clienteNuevo))
                        {
                            Console.WriteLine("Error al guardar el cliente!!!");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("Cliente agregado con exito!!!");
                        Console.ReadLine();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Ingrese el ID del Cliente");
                        int ID = Convert.ToInt32(Console.ReadLine());

                        Cliente clienteActualizar = new Cliente();
                        clienteActualizar = metodos.ObtenerCliente(ID);

                        if (clienteActualizar == null)
                        {
                            Console.WriteLine("Usuario No Existe en Base de Datos");
                            Console.ReadLine();
                            break;
                        }

                        Console.WriteLine("Nombre Actual: " + clienteActualizar.Nombre + " Digite el nuevo nombre o precione enter para continuar");
                        string Nombre = Console.ReadLine();
                        clienteActualizar.Nombre = (Nombre != string.Empty) ? Nombre : clienteActualizar.Nombre;

                        Console.WriteLine("Correo Actual: " + clienteActualizar.Correo + " Digite el nuevo correo o precione enter para continuar");
                        string Correo = Console.ReadLine();
                        clienteActualizar.Correo = (Correo != string.Empty) ? Correo : clienteActualizar.Correo;

                        Console.WriteLine("Celular Actual: " + clienteActualizar.Celular + " Digite el nuevo celular o precione enter para continuar");
                        string Celular = Console.ReadLine();
                        clienteActualizar.Celular = (Celular != string.Empty) ? Celular : clienteActualizar.Celular;

                        if (!metodos.ActualizarCliente(clienteActualizar))
                        {
                            Console.WriteLine("Error al actualizar el cliente!!!");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("Cliente actualizado con exito!!!");
                        Console.ReadLine();
                        break;

                    case 4:
                        Console.Clear();
                        Console.WriteLine("Ingrese el ID del Cliente");
                        int Id = Convert.ToInt32(Console.ReadLine());

                        Cliente clienteAnular = new Cliente();
                        clienteAnular = metodos.ObtenerCliente(Id);

                        if (clienteAnular == null)
                        {
                            Console.WriteLine("Usuario No Existe en Base de Datos");
                            Console.ReadLine();
                            break;
                        }

                        if(!metodos.EliminarCliente(clienteAnular))
                        {
                            Console.WriteLine("Error al anular el cliente!!!");
                            Console.ReadLine();
                            break;
                        }
                        Console.WriteLine("Cliente anulado con exito!!!");
                        Console.ReadLine();
                        break;
                }
            }
            while (Continuar);
        }
    }

    public class Metodos
    {
        private static List<Cliente> Clientes = new List<Cliente>();
        public void ImprimirClientes()
        {
            foreach (var Cliente in Clientes)
            {
                Console.WriteLine(Cliente.Id.ToString() + "\t" + Cliente.Nombre + "\t" + Cliente.Correo + "\t" + Cliente.Celular);
            }
        }
        public Cliente ObtenerCliente(int Id)
        {
            return Clientes.Find(x => x.Id == Id);
        }
        public bool AgregarCliente(Cliente Entidad)
        {
            try
            {
                Clientes.Add(Entidad);
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool ActualizarCliente(Cliente Entidad)
        {
            try
            {
                Cliente Cliente = ObtenerCliente(Entidad.Id);
                Cliente.Nombre = Entidad.Nombre;
                Cliente.Correo = Entidad.Correo;
                Cliente.Celular = Entidad.Celular;
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool EliminarCliente(Cliente Entidad)
        {
            try
            {
                Clientes.Remove(Entidad);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public int CantidadClientes()
        {
            return Clientes.Count;
        }
    }

    public class Cliente
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
    }
}
