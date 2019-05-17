using System;
using Estructuras.Estructuras;
using Estructuras2;

namespace Estructuras
{

    class Program
    {
        static Lista list = new Lista();
        static Cola cola = new Cola();
        

        static void Main(string[] args)
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

                    menuLista();

                    break;

                case "2":

                    menuCola();

                    break;

                case "3":
                    menuPila();

                    break;


                default:

                    
                    Console.WriteLine("\n Opcion invalida.");
                    break;

            }
        }

        private  static void menuLista()
        {
            string option;

            do
            {
                
                Console.WriteLine("\n ---Menu lista--- \n");
                Console.WriteLine("\n 1.Agregar dato.");
                Console.WriteLine("\n 2.Buscar dato.");
                Console.WriteLine("\n 3.Eliminar dato.");
                Console.WriteLine("\n 4.Mostrar lista.");
                Console.WriteLine("\n 5.Atras.");
                Console.WriteLine("\n Seleccione una opcion: \n");

                option = Console.ReadLine();
                Console.WriteLine("\n La opcion seleccionada fue: " + option);
                ProcessList(option);


            } while (option != "5");
        }

        private static void ProcessList(string option)
        {
            switch (option)
            {

                case "1":

                    insertList();

                    break;

                case "2":

                    searchList();

                    break;

                case "3":
                    deleteList();

                    break;

                case "4":
                    showList();

                    break;


                default:
                    
                    Console.WriteLine("\n Opcion invalida.");
                    break;

            }
        }

        

        public static void insertList()
        {
            
            Nodo Nuevo = new Nodo();
            Console.WriteLine("\n Digite un numero: \n");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            list.InsertList(Nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + Nuevo.Dato + "' " + "fue ingresado a la lista.");

        }

        private static void searchList()
        {
           
            Console.WriteLine("\n Digite el numero que desea buscar: \n");
            int Dato = int.Parse(Console.ReadLine());

            list.searchList(Dato);
            
        }


        private static void deleteList()
        {
            
            showList();
            Console.WriteLine("\n Digite el numero que desea eliminar: \n");
            int Dato = int.Parse(Console.ReadLine());

            list.deleteList(Dato);
        }

        static void showList()
        {
            Console.WriteLine("\n La lista contiene los siguientes numeros: \n");
            list.ShowList();
            Console.WriteLine();
        }


        private static void menuCola()
        {
            string option;

            do
            {

                Console.WriteLine("\n ---Menu cola--- \n");
                Console.WriteLine("\n 1.Agregar dato.");
                Console.WriteLine("\n 2.Buscar dato.");
                Console.WriteLine("\n 3.Eliminar dato.");
                Console.WriteLine("\n 4.Mostrar cola.");
                Console.WriteLine("\n 5.Atras.");
                Console.WriteLine("\n Seleccione una opcion: \n");

                option = Console.ReadLine();
                Console.WriteLine("\n La opcion seleccionada fue: " + option);
                ProcessCola(option);


            } while (option != "5");
        }

        private static void ProcessCola(string option)
        {
            switch (option)
            {

                case "1":

                    insertCola();

                    break;

                case "2":

                    searchCola();

                    break;

                case "3":
                    deleteCola();

                    break;

                case "4":
                    showCola();

                    break;


                default:

                    Console.WriteLine("\n Opcion invalida.");
                    break;

            }
        }

        private static void insertCola()
        {
            Nodo Nuevo = new Nodo();
            Console.WriteLine("\n Digite un numero: \n");
            Nuevo.Dato = int.Parse(Console.ReadLine());

            cola.insertCola(Nuevo.Dato);
            Console.WriteLine("\n El numero " + "'" + Nuevo.Dato + "' " + "fue ingresado a la cola.");
        }

        private static void searchCola()
        {
            Console.WriteLine("\n Digite el numero que desea buscar: \n");
            int Dato = int.Parse(Console.ReadLine());

            cola.searchCola(Dato);
        }

        private static void deleteCola()
        {
            showCola();
            Console.WriteLine("\n Digite el numero que desea eliminar: \n");
            int Dato = int.Parse(Console.ReadLine());

            cola.deleteCola(Dato);
        }

        private static void showCola()
        {
            Console.WriteLine("\n La cola contiene los siguientes numeros: \n");
            cola.showCola();
            Console.WriteLine();
        }

        private static void menuPila()
        {
            throw new NotImplementedException();
        }




    }
}
