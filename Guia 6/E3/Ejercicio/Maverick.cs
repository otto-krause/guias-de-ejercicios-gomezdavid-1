namespace Ejercicio
{
    public class Maverick
    {
        private Arma arma;
        private int fuerza;
        private int destreza;
        public int Fuerza()
        {
            return arma.Poder()+destreza;
        }

        public bool EsDebil()
        {
            return Fuerza()<200;
        }
    }
}