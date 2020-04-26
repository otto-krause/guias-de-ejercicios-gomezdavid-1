namespace E4
{
    public class Pelicula
    {
        public string nombre, genero, director;
        public int anio;

        public Pelicula(string nombre, string genero, int anio, string director)
        {
            this.nombre=nombre;
            this.genero=genero;
            this.anio=anio;
            this.director=director;
        }
    }
}