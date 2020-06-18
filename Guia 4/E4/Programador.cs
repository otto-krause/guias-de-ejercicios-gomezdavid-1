namespace E4
{
    public class Programador : Empleado
    {
        public Programador(int cajaBancaria) : base(cajaBancaria)
        {
        }

        public override void Depositar(int monto, int nivel)
        {
            if(nivel==1)
                cajaBancaria+=(2000+10000+monto);
            if(nivel==2)
                cajaBancaria+=(2000+20000+monto);
            cajaBancaria+=(2000+40000+monto);
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