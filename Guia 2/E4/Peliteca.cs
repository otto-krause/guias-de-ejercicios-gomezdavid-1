using System.Collections.Generic;
using System;
namespace E4
{
    public class Peliteca
    {
        List<Pelicula> peliculas = new List<Pelicula>();

        int cont=0,cont2;
        public Peliteca()
        {
            peliculas.Add(new Pelicula("La llamada","Terror",2004,"Colter Ezekiel"));
            peliculas.Add(new Pelicula("Titanic","Romance",1999,"Furbizio Celomar"));
            peliculas.Add(new Pelicula("Avengers","Accion",2012,"Russo"));
        }

        public string BuscarPorGenero(string genero)
        {
            foreach (var i in peliculas)
            {
                if(i.genero==genero)
                {
                    return i.nombre;
                }
            }

            return null;
        }

        public string BuscarPorNombre(string nombre)
        {
            foreach (var i in peliculas)
            {
                if(i.nombre==nombre)
                {
                    return i.nombre;
                }
            }

            return null;
        }

        public string BuscarPorAnio(int anio)
        {
            foreach (var i in peliculas)
            {
                if(i.anio==anio)
                {
                    return i.nombre;
                }
            }

            return null;
        }

        public string BuscarPorDirector(string director)
        {
            foreach (var i in peliculas)
            {
                if(i.director==director)
                {
                    return i.nombre;
                }
            }

            return null;
        }

        public int CuantasPeliculasHay()
        {
            foreach (var i in peliculas)
            {
                cont+=1;
            }

            return cont;
        }

        public int CuantasPeliculasHayGenero (string genero)
        {
            foreach (var i in peliculas)
            {
                if(i.genero==genero)
                {
                    cont2+=1;
                }
            }

            return cont2;
        }
        
    }
}