using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_de_complegidad
{
    public class NodoGeneral<T>
    {
        private T dato;
        private T Apha;
        private T Beta;
        private List<NodoGeneral<T>> hijos;

        public NodoGeneral(T dato)
        {
            this.dato = dato;
            this.hijos = new List<NodoGeneral<T>>();
        }

        public T Apha1 { get => Apha; set => Apha = value; }
        public T Beta1 { get => Beta; set => Beta = value; }

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
