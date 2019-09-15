using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Aparte
{
    //este es un arbol binario ordenado
     public class ArbolBinarioOrdenado
    {
        class Nodo
        {
            public int info;
            public Nodo izq, der;
        }
        Nodo raiz;

        public ArbolBinarioOrdenado()
        {
            raiz = null;
        }

        public void Insertar(int info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.izq = null;
            nuevo.der = null;
            if (raiz == null)
                raiz = nuevo;
            else
            {
                Nodo anterior = null, reco;
                reco = raiz;
                while (reco != null)
                {
                    anterior = reco;
                    if (info < reco.info)
                        reco = reco.izq;
                    else
                        reco = reco.der;
                }
                if (info < anterior.info)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }


        private void ImprimirPre(Nodo reco)
        {
            if (reco != null)
            {
                Console.Write(reco.info + " ");
                ImprimirPre(reco.izq);
                ImprimirPre(reco.der);
            }
        }

        public void ImprimirPre()
        {
            ImprimirPre(raiz);
            Console.WriteLine();
        }

        private void ImprimirEntre(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirEntre(reco.izq);
                Console.Write(reco.info + " ");
                ImprimirEntre(reco.der);
            }
        }

        public void ImprimirEntre()
        {
            ImprimirEntre(raiz);
            Console.WriteLine();
        }


        private void ImprimirPost(Nodo reco)
        {
            if (reco != null)
            {
                ImprimirPost(reco.izq);
                ImprimirPost(reco.der);
                Console.Write(reco.info + " ");
            }
        }


        public void ImprimirPost()
        {
            ImprimirPost(raiz);
            Console.WriteLine();
        }
        private void ImprimirEntreConNivel(Nodo reco, int nivel)
        {
            if (reco != null)
            {
                ImprimirEntreConNivel(reco.izq, nivel + 1);
                Console.Write(reco.info + " (" + nivel + ") - ");
                ImprimirEntreConNivel(reco.der, nivel + 1);
            }
        }

        public void ImprimirEntreConNivel()
        {
            ImprimirEntreConNivel(raiz, 1);
            Console.WriteLine();
        }

    }
}
