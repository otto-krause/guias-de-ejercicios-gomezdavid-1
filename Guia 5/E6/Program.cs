using System.Collections.Generic;
using System.Linq;
using System;

namespace E6
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliteca peliteca = new Peliteca();
            string genero;
            string nombre;
            string director;
            int anio = 0;
            int aux = 0;

            do
            {
                Console.WriteLine("Buscar por GENERO[1]\nBuscar por NOMBRE[2]\nBuscar ANIO[3]\nBuscar por DIRECTOR[4]\nSaber cuantas peliculas hay[5]\nSaber cuantas peliculas de un genero en especifico[6]\nSalir[0]\nIngrese una opcion:");
                aux = Int32.Parse(Console.ReadLine());

                switch (aux)
                {
                    case 1:
                        Console.WriteLine("Ingrese el genero que desea buscar: ");
                        genero = Console.ReadLine();
                        foreach (var i in peliteca.Peliculas.Where(i => i.Genero == genero))Console.WriteLine(i.Nombre+" "+i.Genero+" "+i.Anio+" "+i.Director);
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre que desea buscar: ");
                        nombre = Console.ReadLine();
                        foreach (var i in peliteca.Peliculas.Where(i => i.Nombre == nombre))Console.WriteLine(i.Nombre+" "+i.Genero+" "+i.Anio+" "+i.Director);
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el anio que desea buscar: ");
                        anio = Int32.Parse(Console.ReadLine());
                        foreach (var i in peliteca.Peliculas.Where(x => x.Anio==anio))Console.WriteLine(i.Nombre+" "+i.Genero+" "+i.Anio+" "+i.Director);
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el director que desea buscar: ");
                        director = Console.ReadLine();
                        foreach (var i in peliteca.Peliculas.Where(i => i.Director == director))Console.WriteLine(i.Nombre+" "+i.Genero+" "+i.Anio+" "+i.Director);
                        break;
                    case 5:
                        int cont = peliteca.Peliculas.Count;
                        Console.WriteLine(cont);
                        break;
                    case 6:
                        Console.WriteLine("Ingrese el genero para saber la cantidad de peliculas: ");
                        genero = Console.ReadLine();
                        int cont2 = peliteca.Peliculas.Where(x => x.Genero == genero).Count();
                        Console.WriteLine(cont2);
                        break;

                }

            } while (aux != 0);
        }
    }
}
