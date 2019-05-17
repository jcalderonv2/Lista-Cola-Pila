using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estructuras2;

namespace Estructuras.Manager
{
    class OperationManager
    {

        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();

        public OperationManager()
        {

            Primero = null;
            Ultimo = null;

        }
        public void Insert(int num)
        {

            Nodo Nuevo = new Nodo();
            Nuevo.Dato = num;

            if (Primero == null)
            {
                Primero = Nuevo;
                Primero.Siguiente = null;
                Ultimo = Nuevo;
            }
            else
            {
                Ultimo.Siguiente = Nuevo;
                Nuevo.Siguiente = null;
                Ultimo = Nuevo;
            }
        }

        public void ShowList()
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
                Console.WriteLine("\n La lista se encuentra vacia.");
            }


        }
    }
}
