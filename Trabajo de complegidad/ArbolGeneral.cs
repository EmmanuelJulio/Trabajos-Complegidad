using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_de_complegidad
{
    public class ArbolGeneral<T>
    {

        private NodoGeneral<T> raiz;

        public ArbolGeneral(T dato)
        {
            this.raiz = new NodoGeneral<T>(dato);
        }

        public ArbolGeneral(NodoGeneral<T> nodo)
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
        public void AgregarRecursivo()
        {

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
            int altura = 0;
            if (esHoja())
                return 0;
            foreach(ArbolGeneral<T> hy in this.getHijos())
            {
                altura = Math.Max(altura, hy.altura());
                
            }

            return altura+1;
        }

         static int aux;
        Cola<NodoGeneral<T>> cola;
        //public int nivel(T dato)
        //{
            
        //    if (this.getDatoRaiz().Equals(dato))
        //    {
        //        return 0;
        //    }
            
        //}

         public int ancho()
            {
                int ancho = 0;
                return ancho;
            }

        //public bool include(T dato)
        //{
        //    if (this.getDatoRaiz().Equals(dato))
        //        return true;
        //    else
        //    {
        //        if (this.)
        //         }

        //}
    }
}
//renzo.angeloro@gmail.com