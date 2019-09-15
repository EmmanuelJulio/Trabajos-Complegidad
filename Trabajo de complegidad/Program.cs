using System;
using System.Collections.Generic;

namespace Trabajo_de_complegidad
{
    class Program
    {
        static void Main(string[] args)
        {

            NodoGeneral<int> raiz = new NodoGeneral<int>(14);
            ArbolGeneral<NodoGeneral<int>> Arbol = new ArbolGeneral<NodoGeneral<int>>(raiz);
            
           
            Console.WriteLine(Arbol.getDatoRaiz());
            Console.WriteLine("Hello World!");
            Console.ReadKey();
        }
    }
    
}
