using Estructuras.Manager;

namespace Estructuras.Estructuras
{
    class Pila
    {
        
        OperationManager operation = new OperationManager();

        public void InsertPila(int dato)
        {

         operation.InsertPila(dato);

        }

        public void ShowPila()
        {

            operation.Show();

        }

        public void SearchPila(int dato)
        {

            operation.Search(dato);

        }

        public void DeletePila(int dato)
        {

            operation.Delete(dato);

        }

    }
}
