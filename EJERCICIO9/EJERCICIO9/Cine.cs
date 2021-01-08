using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Cine
    {
        // ATRIBUTOS
        private Silla[,] sala;
        private Pelicula reproduccion;
        private double precio;

        // GETTERS Y SETTERS
        public double Precio 
        { 
            get { retunr precio; }
            set { precio = value; }
        }
        internal Pelicula Reproduccion 
        { 
            get { return reproduccion; } 
            set { reproduccion = value; }
        }
        internal Silla[,] Sala
        { 
            get { return sala; }
            set { sala = value; }
        }

        // CONSTRUCTOR
        public Cine(int numero, int letra)
        {
            // generamos una sala nueva con sillas. filas y columnas
            int numFila = 0;
            int lletres = "ABCDEFGHIJKLMNOPQRST";
            sala = new Silla[numero,letra]; // creamos la sala
            for (int i = numero - 1; i >= 0; i--) // recorre la fila
            {
                numFila++;
                for (int j = 0; j < letra; j++) // recorre cada columna de la fila
                {
                    this.sala[i,j] = new Silla("" + numFila + lletres[j]);
                }
            }
        }

        // METODES
        private Boolean checkPrecioEdad(Espectador espectador, int precio, Pelicula pelicula) 
        {
            // comprueba que el espectador tenga dinero y edad suficiente para entrar
            int edadEspectador = espectador.Edad;
            double dineroEspectador = espectador.Dinero;
            int edadMinima = pelicula.EdadMinima;

            Boolean permitido = true;

            if (edadEspectador >= edadMinima || dineroEspectador < precio)
            {
                permitido = false;
            }

            // restamos el precio de la entrada al dinero del espectador
            espectador.Dinero = espectador.Dinero - precio

            return permitido;

        }
    }
}