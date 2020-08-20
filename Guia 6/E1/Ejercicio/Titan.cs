namespace Ejercicio
{
    public abstract class Titan
    {
        protected int tristeza;

        protected Titan(int tristeza)
        {
            this.tristeza = tristeza;
        }

        public abstract void ComerPizza();
        public abstract void LlorarPorRobocop();
        public abstract bool EstaTriste();
        public abstract int Poder();
    }
}