namespace Ejercicio
{
    public abstract class Traje
    {
        protected int susto;

        protected Traje(int susto)
        {
            this.susto=susto;
        }

        public int Susto { get => susto;}
    }
}