namespace Ejercicio
{
    public abstract class SpidermanClasico
    {
        protected Traje traje;
        protected int fuerza;

        protected SpidermanClasico(Traje traje, int fuerza)
        {
            this.traje = traje;
            this.fuerza = fuerza;
        }


        public void Atacar(KingPin kingpin)
        {
            kingpin.PuntosDeVida-=Poder();
            
        }

        public abstract int Poder();
        public int Fuerza { get => fuerza;}
    }
}