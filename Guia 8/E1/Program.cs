using System;
using System.IO;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            string pelicula;
            
            Console.WriteLine("Escribir una pelicula");
            pelicula = Console.ReadLine();

            ComandosPeliculas.ingresarPeliculas(pelicula);
            ComandosPeliculas.verTodasLasPeliculasSinRepetidos();

        }
    }
}
