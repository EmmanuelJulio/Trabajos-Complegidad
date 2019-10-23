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
        public NodoGeneral<int> CrearConDosListas(NodoGeneral<int> nodopadre, List<int> a, List<int> b,int DatoPadre,int Aacomulado=0)
        {
            int Acomulado = Aacomulado;
            NodoGeneral<int> Nuevo = nodopadre;
            List<int> AuxA = Program.copiar(a);
            List<int> AuxB = Program.copiar(b);

            for (int i = 0; AuxA.Count!=0; i++)
            {
                   
                    int Gane=0;
                    NodoGeneral<int> NuevoHijo = new NodoGeneral<int>(AuxA[0]);
                    Nuevo.setHijos(NuevoHijo);
                    
                    AuxA.Remove(AuxA[0]);
                if (Acomulado + NuevoHijo.getDato() >= 5)
                    Gane++;

                Acomulado = DatoPadre + NuevoHijo.getDato();

                NuevoHijo.Beta1 =  Gane;
                nodopadre.Beta1= nodopadre.Beta1 + NuevoHijo.Beta1;
                    CrearConDosListas(NuevoHijo, AuxB, AuxA,NuevoHijo.getDato(),Acomulado);
            }
            return Nuevo;
        }
      
        public  void RecorrerEnProfundidad(NodoGeneral<int> Raiz, int Nbuscado)
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

        internal void recorridoPreorden(ArbolGeneral<int> abb)
        {
            Console.WriteLine(abb.getDatoRaiz());
            foreach(ArbolGeneral<int> Nd in abb.getHijos())
            {
                while (abb.getHijos() != null)
                {
                    Nd.recorridoPreorden(Nd);
                }
            }
        }
    }
}
//renzo.angeloro@gmail.com