using System;
using System.Collections.Generic;
using System.Text;

namespace ABB
{
    public class AVL
    {
        private NodoAVL raiz;

        public AVL()
        {
            this.raiz = null;
        }

        public AVL(IComparable dato)
        {
            this.raiz = new NodoAVL(dato);
        }

        private AVL(NodoAVL nodo)
        {
            this.raiz = nodo;
        }

        private NodoAVL getRaiz()
        {
            return raiz;
        }

        public IComparable getDatoRaiz()
        {
            if (this.getRaiz() != null)
            {
                return this.getRaiz().getDato();
            }
            else
            {
                return null;
            }
        }

        public AVL getHijoIzquierdo()
        {
            return new AVL(this.raiz.getHijoIzquierdo());
        }

        public AVL getHijoDerecho()
        {
            return new AVL(this.raiz.getHijoDerecho());
        }

        public void agregarHijoIzquierdo(AVL hijo)
        {
            this.raiz.setHijoIzquierdo(hijo.getRaiz());
        }

        public void agregarHijoDerecho(AVL hijo)
        {
            this.raiz.setHijoDerecho(hijo.getRaiz());
        }

        public void eliminarHijoIzquierdo()
        {
            this.raiz.setHijoIzquierdo(null);
        }

        public void eliminarHijoDerecho()
        {
            this.raiz.setHijoDerecho(null);
        }

        public void agregar(IComparable elem)
        {
        }


        public void rotacionSimpleDerecha()
        {

        }

        public void rotacionSimpleIzquierda()
        {

        }

        public void rotacionDobleDerecha()
        {

        }


        public void rotacionDobleIzquierda()
        {

        }


    }
}
