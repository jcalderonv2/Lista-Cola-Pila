﻿using System;

namespace Estructuras2
{
    class Nodo
    {

        private int dato;
        private Nodo siguiente;

        public int Dato
        {
            get { return dato; }
            set { dato = value; }
        }

        public Nodo Siguiente
        {
            get { return siguiente; }
            set { siguiente = value; }
        }

    }
}
