namespace Ejercicio
{
    public class Sable : Arma
    {
        public Sable(int potencia, int desgaste, int cantidadDeUsos, int poder) : base(potencia, desgaste, cantidadDeUsos, poder)
        {
        }

        public override int Poder()
        {
            return poder = potencia * cantidadDeUsos * 2;
        }
    }
}