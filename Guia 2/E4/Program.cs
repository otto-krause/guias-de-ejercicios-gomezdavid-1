using System;

/*4) Los libros nos aburren, así que en lugar de una biblioteca, vamos a poner una Peliteca,
la cual es una clase que tiene una lista de películas (de cada película sabemos nombre, género, año, director).
Permitirle al usuario consultar la Peliteca de la siguiente manera:
Buscar por género.
Buscar por nombre.
Buscar por año.
Buscar por director.
Saber cuantas peliculas hay en total.
Saber cuántas películas de un género en específico hay.

Nota: Investigar sobre métodos de cadenas (strings). No imprimir mensajes de consola desde una clase que no sea la Program.
*/
namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Peliteca peliteca = new Peliteca();
            int aux=0;
            string genero,nombre,director;
            int anio=0;

            do
            {
                Console.WriteLine("Buscar por GENERO[1]\nBuscar por NOMBRE[2]\nBuscar ANIO[3]\nBuscar por DIRECTOR[4]\nSaber cuantas peliculas hay[5]\nSaber cuantas peliculas de un genero en especifico[6]\nSalir[0]\nIngrese una opcion:");
                aux=Int32.Parse(Console.ReadLine());
                
                switch(aux)
                {
                    case 1:
                        Console.WriteLine("Ingrese el genero que desea buscar: ");
                        genero=Console.ReadLine();
                        Console.WriteLine(" " + peliteca.BuscarPorGenero(genero));
                        break;
                    case 2: 
                        Console.WriteLine("Ingrese el nombre que desea buscar: ");
                        nombre=Console.ReadLine();
                        Console.WriteLine(" " + peliteca.BuscarPorNombre(nombre));
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el anio que desea buscar: ");
                        anio=Int32.Parse(Console.ReadLine());
                        Console.WriteLine(" " + peliteca.BuscarPorAnio(anio));
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el director que desea buscar: ");
                        director=Console.ReadLine();
                        Console.WriteLine(" " + peliteca.BuscarPorDirector(director));
                        break;
                    case 5:
                        Console.WriteLine(" " + peliteca.CuantasPeliculasHay());
                        break;
                    case 6:
                        Console.WriteLine("Ingrese el genero para saber la cantidad de peliculas: ");
                        genero=Console.ReadLine();
                        Console.WriteLine(" " +peliteca.CuantasPeliculasHayGenero(genero));                        

                }

            }while(aux!=0);
        }
    }
}
