using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LenguajesProgramación
{
    public class ListasEnlazadas
    {
       public static void main()
        {
            ListaEnlazada listaEnlazada = new ListaEnlazada();
            listaEnlazada.Add(20);
            listaEnlazada.Add(30);
            listaEnlazada.Add(40);

            listaEnlazada.Print();
            Console.ReadLine();
        }
    }
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }

        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }
    public class ListaEnlazada
    {
        private Node head;

        public ListaEnlazada()
        {
            head = null;
        }

        public void Add(int data)
        {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
        }

        public void Print()
        {
            Node current = head;
            while (current != null)
            {
                Console.WriteLine(current.Data);
                current = current.Next;
            }
        }
    }
}
