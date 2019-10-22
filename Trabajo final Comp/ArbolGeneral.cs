﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_final_Comp
{
    public class ArbolGeneral<T>
    {

        private NodoGeneral<T> raiz;

        public NodoGeneral<T> Raiz { get => raiz; set => raiz = value; }
        public void setRaiz(NodoGeneral<T> NuevaRaiz)
        {
            this.raiz = NuevaRaiz;
        }

        public ArbolGeneral(T dato)
        {
            this.Raiz = new NodoGeneral<T>(dato);
        }

        public ArbolGeneral(NodoGeneral<T> nodo)
        {
            this.Raiz = nodo;
        }

        private NodoGeneral<T> getRaiz()
        {
            return Raiz;
        }

        public T getDatoRaiz()
        {
            return this.getRaiz().getDato();
        }

        public List<ArbolGeneral<T>> getHijos()
        {
            List<ArbolGeneral<T>> temp = new List<ArbolGeneral<T>>();
            foreach (var element in this.Raiz.getHijos())
            {
                temp.Add(new ArbolGeneral<T>(element));
            }
            return temp;

        }


        public void agregarHijo(ArbolGeneral<T> hijo)
        {
            this.Raiz.getHijos().Add(hijo.getRaiz());
        }

        public void eliminarHijo(ArbolGeneral<T> hijo)
        {
            this.Raiz.getHijos().Remove(hijo.getRaiz());
        }

        public bool esVacio()
        {
            return this.Raiz == null;
        }

        public bool esHoja()
        {
            return this.Raiz != null && this.getHijos().Count == 0;
        }

        public int altura()
        {
            int altura = 0;
            if (esHoja())
                return 0;
            foreach (ArbolGeneral<T> hy in this.getHijos())
            {
                altura = Math.Max(altura, hy.altura());

            }

            return altura + 1;
        }


        public int nivel(T dato)
        {

            if (this.getDatoRaiz().Equals(dato))
            {
                return 0;
            }
            else
            {
                foreach (ArbolGeneral<T> h in getHijos())

                {

                }
            }
            return 0;
        }

        public int ancho()
        {
            int ancho = 0;
            return ancho;
        }
        Cola<ArbolGeneral<int>> ColaAux = new Cola<ArbolGeneral<int>>();
        public void VerBeta(ArbolGeneral<int> Arbol)
        {
            ColaAux.encolar(Arbol);
            while (!ColaAux.esVacia())
            {
                ArbolGeneral<int> aux = ColaAux.desencolar();
                foreach (ArbolGeneral<int> nodo in aux.getHijos())
                {
                    VerBeta(nodo);
                    ColaAux.encolar(nodo);
                    Console.WriteLine(nodo.getDatoRaiz() + " " + nodo.raiz.Beta);
                }
            }



        }
        public void RecorrerEnProfundidad(NodoGeneral<int> Raiz, int Nbuscado)
        {
            int nivel = 0;
            Cola<NodoGeneral<int>> C = new Cola<NodoGeneral<int>>();
            C.encolar(Raiz);
            while (C.desencolar() != null)
            {
                nivel++;
                foreach (NodoGeneral<int> arb in Raiz.getHijos())
                {
                    C.encolar(arb);
                }
                C.encolar(null);

            }


        }

    }
}
//renzo.angeloro@gmail.com