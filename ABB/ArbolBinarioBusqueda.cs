using System;
using System.Collections.Generic;
using System.Text;

namespace ABB
{
    public class ArbolBinarioBusqueda
    {
        public NodoBinario raiz;
        public static int cant, nivel;
        List<NodoBinario> Encolados = new List<NodoBinario>();

        public ArbolBinarioBusqueda()        {
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
                if (elem.CompareTo(anterior.getDato()) < 0)
                    anterior.setHijoIzquierdo(Nuevo);
                else
                    anterior.setHijoDerecho(Nuevo);

            }
        }


        public bool incuye (IComparable dato)
        {
            NodoBinario reco = this.raiz;
            while (reco != null)
            {
                if (dato.CompareTo(reco.getDato()) == 0)
                    return true;
                else
                {
                    if (dato.CompareTo(reco.getDato()) < 0)
                        reco = reco.getHijoIzquierdo();
                    else
                        reco = reco.getHijoDerecho();
                }
               
            }
            return false;
        }
       
        public void ContarHojas(NodoBinario arbol)
        {
          if(arbol != null)
            {

                if (arbol.getHijoIzquierdo() == null && arbol.getHijoDerecho() == null)
                    cant++;

                    ContarHojas(arbol.getHijoIzquierdo());
                    ContarHojas(arbol.getHijoDerecho());
                
            }
           
        } 
        public int ContarHojas()
        {
            
            ContarHojas(this.raiz);
            return cant;
            
        }

        public void preorden()
        {
        }

        public void ImprimirInorden(NodoBinario Recor)
        {
           if (Recor != null)
            {
                ImprimirInorden(Recor.getHijoIzquierdo());
               
                Console.Write(Recor.getDato()+ " " );
               
                ImprimirInorden(Recor.getHijoDerecho());
            }
            


        }
        public void ImprimirInorden()
        {
            ImprimirInorden(this.raiz);
        }
        
        public void ImprimirPreorden()
        {
            ImprimirPreorden(this.raiz);
        }
        public void ImprimirPreorden(NodoBinario recor)
        {
            if (recor != null)
            {
                Console.Write(recor.getDato()+ " ");
                ImprimirPreorden(recor.getHijoIzquierdo());
                ImprimirPreorden(recor.getHijoDerecho());
            }
            
        }
        public void ImprimirPostOrden(NodoBinario recor)
        {
           if(recor != null)
            {
                ImprimirPostOrden(recor.getHijoIzquierdo());
                ImprimirPostOrden(recor.getHijoDerecho());
                Console.Write(recor.getDato()+ " ");
            }
        }
        public void ImprimirPostOrden()
        {
            ImprimirPostOrden(this.raiz);
        }
        public void RecorrerPorNiveles(NodoBinario reco)
        {
            int nivel=0;
            if (reco != null)
            {
                Encolados.Add(reco);
            }
                


            foreach (NodoBinario nod in Encolados)
            {
                Console.Write(nod.getDato() + " ");
            }
        }
        public void RecorrerPorNiveles()
        {
            this.RecorrerPorNiveles(this.raiz);
        }
    }
}
