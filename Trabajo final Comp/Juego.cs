﻿
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
				Game game = new Game();
				game.play();
			    Console.ReadKey();
		}
	}
}