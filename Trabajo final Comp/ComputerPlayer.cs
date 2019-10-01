
using System;
using System.Collections.Generic;
using System.Linq;

namespace Trabajo_final_Comp
{
	public class ComputerPlayer: Jugador
	{
        private List<int> naipes = new List<int>();
        private List<int> naipesHumano = new List<int>();
        private int limite;
        private bool random_card = false;
       public static ArbolGeneral<int> arbolMinMax = new ArbolGeneral<int>(0);

        public ArbolGeneral<int> ArbolMinMax { get => arbolMinMax; set => arbolMinMax = value; }

        public ComputerPlayer()
		{
		}
		
		public override void  incializar(List<int> cartasPropias, List<int> cartasOponente, int limite)
		{
            this.naipes = cartasPropias;
            this.naipesHumano = cartasOponente;
            this.limite = limite;
            ArbolMinMax.CrearConDosListas(ArbolMinMax.Raiz, cartasOponente, cartasPropias);
            //Implementar
        }
		
		
		public override int descartarUnaCarta()
		{
			//Implementar
			return 0;
		}
		
		public override void cartaDelOponente(int carta)
		{
            int mejoropcion;
			//implementar esto es lo que se va a correr cuando juegue la maquina
            foreach(ArbolGeneral<int> NuevaRaiz in arbolMinMax.getHijos())
            {
                if (NuevaRaiz.getDatoRaiz() == carta)
                    arbolMinMax.setRaiz(NuevaRaiz.Raiz);
            }
            foreach (ArbolGeneral<int> opciones in arbolMinMax.getHijos())
            {

            }


        }
        public int SeleccionarMejorValor()
        {
            int BestValue;
            
            foreach(ArbolGeneral<int> opciones in arbolMinMax.getHijos())
            {
                if (opciones.getDatoRaiz() + limite > limite)
                {

                }
            }
        }
		
	}
}
