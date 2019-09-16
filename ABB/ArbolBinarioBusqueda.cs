using System;
using System.Collections.Generic;
using System.Text;

namespace ABB
{
    public class ArbolBinarioBusqueda
    {
        public NodoBinario raiz;

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
            NodoBinario Nuevo;
            Nuevo = new NodoBinario(elem);
            if (raiz == null)
                raiz = Nuevo;
            else  
            {
                NodoBinario anterior = null, reco;
                reco = raiz;
               while (reco != null)
                {
                    anterior = reco;
                    if (elem.CompareTo(reco.getDato()) < 0)
                        reco = reco.getHijoIzquierdo();
                    else
                        reco = reco.getHijoDerecho();
                }
                if (elem.CompareTo(anterior.getDato()) > 0)
                    anterior.setHijoIzquierdo(Nuevo);
                else
                    anterior.setHijoDerecho(Nuevo);

            }
        }

        public bool incluye(IComparable elem)
        {
            if (this.getDatoRaiz().Equals(elem))
            {
                return true;
            }
            else
            {
                if (this.EsHoja(elem))
                {
                    return false;
                }
                else
                {
                    if (this.getHijoIzquierdo() != null)
                    {
                        return this.getHijoIzquierdo().incluye(elem);
                    }
                    if (this.getHijoDerecho() != null)
                    {
                        return this.getHijoDerecho().incluye(elem);
                    }
                    return true;
                }
            }

        }
        public bool EsHoja(IComparable element)
        {
            if(this.getHijoDerecho()==null & this.getHijoIzquierdo() == null)
            {

                return true;
            }
            else
            {
                return false;
            }
        }


        public void preorden()
        {
        }

        public void inorden(NodoBinario Recor)
        {
            if (Recor != null){
                inorden(Recor.getHijoIzquierdo());
                Console.WriteLine(Recor.getDato() + " ");
                inorden(Recor.getHijoDerecho());
            }
        }
        public void inorden()
        {
            inorden(this.raiz);
            Console.WriteLine();
        }

        public void postorden()
        {
        }


    }
}
