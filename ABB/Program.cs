using System;

namespace ABB
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioBusqueda abb = new ArbolBinarioBusqueda();
            abb.agregar(58);
            abb.agregar(59);
            abb.agregar(60);
            abb.agregar(70);
            abb.agregar(71);
            abb.agregar(72);
            abb.agregar(73);
            abb.agregar(74);
            abb.agregar(75);
            abb.inorden();
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}
