using System;
using System.Collections.Generic;

namespace ArbolGeneral
{
	public class ArbolGeneral<T>
	{
		
		private NodoGeneral<T> raiz;

        public NodoGeneral<T> Raiz { get => raiz; set => raiz = value; }

        public ArbolGeneral(T dato) {
			this.Raiz = new NodoGeneral<T>(dato);
		}
	
		private ArbolGeneral(NodoGeneral<T> nodo) {
			this.Raiz = nodo;
		}
	
		private NodoGeneral<T> getRaiz() {
			return Raiz;
		}
	
		public T getDatoRaiz() {
			return this.getRaiz().getDato();
		}
	
		public List<ArbolGeneral<T>> getHijos() {
			List<ArbolGeneral<T>> temp= new List<ArbolGeneral<T>>();
			foreach (var element in this.Raiz.getHijos()) {
				temp.Add(new ArbolGeneral<T>(element));
			}
			return temp;
		}
        public ArbolGeneral<int> CrearArbol(ArbolGeneral<int> nodo, int litros,int cantHijos, int altura)
        {
            int Altura=0;
            int Litros = litros;
            int litrosActuales = Litros /cantHijos;
            ArbolGeneral<int> NuevaRaiz = new ArbolGeneral<int>(litros);
            NuevaRaiz = nodo;
            while (Altura <= altura) 
            {
                for (int i = 0; i <= cantHijos; i++)
                {
                    ArbolGeneral<int> nuevohijo = new ArbolGeneral<int>(litrosActuales);
                    nodo.agregarHijo(nuevohijo);
                    altura++;
                    CrearArbol(nuevohijo,litrosActuales,cantHijos,Altura);
                } 
            }
            return NuevaRaiz;
            
        }
        public ArbolGeneral<int> CrearArbol(int litros, int cantHijos, int altura)
        {
            int Altura = 0;
            int Litros = litros;
            int litrosActuales = Litros / cantHijos;
            ArbolGeneral<int> NuevaRaiz = new ArbolGeneral<int>(litros);
            
            while (Altura <= altura)
            {
                for (int i = 0; i <= cantHijos; i++)
                {
                    ArbolGeneral<int> nuevohijo = new ArbolGeneral<int>(litrosActuales);
                    NuevaRaiz.agregarHijo(nuevohijo);
                    altura++;
                    CrearArbol(nuevohijo, litrosActuales, cantHijos, Altura);
                }
            }
            return NuevaRaiz;

        }

        public void agregarHijo(ArbolGeneral<T> hijo) {
			this.Raiz.getHijos().Add(hijo.getRaiz());
		}

	
		public void eliminarHijo(ArbolGeneral<T> hijo) {
			this.Raiz.getHijos().Remove(hijo.getRaiz());
		}
	
		public bool esVacio() {
			return this.Raiz == null;
		}
	
		public bool esHoja() {
			return this.Raiz != null && this.getHijos().Count == 0;
		}
	
		public int altura() {
			return 0;
		}
	
		
		public int nivel(T dato) {
			return 0;
		}
	
	}
}
