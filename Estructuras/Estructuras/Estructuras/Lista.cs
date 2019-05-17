using System;
using System.Runtime.InteropServices;
using Estructuras.Manager;

namespace Estructuras2
{
    class Lista
    {

        OperationManager operation = new OperationManager();


        public void InsertList(int num)
        {

            operation.Insert(num);
            
        }

        public void ShowList()
        {

            operation.Show();
           
        }

        public void searchList(int dato)
        {

         operation.search(dato);
            
        }

        public void deleteList(int dato)
        {

            operation.delete(dato);

        }

    }
}
