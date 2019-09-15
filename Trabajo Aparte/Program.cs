using System;

namespace Trabajo_Aparte
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
            abo.Insertar(100);
            abo.Insertar(50);
            abo.Insertar(25);
            abo.Insertar(75);
            abo.Insertar(150);
            abo.Insertar(76);
            abo.Insertar(15);
            Console.WriteLine("Impresion preorden: ");
            abo.ImprimirPre();
            Console.WriteLine("Impresion entreorden: ");
            abo.ImprimirEntre();
            Console.WriteLine("Impresion postorden: ");
            abo.ImprimirPost();
            Console.ReadKey();
            Console.WriteLine("Hello World!");
             
        }
    }
}
