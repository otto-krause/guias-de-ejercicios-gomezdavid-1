namespace E4
{
    public abstract class Empleado
    {
        protected int cajaBancaria;

        protected Empleado(int cajaBancaria)
        {
            this.cajaBancaria = cajaBancaria;
        }

        public abstract void Depositar(int monto, int nivel);
        public abstract int Extraer(int monto);

        public int ConsultarCajaBancaria()
        {
            return cajaBancaria;
        }

    }
}