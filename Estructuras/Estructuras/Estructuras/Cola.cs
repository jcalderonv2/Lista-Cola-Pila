using Estructuras.Manager;

namespace Estructuras.Estructuras
{
    class Cola
    {
        
        OperationManager operation = new OperationManager();

        public void InsertCola(int dato)
        {

           operation.Insert(dato);

        }

        public void ShowCola()
        {
            
            operation.Show();

        }

        public void SearchCola(int dato)
        {
            operation.Search(dato);
        }

        public void DeleteCola(int dato)
        {
            operation.Delete(dato);
        }

        public void ChangeToAnother(int dato)
        {

            operation.Change(dato);

        }

    }
}
