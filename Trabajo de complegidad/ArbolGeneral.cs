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
        public void AgregarRecursivo()
        {

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
            foreach(ArbolGeneral<T> hy in this.getHijos())
            {
                altura = Math.Max(altura, hy.altura());
                
            }

            return altura+1;
        }

         static int aux;
        Cola<NodoGeneral<T>> cola = new Cola<NodoGeneral<T>>();

        public NodoGeneral<T> Raiz { get => raiz; set => raiz = value; }

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
        public NodoGeneral<int> CrearConDosListas(NodoGeneral<int> nodopadre, List<int> a, List<int> b)
        {

            NodoGeneral<int> Nuevo = nodopadre;
            List<int> AuxA = Program.copiar(a);
            List<int> AuxB = Program.copiar(b);

            for (int i = 0; AuxA.Count!=0; i++)
            {
                    NodoGeneral<int> NuevoHijo = new NodoGeneral<int>(AuxA[0]);
                    Nuevo.setHijos(NuevoHijo);
                    AuxA.Remove(AuxA[0]);
                    CrearConDosListas(NuevoHijo, AuxB, AuxA);
            }
            return Nuevo;
        }
        public void RecorrerEnProfundidad(NodoGeneral<T> Raiz)
        {
            NodoGeneral<T> Aux = Raiz;
            NodoGeneral<T> Anterior = Raiz;
            if (Raiz.getHijos().Count == 0)
                Console.Write(Raiz.getDato());
            while (Aux.getHijos().Count != 0)
            {
                foreach(NodoGeneral<T> NodoRecorrido in Aux.getHijos())
                {
                    Aux = NodoRecorrido;
                }
            }
            foreach (NodoGeneral<T> Ante in Anterior.getHijos())
            {
                Console.Write(Ante.getDato());
                RecorrerEnProfundidad(Aux);
            }
        }
        public void RecorrerEnProfundidad2(NodoGeneral<T> Raiz)
        {
            NodoGeneral<T> anterior = Raiz;
            NodoGeneral<T> Aux = Raiz;
            if (Raiz.getHijos() != null)
            {
                foreach(NodoGeneral<T> nodo in anterior.getHijos())
                {
                    cola.encolar(nodo);
                    Aux = nodo;
                    RecorrerEnProfundidad2(Aux);
                }
            }

        }
    }
}
//renzo.angeloro@gmail.com