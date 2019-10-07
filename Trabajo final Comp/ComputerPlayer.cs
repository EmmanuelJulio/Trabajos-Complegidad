
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
            NodoGeneral<int> root = new NodoGeneral<int>(-1);
            this.naipes = cartasPropias;
            this.naipesHumano = cartasOponente;

            this.limite = limite;
            CrearConDosListas(root, cartasOponente, cartasPropias, false, limite);
            //root.print();
            this.ArbolMinMax.setRaiz(root);

            Console.WriteLine();
        }
        public void CrearConDosListas(NodoGeneral<int> nodopadre, List<int> a, List<int> b, bool miTurno, int tope)
        {
            for (int i = 0; i < a.Count; i++)
            {

                List<int> AuxA = Juego.copiar(a);
                int cartaAJugar = a[i];
                AuxA.Remove(cartaAJugar);
                NodoGeneral<int> Nuevohijo = new NodoGeneral<int>(cartaAJugar);
                nodopadre.setHijos(Nuevohijo);

                if (!miTurno && ((tope - cartaAJugar) < 0))
                {
                    Nuevohijo.Beta = 1;
                }
                else
                {
                    if ((tope - cartaAJugar) == 0)
                    {
                        Nuevohijo.Beta = 1;
                    }
                    else if ((tope - cartaAJugar) > 0)
                    {
                        CrearConDosListas(Nuevohijo, b, AuxA, !miTurno, (tope - cartaAJugar));
                    }
                }
            }

        }


        public override int descartarUnaCarta()
		{
             int mejoropcion = -1;
            ArbolGeneral<int> nueopcion=null;
            foreach (ArbolGeneral<int> opciones in arbolMinMax.getHijos())
            {
                if (opciones.Raiz.Beta > mejoropcion)
                {
                    nueopcion = opciones;
                    mejoropcion = opciones.Raiz.Beta;

                }
            }
            arbolMinMax.setRaiz(nueopcion.Raiz);
            Console.WriteLine("La maquina escogio la carta " + nueopcion.getDatoRaiz());
            return nueopcion.getDatoRaiz();
		}
		
		public override void cartaDelOponente(int carta)
		{
            //int mejoropcion=0;
            ArbolGeneral<int> mejor = new ArbolGeneral<int>(0);
            
			//implementar esto es lo que se va a correr cuando juegue la maquina
            foreach(ArbolGeneral<int> NuevaRaiz in arbolMinMax.getHijos())
            {
                if (NuevaRaiz.getDatoRaiz() == carta)
                    arbolMinMax.setRaiz(NuevaRaiz.Raiz);
            }/*
            foreach (ArbolGeneral<int> opciones in arbolMinMax.getHijos())
            {
                if (opciones.Raiz.Alpha > mejoropcion)
                {
                    mejor = opciones;
                    mejoropcion = opciones.Raiz.Alpha;

                }
            }
            ArbolMinMax.Raiz = mejor.Raiz;*/
            
            limite = limite -carta;
        }
        //public int SeleccionarMejorValor()
        //{
        //    int BestValue;
            
        //    foreach(ArbolGeneral<int> opciones in arbolMinMax.getHijos())
        //    {
        //        if (opciones.getDatoRaiz() + limite > limite)
        //        {

        //        }
        //    }
        //}
		
	}
}
