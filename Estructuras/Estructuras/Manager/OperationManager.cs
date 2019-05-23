using System;
using Estructuras.Estructuras;
using Estructuras2;

namespace Estructuras.Manager
{
    internal class OperationManager
    {
        private Nodo _primero = new Nodo();
        private Nodo _ultimo = new Nodo();
        public NodoArbol _raiz = new NodoArbol();



        public OperationManager()
        {
            _primero = null;
            _ultimo = null;
            _raiz = null;

        }

        public void Insert(int num)
        {
            var nuevo = new Nodo();
            nuevo.Dato = num;

            if (_primero == null)
            {
                _primero = nuevo;
                _primero.Siguiente = null;
                _ultimo = nuevo;
            }
            else
            {
                _ultimo.Siguiente = nuevo;
                nuevo.Siguiente = null;
                _ultimo = nuevo;
            }
        }

        public void Sort(int num)
        {

            Nodo nuevo = new Nodo();
            nuevo.Dato = num;

            if (_primero == null)
            {
                _primero = nuevo;
            }
            else
            {
                if (num < _primero.Dato)
                {
                    nuevo.Siguiente = _primero;
                    _primero = nuevo;
                }
                else
                {
                    Nodo aux = _primero;
                    Nodo atras = _primero;

                    while (num >= aux.Dato && aux.Siguiente != null)
                    {
                        atras = aux;
                        aux = aux.Siguiente;
                    }
                    if (num >= aux.Dato)
                    {
                        aux.Siguiente = nuevo;
                    }
                    else
                    {
                        nuevo.Siguiente = aux;
                        atras.Siguiente = nuevo;
                    }
                }
            }

        }

        public void Show()
        {
            var aux = new Nodo();
            aux = _primero;
            if (_primero != null)
                while (aux != null)
                {
                    Console.WriteLine(" - " + aux.Dato);
                    aux = aux.Siguiente;
                }
            else
                Console.WriteLine("\n No hay datos por mostrar.");
        }

        public void Search(int dato)
        {
            var Actual = new Nodo();
            Actual = _primero;
            var Encontrado = false;

            if (_primero != null)
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

        public void Delete(int dato)
        {

            Nodo Actual = new Nodo();
            Actual = _primero;
            Nodo Anterior = new Nodo();
            Anterior = null;
            bool Encontrado = false;

            if (_primero != null)
            {

                while (Actual != null && Encontrado != true)
                {

                    if (Actual.Dato == dato)
                    {


                        if (Actual == _primero)
                        {
                            _primero = _primero.Siguiente;
                        }
                        else if (Actual == _ultimo)
                        {
                            Anterior.Siguiente = null;
                            _ultimo = Anterior;
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

        public void InsertPila(int dato)
        {

            var nuevo = new Nodo();
            nuevo.Dato = dato;

            nuevo.Siguiente = _primero;
            _primero = nuevo;
        }

        public void Change(int dato)
        {
            Program CallingTheRealMain = new Program();
            var Actual = new Nodo();
            Actual = _primero;
            var Encontrado = false;



            if (_primero != null)
            {
                while (Actual != null && Encontrado != true)
                {
                    if (Actual.Dato == dato)
                    {
                        Encontrado = true;
                    }


                    Actual = Actual.Siguiente;
                }


                if (!Encontrado)
                {
                    Console.WriteLine("\n El numero no fue encontrado, por favor vuelva a intentarlo.");
                    CallingTheRealMain.Main2();

                }

            }
            else
            {
                Console.WriteLine("\n No hay datos por mostrar.");
            }

        }

        public void InsertArbol(int dato)
        {
            var Nuevo = new NodoArbol();
            Nuevo.Dato = dato;
            Nuevo.Izquierda = null;
            Nuevo.Derecha = null;

            if (_raiz == null)
            {
                _raiz = Nuevo;
            }
            else
            {
                NodoArbol anterior = null, recorrer;
                recorrer = _raiz;

                while (recorrer != null)
                {
                    anterior = recorrer;

                    if (dato > recorrer.Dato)
                    {
                        recorrer = recorrer.Derecha;
                    }
                    else
                    {
                        recorrer = recorrer.Izquierda;
                    }
                }

                if (dato > anterior.Dato)
                {
                    anterior.Derecha = Nuevo;
                }
                else
                {
                    anterior.Izquierda = Nuevo;
                }
            }
        }

        public void PreOrden(NodoArbol raiz)
        {

            Console.WriteLine(" - " + raiz.Dato);

            if (raiz.Izquierda != null)
            {
                PreOrden(raiz.Izquierda);
            }

            if (raiz.Derecha != null)
            {
                PreOrden(raiz.Derecha);
            }

        }

        public void InOrden(NodoArbol raiz)
        {
            if (raiz.Izquierda != null)
            {
                InOrden(raiz.Izquierda);
            }
            Console.WriteLine(" - " + raiz.Dato);
            if (raiz.Derecha != null)
            {
                InOrden(raiz.Derecha);
            }

        }

        public void PostOrden(NodoArbol raiz)
        {
            if (raiz.Izquierda != null)
            {
                PostOrden(raiz.Izquierda);
            }

            if (raiz.Derecha != null)
            {
                PostOrden(raiz.Derecha);
            }

            Console.WriteLine(" - " + raiz.Dato);
        }
    }
}