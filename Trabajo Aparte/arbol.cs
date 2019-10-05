using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Aparte
{
    class CArbol
    {
        private Cnodo raiz;
        private Cnodo trabajo;
        private int i = 0;
        public CArbol(int dato)
        {
            Raiz = new Cnodo(dato);
        }

        internal Cnodo Raiz { get => raiz; set => raiz = value; }

        public Cnodo Incertar(int Pdato ,Cnodo Pnodo)
        {
            if (Pnodo == null)
            {
                Raiz = new Cnodo(Pdato);
                Raiz.Hermano = null;
                Raiz.Hijo = null;
                return Raiz;
            }
            else
            {
                if(Pnodo.Hijo ==null)
                {
                    Cnodo temp = new Cnodo(Pdato);
                    Pnodo.Hijo = temp;
                    return temp;
                }
                else
                {
                    trabajo = Pnodo.Hijo;
                    while (trabajo.Hermano != null)
                    {
                        trabajo = trabajo.Hermano;
                    }
                    Cnodo temp = new Cnodo(Pdato);
                    trabajo.Hermano = temp;
                    return temp;
                }
            }
        }
        public void TransversaPreorden(Cnodo Pnodo)
        {
            if (Pnodo == null)
                return;

            for (int n = 0; n < i; n++)
                Console.Write("     ");

            Console.WriteLine(Pnodo.Dato);

            if (Pnodo.Hijo != null)
            {
                i++;
                TransversaPreorden(Pnodo.Hijo);
                i--;
            }
            if (Pnodo.Hermano != null)
                TransversaPreorden(Pnodo.Hermano);
            
        }
        public Cnodo CrearConDosListas(Cnodo Pnodo, List<int> a, List<int> b)
        {
            List<int> AuxA = Utilidades.Copiar(a);
            List<int> Auxb = Utilidades.Copiar(b);
            CArbol ArbolAux = new CArbol();
           
            foreach(int Pdato in AuxA)
            {
                Cnodo nuevo = new Cnodo(Pdato);
                Pnodo.Hijo = nuevo;
                AuxA.Remove(Pdato);
                CrearConDosListas(nuevo, Auxb, AuxA);

            }
            return Nuevo;
        }

    }
     public class Utilidades
    {
        public static List<int> Copiar(List<int> Lista)
        {
            List<int> ListaNUeva = new List<int>();
            for (int i=0; i < Lista.Count; i++)
            {
                ListaNUeva.Add(Lista[i]);
            }
            return ListaNUeva;
        }
    }
}
