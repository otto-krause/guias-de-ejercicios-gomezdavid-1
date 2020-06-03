namespace E1
{
    public abstract class Animal
    {
        protected int energia;

        public Animal(int energia)
        {
            this.energia = 0;
        }

        public abstract int Comer();

        public abstract int Jugar();

        public int Dormir()
        {
            return energia+=50;
        }
    }
}