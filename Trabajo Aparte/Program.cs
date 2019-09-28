using System;

namespace Trabajo_Aparte
{
    class Program
    {
        static void Main(string[] args)
        {

            nodo primero = new nodo(0);
            primero.incertaralfinal(primero,2);
            
            primero.incertaralfinal(primero, 3);
            primero.incertaralfinal(primero, 4);
            primero.incertaralfinal(primero, 5);
            
            primero.imprimirTodos(primero);
            Console.ReadKey();
        }
    }
    public class nodo
    {
        int info;
        public nodo siguiente;
        public nodo (int dato)
        {
            info = dato;
        }
        public void verNodo()
        {
            Console.WriteLine(info);
        }
        
        public void IncertarEnPrimero(nodo siguiente,int dato)
        {
            
            nodo temporal = new nodo(dato);
            temporal.siguiente = siguiente;
            siguiente = temporal;

        }
        public void imprimirTodos(nodo primero)
        {
            primero.verNodo();
            while (primero.siguiente != null)
            {
                primero = primero.siguiente;
                Console.Write(primero);
            }
        }
        public void incertaralfinal(nodo primero,int dato)
        {
            nodo nuevo = new nodo(dato);
            nodo anterior = primero;
            nodo actual = primero;
            if
            while (actual.siguiente != null)
            {
                anterior = actual;
                actual = actual.siguiente;
            }
            actual.siguiente = nuevo;
        }
    }

        

}
