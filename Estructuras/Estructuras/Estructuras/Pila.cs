using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estructuras.Manager;
using Estructuras2;

namespace Estructuras.Estructuras
{
    class Pila
    {

        private Nodo Primero = new Nodo();
        OperationManager operation = new OperationManager();

        public Pila()
        {

            Primero = null;

        }

        public void insertPila(int dato)
        {

         operation.InsertPila(dato);

        }

        public void showPila()
        {

            operation.Show();

        }

        public void searchPila(int dato)
        {

            operation.search(dato);

        }

        public void deletePila(int dato)
        {

            operation.delete(dato);

        }

    }
}
