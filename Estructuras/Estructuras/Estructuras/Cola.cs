using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estructuras.Manager;
using Estructuras2;

namespace Estructuras.Estructuras
{
    class Cola
    {

        private Nodo Primero = new Nodo();
        private Nodo Ultimo = new Nodo();
        OperationManager operation = new OperationManager();

        public Cola()
        {
            Primero = null;
            Ultimo = null;
        }

        public void insertCola(int dato)
        {

           operation.Insert(dato);

        }

        public void showCola()
        {
            
            operation.Show();

        }

        public void searchCola(int dato)
        {
            operation.search(dato);
        }

        //public void deleteCola(int dato)
        //{
        //    operation.delete(dato);
        //}

    }
}
