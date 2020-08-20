namespace Ejercicio
{
    public class Arma
    {
        private int dureza;
        private int potencia;

        public Arma(int dureza, int potencia)
        {
            this.dureza = dureza;
            this.potencia = potencia;
        }

        public int Dureza { get => dureza; set => dureza = value; }
        public int Potencia { get => potencia; set => potencia = value; }

        public int Fuerza()
        {
            int a = 0, b = 0, c = 1;

            for (int i = 2; i <= dureza; i++)
            {
                a = b;
                b = c;
                c = a + b;
            }
            return potencia + c;
        }
    }
}