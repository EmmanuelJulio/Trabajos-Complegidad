using System;

namespace ABB
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda abb = new ArbolBinarioBusqueda();
            //abb.agregar(58);
            //abb.agregar(59);
            //abb.agregar(60);
            //abb.agregar(61);
            //abb.agregar(62);
            //abb.agregar(63);
            //abb.agregar(64);
            abb.agregar(5);
            abb.agregar(4);
            abb.agregar(6);
            abb.agregar(2);
            abb.agregar(7);
            abb.ImprimirInorden();
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
