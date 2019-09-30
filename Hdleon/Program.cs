using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace Hdleon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arregloDeEnteros = new int[] { 1, 29};

            //Recorrer(arregloDeEnteros);
            ///Ejemplo 2
            //Console.WriteLine(sumar(arregloDeEnteros));
            //ejemplo 3 pintar un arbolito
            Bitmap bmp = new Bitmap(100, 100);
            Arbolito(bmp, bmp.Width / 2, 50);
            string path = @"C:\Users\Emanuel Julio\Desktop\Nueva carpeta (2)\arbolito.jpg";
            bmp.Save(path,ImageFormat.Bmp);
            Console.ReadKey();
        }
        static void Arbolito(Bitmap bmp,int x,int n,int y = 0)
        {
            if (y < n & x < 100)
            {
                bmp.SetPixel(x, y, Color.Red);
               Arbolito(bmp, x + 1,n,y++);
                Arbolito(bmp, x - 1,n,y++);
            }
        }
       
        static int sumar(int[] arreglo,int posicion= 0)
        {
            if (posicion == arreglo.Length)
                return 0;

            int valor = arreglo[posicion] + sumar(arreglo, posicion + 1);
            return valor;
        }
        static void Recorrer(int [] arrego,int posicion=0)
        {
            if (posicion == arrego.Length)
                return;


            Console.Write(arrego[posicion] + " ");
            Recorrer(arrego, posicion + 1);
            

        }
    }
}
