using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_final_Comp
{
    public class Cola<T>
    {


        private List<T> datos = new List<T>();

        public List<T> Datos { get => datos; set => datos = value; }

        public void encolar(T elem)
        {
            this.Datos.Add(elem);
        }

        public T desencolar()
        {
            T temp = this.Datos[0];
            this.Datos.RemoveAt(0);
            return temp;
        }

        public T tope()
        {
            if (this.Datos[0].Equals(null))
            {
                return default(T);
            }
            else
            {
                T temp = this.Datos[0];
                return temp;
            }
           
        }

        public bool esVacia()
        {
            return this.Datos.Count == 0;
        }
    }
}
