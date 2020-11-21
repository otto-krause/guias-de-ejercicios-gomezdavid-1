namespace Ejercicio
{
    public abstract class Ladron
    {

        protected int cantidadDeMaldades;
        protected Ladron(int cantidadDeMaldades)
        {
            this.cantidadDeMaldades = cantidadDeMaldades;
        }

        public abstract void Maldad();
        public int Fuerza()
        {
            return cantidadDeMaldades;
        }
    }
}