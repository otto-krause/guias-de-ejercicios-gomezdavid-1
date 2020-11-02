namespace Ejercicio
{
    public class MilesMorales : SpidermanClasico
    {
        private int habilidadParaCantar;

        public MilesMorales(int habilidadParaCantar, Traje traje, int fuerza) : base(traje, fuerza)
        {
            this.habilidadParaCantar = habilidadParaCantar;
        }

        public override int Poder()
        {
            return fuerza+habilidadParaCantar;
        }
    }
}