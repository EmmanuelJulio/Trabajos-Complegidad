using System;

namespace Trabajo_Aparte
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolBinarioOrdenado abo = new ArbolBinarioOrdenado();
            abo.Insertar(5);
            abo.Insertar(4);
            abo.Insertar(6);
            abo.Insertar(2);
            abo.Insertar(7);
           
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
