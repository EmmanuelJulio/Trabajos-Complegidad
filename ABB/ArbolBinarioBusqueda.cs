using System;
using System.Collections.Generic;
using System.Text;

namespace ABB
{
    public class ArbolBinarioBusqueda
    {
        private NodoBinario raiz;

        public ArbolBinarioBusqueda()
        {
            this.raiz = null;
        }

        public ArbolBinarioBusqueda(IComparable dato)
        {
            this.raiz = new NodoBinario(dato);
        }

        private ArbolBinarioBusqueda(NodoBinario nodo)
        {
            this.raiz = nodo;
        }

        private NodoBinario getRaiz()
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

        public ArbolBinarioBusqueda getHijoIzquierdo()
        {
            return new ArbolBinarioBusqueda(this.raiz.getHijoIzquierdo());
        }

        public ArbolBinarioBusqueda getHijoDerecho()
        {
            return new ArbolBinarioBusqueda(this.raiz.getHijoDerecho());
        }

        public void agregarHijoIzquierdo(ArbolBinarioBusqueda hijo)
        {
            this.raiz.setHijoIzquierdo(hijo.getRaiz());
        }

        public void agregarHijoDerecho(ArbolBinarioBusqueda hijo)
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
            NodoBinario nuevo;
            nuevo = new NodoBinario(elem);
           if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                NodoBinario anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (Convert.ToInt32(elem) < Convert.ToInt32(reco.getDato()))
                    {
                        nuevo.setHijoIzquierdo(reco);
                    }
                    else
                        nuevo.setHijoIzquierdo(reco);
                }
            }
        }


        public bool incluye(IComparable elem)
        {
            return false;
        }


        public void preorden()
        {
        }

        public void inorden()
        {
        }

        public void postorden()
        {
        }


    }
}
