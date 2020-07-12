namespace E6
{
    public class Pelicula
    {
        private string nombre;
        private string genero;
        private string director;
        private int anio;

        public Pelicula(string nombre, string genero, int anio, string director)
        {
            this.nombre = nombre;
            this.genero = genero;
            this.anio = anio;
            this.director = director;
        }
        public string Nombre { get => nombre;}
        public string Genero { get => genero;}
        public string Director { get => director;}
        public int Anio { get => anio;}
    }
}