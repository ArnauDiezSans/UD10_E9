using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Espectador
    {
        private string nombre;
        private int edad;
        private int dinero;

        public Espectador(string nombre, int edad, int dinero)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dinero = dinero;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public int Dinero { get => dinero; set => dinero = value; }
    }
}
