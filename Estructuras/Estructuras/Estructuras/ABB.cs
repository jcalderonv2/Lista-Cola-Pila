using Estructuras.Manager;

namespace Estructuras.Estructuras
{
    class ABB
    {
        OperationManager operation = new OperationManager();
        
        public void InsertABB(int dato)
        {
            operation.InsertArbol(dato);
        }

        public void PreOrden(NodoArbol raiz)
        {
            operation.PreOrden(operation._raiz);
        }

        public void InOrden(NodoArbol raiz)
        {
            operation.InOrden(operation._raiz);
        }

        public void PostOrden(NodoArbol raiz)
        {
            operation.PostOrden(operation._raiz);
        }
    }
}
