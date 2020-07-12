using System.Collections.Generic;
using System.Linq;

namespace E6
{
    public class Peliteca
    {
        private List<Pelicula> peliculas = new List<Pelicula>();

        public List<Pelicula> Peliculas { get => peliculas; set => peliculas = value; }

        public Peliteca()
        {
            peliculas.Add(new Pelicula("La llamada", "Terror", 2004, "Colter Ezekiel"));
            peliculas.Add(new Pelicula("Titanic", "Romance", 1999, "Furbizio Celomar"));
            peliculas.Add(new Pelicula("Avengers", "Accion", 2012, "Russo"));
        }
    }
}