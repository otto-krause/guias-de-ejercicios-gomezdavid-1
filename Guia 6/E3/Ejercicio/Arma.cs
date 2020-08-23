namespace Ejercicio
{
    public abstract class Arma
    {
        protected int potencia;

        protected int desgaste;
        
        protected int cantidadDeUsos;

        protected int poder;

        protected Arma(int potencia, int desgaste, int cantidadDeUsos, int poder)
        {
            this.potencia = potencia;
            this.desgaste = desgaste;
            this.cantidadDeUsos = cantidadDeUsos;
            this.poder = poder;
        }
        public abstract int Poder();
    }
}