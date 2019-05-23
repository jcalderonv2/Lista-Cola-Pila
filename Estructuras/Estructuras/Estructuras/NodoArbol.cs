

namespace Estructuras.Estructuras
{
    class NodoArbol
    {
        private int dato;
        private NodoArbol izquierda;
        private NodoArbol derecha;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public NodoArbol Izquierda
        {
            get { return izquierda; }
            set { izquierda = value; }
        }

        public NodoArbol Derecha
        {
            get { return derecha; }
            set { derecha = value; }
        }
        
    }
}
