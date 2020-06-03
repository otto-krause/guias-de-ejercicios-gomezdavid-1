namespace E1
{
    public class Perro : Animal
    {
        public Perro(int energia) : base(energia)
        {
            
        }

        public override int Comer()
        {
            return energia += 15;
        }

        public override int Jugar()
        {
            return energia -= 20;
        }
    }
}