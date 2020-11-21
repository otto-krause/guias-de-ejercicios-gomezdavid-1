namespace Ejercicio
{
    public class Tecnologias
    {
        private string nombre;
        private int potencia;
        private int cantidadDeUsos;

        public Tecnologias(string nombre, int potencia, int cantidadDeUsos)
        {
            this.nombre=nombre;
            this.potencia=potencia;
            this.cantidadDeUsos=cantidadDeUsos;
        }

        public double Poder()
        {
            return potencia/cantidadDeUsos;
        }
    }
}