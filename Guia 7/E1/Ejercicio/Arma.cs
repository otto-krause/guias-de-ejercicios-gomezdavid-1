namespace Ejercicio
{
    public class Arma
    {
        private string marca;
        private int cantidadDeBalas;

        public Arma(string marca, int cantidadDeBalas)
        {
            this.marca = marca;
            this.cantidadDeBalas = cantidadDeBalas;

        }

        public string Marca { get => marca;}
        public int CantidadDeBalas { get => cantidadDeBalas;}
    }
}