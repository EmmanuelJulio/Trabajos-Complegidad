using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_de_complegidad
{
    public class NodoGeneral<T>
    {
        private T dato;
        private List<NodoGeneral<T>> hijos;

        public NodoGeneral(T dato)
        {
            this.dato = dato;
            this.hijos = new List<NodoGeneral<T>>();
        }

        public T getDato()
        {
            return this.dato;
        }

        public List<NodoGeneral<T>> getHijos()
        {
            return this.hijos;
        }

        public void setDato(T dato)
        {
            this.dato = dato;
        }

        public void setHijos(NodoGeneral<T> Hijo)
        {
            this.hijos.Add(Hijo);
        }

    }
}
