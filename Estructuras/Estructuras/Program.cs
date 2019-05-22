using System;
using Estructuras.Estructuras;
using Estructuras2;

namespace Estructuras
{

    class Program
    {
        static Lista list = new Lista();
        static Cola cola = new Cola();
        static Pila pila = new Pila();


        static void Main()
        {
            Program CallingTheRealMain = new Program();
            CallingTheRealMain.Main2();


        }

        public void Main2()
        {
            MainMenu();
        }

        private static void MainMenu()
        {

            string option;

            do
            {


                Console.WriteLine("\n ---Menu principal--- \n");
                Console.WriteLine("\n 1.Listas.");
                Console.WriteLine("\n 2.Colas.");
                Console.WriteLine("\n 3.Pilas.");
                Console.WriteLine("\n 4.Salir.");
                Console.WriteLine("\n Seleccione una opcion: \n");

                option = Console.ReadLine();
                Console.WriteLine("\n La opcion seleccionada fue: " + option);
                ProcessMainMenu(option);



            } while (option != "4");

        }

        private static void ProcessMainMenu(string option)
        {
            switch (option)
            {

                case "1":

                    MenuLista();

                    break;

                case "2":

                    MenuCola();

                    break;

                case "3":
                    MenuPila();

                    break;


                default:


                    Console.WriteLine("\n Opcion invalida.");
                    break;

            }
        }

        public static void MenuLista()
        {
            string option;

            do
            {

                Console.WriteLine("\n ---Menu lista--- \n");
                Console.WriteLine("\n 1.Agregar dato.");
                Console.WriteLine("\n 2.Buscar dato.");
                Console.WriteLine("\n 3.Eliminar dato.");
                Console.WriteLine("\n 4.Mostrar lista.");
                Console.WriteLine("\n 5.Pasar dato a cola.");
                Console.WriteLine("\n 6.Pasar dato a pila.");
                Console.WriteLine("\n 7.Atras.");
                Console.WriteLine("\n Seleccione una opcion: \n");

                option = Console.ReadLine();
                Console.WriteLine("\n La opcion seleccionada fue: " + option);
                ProcessList(option);


            } while (option != "7");
        }

        private static void ProcessList(string option)
        {
            switch (option)
            {

                case "1":

                    InsertList();

                    break;

                case "2":

                    SearchList();

                    break;

                case "3":
                    DeleteList();

                    break;

                case "4":
                    ShowList();

                    break;

                case "5":

                    ListaCola();
                    break;

                case "6":

                    ListaPila();
                    break;

                default:

                    Console.WriteLine("\n Opcion invalida.");
                    break;

            }
        }



        public static void InsertList()
        {

            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Digite un numero: \n");
            nuevo.Dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            list.Sort(nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + nuevo.Dato + "' " + "fue ingresado a la lista.");

        }

        private static void SearchList()
        {

            Console.WriteLine("\n Digite el numero que desea buscar: \n");
            int dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            list.SearchList(dato);

        }

        private static void DeleteList()
        {

            ShowList();
            Console.WriteLine("\n Digite el numero que desea eliminar: \n");
            int dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            list.DeleteList(dato);

        }

        static void ShowList()
        {
            Console.WriteLine("\n La lista contiene los siguientes numeros: \n");
            list.ShowList();
            Console.WriteLine();
        }

        public static void ListaCola()
        {

            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Numeros disponibles en la lista: \n");
            ShowList();
            Console.WriteLine("\n Digite el numero que desea pasar a la cola: \n");
            nuevo.Dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            list.ChangeToAnother(nuevo.Dato);
            cola.InsertCola(nuevo.Dato);
            list.DeleteList(nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + nuevo.Dato + "' " + "fue ingresado a la cola.");

        }

        public static void ListaPila()
        {

            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Numeros disponibles en la lista: \n");
            ShowList();
            Console.WriteLine("\n Digite el numero que desea pasar a la pila: \n");
            nuevo.Dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            list.ChangeToAnother(nuevo.Dato);
            pila.InsertPila(nuevo.Dato);
            list.DeleteList(nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + nuevo.Dato + "' " + "fue ingresado a la pila.");

        }


        private static void MenuCola()
        {
            string option;

            do
            {

                Console.WriteLine("\n ---Menu cola--- \n");
                Console.WriteLine("\n 1.Agregar dato.");
                Console.WriteLine("\n 2.Buscar dato.");
                Console.WriteLine("\n 3.Eliminar dato.");
                Console.WriteLine("\n 4.Mostrar cola.");
                Console.WriteLine("\n 5.Pasar dato a lista.");
                Console.WriteLine("\n 6.Pasar dato a pila.");
                Console.WriteLine("\n 7.Atras.");
                Console.WriteLine("\n Seleccione una opcion: \n");

                option = Console.ReadLine();
                Console.WriteLine("\n La opcion seleccionada fue: " + option);
                ProcessCola(option);


            } while (option != "7");
        }

