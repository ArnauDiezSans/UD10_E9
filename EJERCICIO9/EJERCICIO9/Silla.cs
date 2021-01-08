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
        internal Espectador Ocupado { get => ocupado; set => ocupado = value; }

        public Silla(string etiqueta)
        {
            this.etiqueta = etiqueta;
            this.ocupado = null;
        }

        public Silla()
        {
            this.ocupado = null;
        }
    }
}
