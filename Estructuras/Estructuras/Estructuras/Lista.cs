using Estructuras.Manager;

namespace Estructuras.Estructuras
{
    class Lista
    {

        OperationManager operation = new OperationManager();
       
        public void Sort(int num)
        {

            operation.Sort(num);

        }

        public void ShowList()
        {

            operation.Show();
           
        }

        public void SearchList(int dato)
        {

         operation.Search(dato);
            
        }

        public void DeleteList(int dato)
        {

            operation.Delete(dato);

        }

    }
}
