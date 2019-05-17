using System;
using Estructuras2;

namespace Estructuras.Manager
{
    internal class OperationManager
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
            var Nuevo = new Nodo();
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

        public void Show()
        {
            var aux = new Nodo();
            aux = Primero;
            if (Primero != null)
                while (aux != null)
                {
                    Console.WriteLine(" - " + aux.Dato);
                    aux = aux.Siguiente;
                }
            else
                Console.WriteLine("\n No hay datos por mostrar.");
        }

        public void search(int dato)
        {
            var Actual = new Nodo();
            Actual = Primero;
            var Encontrado = false;

            if (Primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == dato)
                    {
                        Console.WriteLine("\n El numero " + "'" + dato + "' " + "fue encontrado.");
                        Encontrado = true;
                    }


                    Actual = Actual.Siguiente;
                }

                if (!Encontrado) Console.WriteLine("\n El numero no fue encontrado.");
            }
            else
            {
                Console.WriteLine("\n No hay datos por mostrar.");
            }
        }

        public void delete(int dato)
        {

            Nodo Actual = new Nodo();
            Actual = Primero;
            Nodo Anterior = new Nodo();
            Anterior = null;
            bool Encontrado = false;

            if (Primero != null)
            {

                while (Actual != null && Encontrado != true)
                {

                    if (Actual.Dato == dato)
                    {


                        if (Actual == Primero)
                        {
                            Primero = Primero.Siguiente;
                        }
                        else if (Actual == Ultimo)
                        {
                            Anterior.Siguiente = null;
                            Ultimo = Anterior;
                        }
                        else
                        {
                            Anterior.Siguiente = Actual.Siguiente;
                        }

                        Console.WriteLine("\n El numero " + "'" + dato + "' " + "fue eliminado.");
                        Encontrado = true;

                    }

                    Anterior = Actual;
                    Actual = Actual.Siguiente;

                }

                if (!Encontrado)
                {
                    Console.WriteLine("\n El numero no fue encontrado.");
                }

            }
            else
            {
                Console.WriteLine("\n No hay datos por mostrar.");
            }


        }
    }
}