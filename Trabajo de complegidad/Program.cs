using System;
using System.Collections.Generic;

namespace Trabajo_de_complegidad
{
    class Program
    {
        static void Main(string[] args)
        {

            NodoGeneral<int> raiz = new NodoGeneral<int>(14);
            NodoGeneral<int> raiz2 = new NodoGeneral<int>(15);
            NodoGeneral<int> raiz3 = new NodoGeneral<int>(16);
            NodoGeneral<int> raiz4 = new NodoGeneral<int>(17);
            NodoGeneral<int> raiz5 = new NodoGeneral<int>(18);
            NodoGeneral<int> raiz6 = new NodoGeneral<int>(19);
            NodoGeneral<int> raiz7 = new NodoGeneral<int>(20);
            raiz.setHijos(raiz2);
            raiz.setHijos(raiz3);
            raiz.setHijos(raiz4);
            raiz.setHijos(raiz5);
            raiz.setHijos(raiz6);
            raiz.setHijos(raiz7);
            ArbolGeneral<NodoGeneral<int>> Arbol = new ArbolGeneral<NodoGeneral<int>>(raiz);
            

            Console.WriteLine(Arbol.getDatoRaiz().getDato());
            Opciones(Arbol);
            Console.ReadKey();
        }
        static void Opciones(ArbolGeneral<NodoGeneral<int>> abb)
        {
            Console.WriteLine("");

            Console.WriteLine("1. Agregar elemento");
            Console.WriteLine("2. Recorrer todos los hijos");
            Console.WriteLine("3. Recorrido Preorden");
            Console.WriteLine("4. Recorrido Post");
            Console.WriteLine("5. Buscar en arbol");
            Console.WriteLine("6. Contar Hojas");
            Console.WriteLine("7. Contar entre niveles");



            try
            {
                int opcion;
               opcion = Convert.ToInt32(Console.ReadLine());

                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese un elemento comparable");
                        int elemento = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                           
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        break;
                    case 2:
                       foreach(ArbolGeneral<int> nodo in abb.getHijos())
                        {
                            nodo.getHijos();
                        }

                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        
                        break;
                    case 6:
                       
                       
                        break;
                    case 7:
                       
                        break;
                }
            }
            catch (Exception err)
            {

                Console.WriteLine("seleccione una opcion correcta " + err.Message);
            }
            Program.Opciones(abb);
        }
    }
    
}
