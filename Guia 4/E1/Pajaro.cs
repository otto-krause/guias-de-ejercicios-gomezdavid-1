namespace E1
{
    public class Pajaro : Animal
    {
        public Pajaro(int energia) : base(energia)
        {
        }

        public override int Comer()
        {
            return energia += 10;
        }

        public override int Jugar()
        {
            return energia -= 5;
        }
    }
}