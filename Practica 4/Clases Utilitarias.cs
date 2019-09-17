using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_4
{
    public static class Utilidades
    {
        public static int h (int x)
        {
            return x % 11;
        }
        public static int h2(int x,int y)
        {
            return (x+y) % 11;
        }
        public static int h3(int x, int y)
        {
            return (x + (y*y)) % 11;
        }
    }
}
