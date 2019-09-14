using System;
using System.Collections.Generic;
using System.Text;

namespace ABB
{
    public class NodoBinario
    {

        private IComparable dato;
        private NodoBinario hijoIzquierdo;
        private NodoBinario hijoDerecho;

        public NodoBinario(IComparable dato)
        {
            this.dato = dato;
            this.hijoIzquierdo = null;
            this.hijoDerecho = null;
        }

        public IComparable getDato()
        {
            return this.dato;
        }

        public NodoBinario getHijoIzquierdo()
        {
            return this.hijoIzquierdo;
        }

        public NodoBinario getHijoDerecho()
        {
            return this.hijoDerecho;
        }

        public void setDato(IComparable dato)
        {
            this.dato = dato;
        }

        public void setHijoIzquierdo(NodoBinario hijoIzq)
        {
            this.hijoIzquierdo = hijoIzq;
        }

        public void setHijoDerecho(NodoBinario hijoDer)
        {
            this.hijoDerecho = hijoDer;
        }
    }
}
