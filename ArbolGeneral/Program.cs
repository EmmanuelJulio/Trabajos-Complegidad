using System;

namespace ArbolGeneral
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolGeneral<int> arbol = new ArbolGeneral<int>(100);
            ArbolGeneral<int>nuevo= arbol.CrearArbol(100, 4, 4);


        }
    }
}