        private static void ProcessCola(string option)
        {
            switch (option)
            {

                case "1":

                    InsertCola();

                    break;

                case "2":

                    SearchCola();

                    break;

                case "3":
                    DeleteCola();

                    break;

                case "4":
                    ShowCola();

                    break;

                case "5":
                    ColaLista();

                    break;

                case "6":
                    ColaPila();

                    break;


                default:

                    Console.WriteLine("\n Opcion invalida.");
                    break;

            }
        }

        private static void InsertCola()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Digite un numero: \n");
            nuevo.Dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            cola.InsertCola(nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + nuevo.Dato + "' " + "fue ingresado a la cola.");
        }

        private static void SearchCola()
        {
            Console.WriteLine("\n Digite el numero que desea buscar: \n");
            int dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            cola.SearchCola(dato);
        }

        private static void DeleteCola()
        {
            ShowCola();
            Console.WriteLine("\n Digite el numero que desea eliminar: \n");
            int dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            cola.DeleteCola(dato);
        }

        private static void ShowCola()
        {
            Console.WriteLine("\n La cola contiene los siguientes numeros: \n");
            cola.ShowCola();
            Console.WriteLine();
        }

        public static void ColaLista()
        {

            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Numeros disponibles en la cola: \n");
            ShowCola();
            Console.WriteLine("\n Digite el numero que desea pasar a la lista: \n");
            nuevo.Dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            cola.ChangeToAnother(nuevo.Dato);
            list.Sort(nuevo.Dato);
            cola.DeleteCola(nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + nuevo.Dato + "' " + "fue ingresado a la lista.");

        }

        public static void ColaPila()
        {

            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Numeros disponibles en la cola: \n");
            ShowCola();
            Console.WriteLine("\n Digite el numero que desea pasar a la pila: \n");
            nuevo.Dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            cola.ChangeToAnother(nuevo.Dato);
            pila.InsertPila(nuevo.Dato);
            cola.DeleteCola(nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + nuevo.Dato + "' " + "fue ingresado a la pila.");

        }

        private static void MenuPila()
        {
            string option;

            do
            {

                Console.WriteLine("\n ---Menu pila--- \n");
                Console.WriteLine("\n 1.Agregar dato.");
                Console.WriteLine("\n 2.Buscar dato.");
                Console.WriteLine("\n 3.Eliminar dato.");
                Console.WriteLine("\n 4.Mostrar pila.");
                Console.WriteLine("\n 5.Pasar dato a lista.");
                Console.WriteLine("\n 6.Pasar dato a cola.");
                Console.WriteLine("\n 7.Atras.");
                Console.WriteLine("\n Seleccione una opcion: \n");

                option = Console.ReadLine();
                Console.WriteLine("\n La opcion seleccionada fue: " + option);
                ProcessPila(option);


            } while (option != "7");
        }

        private static void ProcessPila(string option)
        {
            switch (option)
            {

                case "1":

                    InsertPila();

                    break;

                case "2":

                    SearchPila();

                    break;

                case "3":
                    DeletePila();

                    break;

                case "4":
                    ShowPila();

                    break;

                case "5":
                    PilaLista();

                    break;

                case "6":
                    PilaCola();

                    break;


                default:

                    Console.WriteLine("\n Opcion invalida.");
                    break;

            }
        }



        private static void InsertPila()
        {
            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Digite un numero: \n");
            nuevo.Dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            pila.InsertPila(nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + nuevo.Dato + "' " + "fue ingresado a la pila.");
        }

        private static void ShowPila()
        {
            Console.WriteLine("\n La pila contiene los siguientes numeros: \n");
            pila.ShowPila();
            Console.WriteLine();
        }

        private static void SearchPila()
        {
            Console.WriteLine("\n Digite el numero que desea buscar: \n");
            int dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            pila.SearchPila(dato);
        }

        private static void DeletePila()
        {
            ShowPila();
            Console.WriteLine("\n Digite el numero que desea eliminar: \n");
            int dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            pila.DeletePila(dato);
        }

        public static void PilaLista()
        {

            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Numeros disponibles en la pila: \n");
            ShowPila();
            Console.WriteLine("\n Digite el numero que desea pasar a la lista: \n");
            nuevo.Dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            pila.ChangeToAnother(nuevo.Dato);
            list.Sort(nuevo.Dato);
            pila.DeletePila(nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + nuevo.Dato + "' " + "fue ingresado a la lista.");

        }

        public static void PilaCola()
        {

            Nodo nuevo = new Nodo();
            Console.WriteLine("\n Numeros disponibles en la pila: \n");
            ShowPila();
            Console.WriteLine("\n Digite el numero que desea pasar a la cola: \n");
            nuevo.Dato = int.Parse(Console.ReadLine() ?? throw new InvalidOperationException());
            pila.ChangeToAnother(nuevo.Dato);
            cola.InsertCola(nuevo.Dato);
            pila.DeletePila(nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + nuevo.Dato + "' " + "fue ingresado a la cola.");

        }
    }
}
