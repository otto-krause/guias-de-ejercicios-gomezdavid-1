namespace Ejercicio
{
    public class PeterParker : SpidermanClasico
    {
        public PeterParker(Traje traje, int fuerza) : base(traje, fuerza)
        {
        }

        public override int Poder()
        {
            return fuerza+traje.Resistencia;
        }

    }
}