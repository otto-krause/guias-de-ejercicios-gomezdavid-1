namespace Ejercicio
{
    public class SpiderGwen : SpidermanClasico
    {
        private int glamour;
        public SpiderGwen(int glamour, Traje traje, int fuerza) : base(traje, fuerza)
        {
            this.glamour = glamour;
        }

        public override int Poder()
        {
            if (glamour >= 1 && glamour <= 10)
                return fuerza + glamour;
            throw new System.Exception("El glamour de SpiderGwen esta fuera del rango 1-10");
        }
    }
}