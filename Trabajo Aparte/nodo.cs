using System;
using System.Collections.Generic;
using System.Text;

namespace Trabajo_Aparte
{
    class Cnodo
    {
        Cnodo hermano;
        Cnodo hijo;
        int dato;
        public Cnodo (int dato)
        {
            this.Dato = dato;
            hijo = null;
            hermano = null;
        }

        public int Dato { get => dato; set => dato = value; }
        public Cnodo Hermano { get => hermano; set => hermano = value; }
        public Cnodo Hijo { get => hijo; set => hijo = value; }


    }
}
