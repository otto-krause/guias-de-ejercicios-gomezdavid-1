namespace E4
{
    public class RRHH : Empleado
    {
        public RRHH(int cajaBancaria) : base(cajaBancaria)
        {
        }

        public override void Depositar(int monto, int nivel)
        {
            cajaBancaria+=(10000+monto);
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