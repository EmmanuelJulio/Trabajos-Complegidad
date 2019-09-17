using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace Practica_4
{
    class Program
    {
        public List<int> ElementosAdispersarABIERTA = new List<int>();
        public List<int> ElementosAdispersarCERRADA = new List<int>();
        
        public void DispercionAbierta()
        {
            Console.WriteLine(+5 + " " + Utilidades.h(5));
            Console.WriteLine(+20 + " " + Utilidades.h(20));
            Console.WriteLine(+3 + " " + Utilidades.h(3));
            Console.WriteLine(+1000 + " " + Utilidades.h(1000));
            Console.WriteLine(+45 + " " + Utilidades.h(45));
            Console.WriteLine(+27 + " " + Utilidades.h(27));
            Console.WriteLine(+25 + " " + Utilidades.h(25));
            Console.ReadLine();
           
        }
        public static void DispercionCerradaLineal()
        {
            Console.WriteLine(+5 + " " + Utilidades.h2(5,2));
            Console.WriteLine(+20 + " " + Utilidades.h2(20,2));
            Console.WriteLine(+3 + " " + Utilidades.h2(3,2));
            Console.WriteLine(+1000 + " " + Utilidades.h2(1000,2));
            Console.WriteLine(+45 + " " + Utilidades.h2(45,2));
            Console.WriteLine(+27 + " " + Utilidades.h2(27,2));
            Console.WriteLine(+38 + " " + Utilidades.h2(25,2));
            Console.ReadLine();
        }
        public static void DispercionCerradaCuadratica()
        {
            Console.WriteLine(+5 + " " + Utilidades.h3(5, 2));
            Console.WriteLine(+20 + " " + Utilidades.h3(20, 2));
            Console.WriteLine(+3 + " " + Utilidades.h3(3, 2));
            Console.WriteLine(+1000 + " " + Utilidades.h3(1000, 2));
            Console.WriteLine(+45 + " " + Utilidades.h3(45, 2));
            Console.WriteLine(+27 + " " + Utilidades.h3(27, 2));
            Console.WriteLine(+38 + " " + Utilidades.h3(25, 2));
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Program.DispercionCerradaCuadratica();
        }
    }
}
