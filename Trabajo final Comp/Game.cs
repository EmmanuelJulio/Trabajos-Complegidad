
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Trabajo_final_Comp
{

	public class Game
	{
		public static int WIDTH = 12;
		public static int UPPER = 35;
		public static int LOWER = 25;
		
		private Jugador player1 = new ComputerPlayer();
		private Jugador player2 = new HumanPlayer();
		private List<int> naipesHuman = new List<int>();
        
        private List<int> naipesComputer = new List<int>();
		private int limite;
		private bool juegaHumano = false;

        public int Limite { get => limite; set => limite = value; }

        public Game()
		{
			var rnd = new Random();
			Limite = rnd.Next(LOWER, UPPER);
			
			naipesHuman = Enumerable.Range(1, WIDTH).OrderBy(x => rnd.Next()).Take(WIDTH / 2).ToList();
			
			for (int i = 1; i <= WIDTH; i++) {
				if (!naipesHuman.Contains(i)) {
					naipesComputer.Add(i);
                    

                }
			}
			player1.incializar(naipesComputer, naipesHuman, Limite);
			player2.incializar(naipesHuman, naipesComputer, Limite);
			
		}
		
		
		private void printScreen()
		{
			Console.WriteLine();
			Console.WriteLine("Limite:" + Limite.ToString());
		}
        private void IngresarAopciones(int carta,ArbolGeneral<int> arbolGeneral)
        {
            if (juegaHumano)
            {
                Opciones(carta,arbolGeneral);
            }
        }
		
		private void turn(Jugador jugador, Jugador oponente, List<int> naipes)
		{
            
			int carta = jugador.descartarUnaCarta();
            IngresarAopciones(carta,ComputerPlayer.arbolMinMax);
            naipes.Remove(carta);
			Limite -= carta;
            
			oponente.cartaDelOponente(carta);
			juegaHumano = !juegaHumano;
           
		}
        public static void Opciones(int carta = 0, ArbolGeneral<int> Arbol = null,int limite=1)
        {
            Console.WriteLine();
            Console.WriteLine("******************************Elija una opcion********************************");
            Console.WriteLine("1)----------------------------Comenzar un juego nuevo-------------------------"); 
            Console.WriteLine("2)----------------------------Imprimir posibles resultados--------------------");
            Console.WriteLine("3)----------------------------Imprimir resultados a una profundidad-----------");
            Console.WriteLine("4)----------------------------Continuar juego anterior------------------------");
            Console.WriteLine("******************************************************************************");
            Console.WriteLine();
            int eleccion = Convert.ToInt32(Console.ReadLine());
            switch (eleccion)
            {
                case 1:
                    Game game = new Game();
                    game.play();
                    break;

                case 2:
                    if (Arbol != null)
                    {
                        Console.WriteLine("Posibles resultados: ");
                        VerHojas(Arbol);
                    }
                    else
                    {
                        Console.WriteLine("Debe existir un juego en progreso");
                        Opciones(carta, Arbol);
                    }

                    break;

                case 3:
                    Console.WriteLine("Ingrese un nivel");
                    int Nivel = Convert.ToInt32(Console.ReadLine());
                    RecorrerEnProfundidad(Arbol.Raiz, Nivel);
                    break;
                case 4:

                    break;
            }
        }


        private void printWinner()
		{
			if (!juegaHumano) {
				Console.WriteLine("Gano el Ud");
			} else {
				Console.WriteLine("Gano Computer");
			}
			
		}
		
		private bool fin()
		{
			return Limite < 0;
		}
		
		public void play()
		{
            Console.WriteLine("Se ha comenzado un nuevo juego en cualquier momento puede disponer de uno nuevo asimismo ,podrá ejecutar algunas acciones ");
            Console.WriteLine("Durante el desarrollo del juego");



                while (!this.fin()) {
				this.printScreen();
				this.turn(player2, player1, naipesHuman); // Juega el usuario
				if (!this.fin()) {
					this.printScreen();
					this.turn(player1, player2, naipesComputer); // Juega la IA
				}
              //      Juego.Opciones(carta,);
            }
			this.printWinner();
            Opciones();
        }
        public static void VerHojas(ArbolGeneral<int> a)
        {
            if(a.getHijos().Count == 0)
            {
                Console.Write(a.getDatoRaiz() + " ");
            }
            else
            {
                foreach(ArbolGeneral<int> a2 in a.getHijos())
                {
                    VerHojas(a2);
                }
            }

        }
        public static Cola<NodoGeneral<int>> C = new Cola<NodoGeneral<int>>();
        public static Cola<NodoGeneral<int>> C2 = new Cola<NodoGeneral<int>>();
        public static void RecorrerEnProfundidad(NodoGeneral<int> Raiz, int Nbuscado)
        {
            int nivel =0;
            C.encolar(Raiz);
            while (!C.esVacia())
            {
                    if (nivel == Nbuscado)
                {
                    while (!C.esVacia())
                    {
                        Console.Write(C.desencolar().getDato() + ", ");
                    }
                }
                int logn = C.Datos.Count;
                for (int i =0; i<logn; i++)
                {
                    foreach (NodoGeneral<int> nod in C.desencolar().getHijos())
                    {
                        C.encolar(nod);
                    }
                }
                nivel++;
                
            }

        }
       


    }
    
}
