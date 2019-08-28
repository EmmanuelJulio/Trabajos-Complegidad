using System;
using System.Collections.Generic;

namespace Trabajo_de_complegidad
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    public class NodoGeneral<T>
    {
        private T dato;
        private List<NodoGeneral<T>> hijos;

        public NodoGeneral(T dato)
        {
            this.dato = dato;
            this.hijos = new List<NodoGeneral<T>>();
        }

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

        public void setHijos(List<NodoGeneral<T>> hijos)
        {
            this.hijos = hijos;
        }

    }
    public class Cola<T>
    {


        private List<T> datos = new List<T>();

        public void encolar(T elem)
        {
            this.datos.Add(elem);
        }

        public T desencolar()
        {
            T temp = this.datos[0];
            this.datos.RemoveAt(0);
            return temp;
        }

        public T tope()
        {
            return this.datos[0];
        }

        public bool esVacia()
        {
            return this.datos.Count == 0;
        }
    }
    public class ArbolGeneral<T>
    {

        private NodoGeneral<T> raiz;

        public ArbolGeneral(T dato)
        {
            this.raiz = new NodoGeneral<T>(dato);
        }

        private ArbolGeneral(NodoGeneral<T> nodo)
        {
            this.raiz = nodo;
        }

        private NodoGeneral<T> getRaiz()
        {
            return raiz;
        }

        public T getDatoRaiz()
        {
            return this.getRaiz().getDato();
        }

        public List<ArbolGeneral<T>> getHijos()
        {
            List<ArbolGeneral<T>> temp = new List<ArbolGeneral<T>>();
            foreach (var element in this.raiz.getHijos())
            {
                temp.Add(new ArbolGeneral<T>(element));
            }
            return temp;
        }

        public void agregarHijo(ArbolGeneral<T> hijo)
        {
            this.raiz.getHijos().Add(hijo.getRaiz());
        }

        public void eliminarHijo(ArbolGeneral<T> hijo)
        {
            this.raiz.getHijos().Remove(hijo.getRaiz());
        }

        public bool esVacio()
        {
            return this.raiz == null;
        }

        public bool esHoja()
        {
            return this.raiz != null && this.getHijos().Count == 0;
        }

        public int altura()
        {
            return 0;
        }


        public int nivel(T dato)
        {
            return 0;
        }

    }
    public class OperacionesArbol
    {
        public int altura(ArbolGeneral<T> arbol)
        {
            return 1;
        }
    }

}
