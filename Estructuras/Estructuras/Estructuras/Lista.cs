using System;
using System.Runtime.InteropServices;
using Estructuras.Manager;

namespace Estructuras2
{
    class Lista
    {

        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();
        OperationManager operation = new OperationManager();

        public Lista()
        {

            Primero = null;
            Ultimo = null;

        }

        public void InsertList(int num)
        {

            operation.Insert(num);
            //Nodo Nuevo = new Nodo();
            //Nuevo.Dato = num;

            //if (Primero == null)
            //{
            //    Primero = Nuevo;
            //    Primero.Siguiente = null;
            //    Ultimo = Nuevo;
            //}
            //else
            //{
            //    Ultimo.Siguiente = Nuevo;
            //    Nuevo.Siguiente = null;
            //    Ultimo = Nuevo;
            //}


        }

        public void ShowList()
        {

            operation.ShowList();
            //Nodo aux = new Nodo();
            //aux = Primero;
            //if (Primero != null)
            //{

            //    while (aux != null)
            //    {

            //        Console.WriteLine(" - " + aux.Dato);
            //        aux = aux.Siguiente;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("\n La lista se encuentra vacia.");
            //}


        }

        public void search(int dato)
        {

            Nodo Actual = new Nodo();
            Actual = Primero;
            bool Encontrado = false;

            if (Primero != null)
            {

                while (Actual != null && Encontrado != true)
                {

                    if (Actual.Dato == dato)
                    {
                        Console.WriteLine("\n El numero " + "'" + dato + "' " + "fue encontrado en la lista.");
                        Encontrado = true;

                    }


                    Actual = Actual.Siguiente;

                }

                if (!Encontrado)
                {
                    Console.WriteLine("\n El numero no fue encontrado en la lista.");
                }

            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia.");
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
                        
                        Console.WriteLine("\n El numero " + "'" + dato + "' " + "fue eliminado de la lista.");
                        Encontrado = true;

                    }

                    Anterior = Actual;
                    Actual = Actual.Siguiente;

                }

                if (!Encontrado)
                {
                    Console.WriteLine("\n El numero no fue encontrado en la lista.");
                }

            }
            else
            {
                Console.WriteLine("\n La lista se encuentra vacia.");
            }


        }

    }
}
