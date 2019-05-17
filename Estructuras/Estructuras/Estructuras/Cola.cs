using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estructuras2;

namespace Estructuras.Estructuras
{
    class Cola
    {

        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public Cola()
        {
            Primero = null;
            Ultimo = null;
        }

        public void insert(int dato)
        {

            Nodo nuevo = new Nodo();
            nuevo.Dato = dato;

            if (Primero == null)
            {
                Primero = nuevo;
                Primero.Siguiente = null;
                Ultimo = nuevo;
            }
            else
            {
                Ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                Ultimo = nuevo;
            }

        }

        public void showCola()
        {
            Nodo aux = new Nodo();
            aux = Primero;
            if (Primero != null)
            {
                while (aux != null)
                {
                    Console.WriteLine(" - " + aux.Dato);
                    aux = aux.Siguiente;
                }
            }
            else
            {
                Console.WriteLine("La lista se encuentra vacia.");
            }
        }

    }
}
