
using System;
using System.Collections.Generic;

namespace Trabajo_final_Comp
{
	class Juego

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
        public static void Main(string[] args)
		{
                Juego.Opciones();
			    Console.ReadKey();
		}
        public static void Opciones(int carta=0,ArbolGeneral<int> Arbol = null)
        {
            Console.WriteLine();
            Console.WriteLine("******************************Elija una opcion********************************");
            Console.WriteLine("1)----------------------------Comenzar un juego-------------------------------");
            Console.WriteLine("2)----------------------------Imprimir posibles resultados--------------------");
            Console.WriteLine("3)----------------------------Imprimir resultados a una profundidad-----------");
            Console.WriteLine("3)----------------------------Continuar juego anterior------------------------");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine();
            int eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    Game game = new Game();
                    game.play();
                    break;

                case 2:
                    if (Arbol!=null)
                    {
                        Console.WriteLine("La maquina podria juegar ");
                        foreach (ArbolGeneral<int> posible in Arbol.getHijos())
                        {
                            Console.Write(posible.getDatoRaiz() + " ");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Debe existir un juego en progreso");
                        Opciones(carta,Arbol);
                    }

                    break;
                    
                case 3:
                    Arbol.VerBeta(Arbol);
                    break;
                case 4:

                    break;
            }
        }

	}
}