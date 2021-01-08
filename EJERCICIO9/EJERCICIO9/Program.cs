using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            // Generem el cinema amb el seu revisor
            Cine palaas = new Cine(8, 8);

            Espectador revisor = new Espectador("Revisor",40,0);

            // Generem un array de Espectadors
            Espectador[] publico = new Espectador[20];

            // Omplim el array de espectadors amb el mètode
            publico = revisor.GenerarPublic(publico);

            // Els mostrem
            revisor.MostrarEspectadores(publico);

            // Generem la pelicula i mostrem la seva informació
            Pelicula film1 = new Pelicula("Peli1", 5, 18, "Spilberg");
            Console.WriteLine();

            Console.WriteLine("Se está proyectando {0} con precio de entrada {1} para mayores de {2} años de edad", film1.Titulo, palaas.Precio, film1.EdadMinima);

            Random r = new Random();
            Console.WriteLine();
            // Recorrem cada Espectador i comprobem que pot entrar.
            for (int i = 0; i < publico.Length; i++)
            {
                if (palaas.CheckPrecioEdad(publico[i], palaas.Precio, film1))
                {
                    bool sentado = false;
                    // Si pot entrar, busquem un lloc per asseure'l.
                    while (!sentado)
                    {
                        int pos1 = r.Next(0, 8);
                        int pos2 = r.Next(0, 8);
                        // Si la cadira està ocupada, li busquem un altre. En cas contrari l'assentem.
                        if (palaas.Sala[pos1, pos2].Ocupado == null)
                        {
                            palaas.Sala[pos1, pos2].Asentar(publico[i]);
                            sentado = true;
                            Console.WriteLine("{1} se sentado en {0}", palaas.Sala[pos1, pos2].Etiqueta, publico[i].Nombre);
                        }
                    }
                }
                else
                {
                    // Si no es pot sentar, informem d'aquest fet.
                    Console.WriteLine("{0} no ha pogut entrar a la pelicula", publico[i].Nombre);
                }
            }


        }
    }
}
