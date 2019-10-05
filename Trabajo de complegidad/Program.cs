using System;
using System.Collections.Generic;

namespace Trabajo_de_complegidad
{
    class Program
    {

        public static List<int> copiar(List<int> lista)
        {
            List<int> nueva = new List<int>();
            foreach (int t in lista)
            {
                nueva.Add(t);
            }
            return nueva;
        }
        static void Main(string[] args)
        {
            
            //ArbolGeneral<int> raiz = new ArbolGeneral<int>(14);
            //ArbolGeneral<int> raiz2 = new ArbolGeneral<int>(15);
            //ArbolGeneral<int> raiz3 = new ArbolGeneral<int>(16);
            //ArbolGeneral<int> raiz4 = new ArbolGeneral<int>(17);
            //ArbolGeneral<int> raiz5 = new ArbolGeneral<int>(18);
            //ArbolGeneral<int> raiz6 = new ArbolGeneral<int>(19);
            //ArbolGeneral<int> raiz7 = new ArbolGeneral<int>(20);

            ArbolGeneral<int> Arbol = new ArbolGeneral<int>(0);
            //Arbol.agregarHijo(raiz);
            //Arbol.agregarHijo(raiz2);
            //Arbol.agregarHijo(raiz3);
            //Arbol.agregarHijo(raiz4);
            //Arbol.agregarHijo(raiz5);
            //Arbol.agregarHijo(raiz6);
            //Arbol.agregarHijo(raiz7);
            


            Opciones(Arbol);
           
        }
        static void Opciones(ArbolGeneral<int> abb)
        {
            List<int> listaA = new List<int>();
            listaA.Add(4);
    //        listaA.Add(2);
            listaA.Add(2);
   //         listaA.Add(4);
            //listaA.Add(3);

            List<int> listab = new List<int>();
           
     //       listab.Add(5);
       //     listab.Add(6);
            listab.Add(3);
            listab.Add(1);
            abb.Raiz = abb.CrearConDosListas(abb.Raiz, listaA, listab,abb.getDatoRaiz());


            Console.WriteLine("1. Agregar elemento");
            Console.WriteLine("2. Recorrer todos los hijos");
            Console.WriteLine("3. Recorrido Preorden");
            Console.WriteLine("4. Recorrido Post");
            Console.WriteLine("5. Buscar en arbol");
            Console.WriteLine("6. Crear arbol con dos listas (ya estan creadas)");
            Console.WriteLine("7. Recorrer en profundidad");



            try
            {
                int opcion;
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("ingrese un elemento comparable");
                        int elemento = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("En que nodo padre?");
                        int nodopadre = Convert.ToInt32(Console.ReadLine());
                        try
                        {
                            foreach(ArbolGeneral<int> nodo in abb.getHijos())
                            {
                                if (nodo.getDatoRaiz() == nodopadre)
                                {
                                    ArbolGeneral<int> NuevoNodo = new ArbolGeneral<int>(elemento);
                                    nodo.agregarHijo(NuevoNodo);
                                }
                                else
                                {
                                    Console.WriteLine("No se encontro el elemento padre para poder usarse como raiz");
                                }
                            }
                           
                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        break;
                    case 2:
                        Console.WriteLine("");
                        foreach (ArbolGeneral<int> nodo in abb.getHijos())
                        {
                            Console.Write(nodo.getDatoRaiz()+ " ");
                            
                        }
                         Console.WriteLine("");
                        Console.WriteLine("");
                        break;
                    case 3:
                        
                        break;
                    case 4:
                        
                        break;
                    case 5:
                        
                        break;
                    case 6:
                        
                        abb.Raiz = abb.CrearConDosListas(abb.Raiz, listaA, listab ,abb.getDatoRaiz());
                        Console.ReadKey();

                        break;
                    case 7:
                        abb.RecorrerEnProfundidad2(abb.Raiz);
                        Console.WriteLine(" ");
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
