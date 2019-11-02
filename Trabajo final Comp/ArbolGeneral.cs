using System;
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


        

        public int ancho()
        {
            int ancho = 0;
            return ancho;
        }

       

    }
}
//renzo.angeloro@gmail.com