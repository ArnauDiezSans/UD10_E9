using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Silla
    {
        private string etiqueta;
        private Espectador ocupado;

        public string Etiqueta { get => etiqueta; set => etiqueta = value; }
        internal Espectador Ocupado { get => ocupado;}

        public Silla(string etiqueta)
        {
            this.etiqueta = etiqueta;
            this.ocupado = null;
        }

        public Silla()
        {
            this.ocupado = null;
        }

        public void Asentar(Espectador espectador)
        {
            this.ocupado = espectador;
        }
        public void Aixecar () 
        {
            this.ocupado = null;
        }
    }
}
