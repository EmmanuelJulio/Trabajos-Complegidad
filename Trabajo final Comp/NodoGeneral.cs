using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_final_Comp
{
    public class NodoGeneral<T>
    {
        private T dato;
        private int alpha=0;
        private int beta=0;
        private List<NodoGeneral<T>> hijos;

        public NodoGeneral(T dato)
        {
            this.dato = dato;
            this.hijos = new List<NodoGeneral<T>>();
        }

        public int Alpha { get => alpha; set => alpha = value; }
        public int Beta { get => beta; set => beta = value; }

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
