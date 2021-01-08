using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios
{
    class Silla
    {
        // ATRIBUTOS
        private string etiqueta;
        private Espectador ocupado;

        public string Etiqueta { get => etiqueta; set => etiqueta = value; }
        internal Espectador Ocupado { get => ocupado;}

        // GETTERS Y SETTERS
        public Silla(string etiqueta)
        {
            this.etiqueta = etiqueta;
            this.ocupado = null;
        }

        // CONSTRUCTORES
        public Silla()
        {
            this.ocupado = null;
        }
        
        // METODOS
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
