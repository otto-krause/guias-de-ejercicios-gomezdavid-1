namespace Ejercicio
{
    public class Maquillaje
    {
        private string nombre;
        private int susto;

        public Maquillaje(string nombre)
        {
            this.nombre = nombre;
            this.susto = 3;
        }

        public string Nombre { get => nombre;}
        public int Susto { get => susto;}
    }
}