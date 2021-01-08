using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Cine
    {
        private Silla[,] sala;
        private Pelicula reproduccion;
        private double precio;

        public double Precio { get => precio; set => precio = value; }
        internal Pelicula Reproduccion { get => reproduccion; set => reproduccion = value; }
        internal Silla[,] Sala { get => sala; set => sala = value; }

        public Cine(int medida1, int medida2)
        {
            int numSilla = 1;
            int letra = Convert.ToInt32("A");
            sala = new Silla[medida1,medida2];
            for (int i = medida1 - 1; i >= 0; i--)
            {
                for (int j = 0; i < medida2; i++)
                {
                    this.sala[i,j] = new Silla();
                }
            }
        }
    }
}
