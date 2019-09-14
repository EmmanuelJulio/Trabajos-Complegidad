using System;
using System.Collections.Generic;
using System.Text;

namespace ABB
{
    public class NodoAVL
    {

        private IComparable dato;
        private NodoAVL hijoIzquierdo;
        private NodoAVL hijoDerecho;
        private int altura;

        public NodoAVL(IComparable dato)
        {
            this.dato = dato;
            this.hijoIzquierdo = null;
            this.hijoDerecho = null;
        }

        public IComparable getDato()
        {
            return this.dato;
        }

        public NodoAVL getHijoIzquierdo()
        {
            return this.hijoIzquierdo;
        }

        public int getAltura()
        {
            return this.altura;
        }

        public void setAltura(int h)
        {
            this.altura = h;
        }

        public NodoAVL getHijoDerecho()
        {
            return this.hijoDerecho;
        }

        public void setDato(IComparable dato)
        {
            this.dato = dato;
        }

        public void setHijoIzquierdo(NodoAVL hijoIzq)
        {
            this.hijoIzquierdo = hijoIzq;
        }

        public void setHijoDerecho(NodoAVL hijoDer)
        {
            this.hijoDerecho = hijoDer;
        }
    }
}
