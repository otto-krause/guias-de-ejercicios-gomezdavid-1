namespace E4
{
    public class Administrativo : Empleado
    {
        public Administrativo(int cajaBancaria) : base(cajaBancaria)
        {
        }

        public override void Depositar(int monto, int nivel)
        {
            cajaBancaria+=35000;
        }

        public override int Extraer(int monto)
        {
            cajaBancaria-=monto;
            if(cajaBancaria<0)
            {
                cajaBancaria+=monto;
                return monto;
            }
            return cajaBancaria;
        }

    }
}