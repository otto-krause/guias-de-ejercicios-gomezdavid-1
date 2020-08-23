namespace Ejercicio
{
    public class Blaster : Arma
    {
        public Blaster(int potencia, int desgaste, int cantidadDeUsos, int poder) : base(potencia, desgaste, cantidadDeUsos, poder)
        {
        }

        public override int Poder()
        {
            if(poder>1)
                return poder=potencia-cantidadDeUsos;
            return poder=1;
        }
    }
}