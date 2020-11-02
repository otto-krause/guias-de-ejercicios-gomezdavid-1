namespace Ejercicio
{
    public class KingPin
    {
        private int puntosDeVida;

        public KingPin(int puntosDeVida)
        {
            this.puntosDeVida = puntosDeVida;
        }

        public bool FueVencido()
        {
            return puntosDeVida < 0;
        }

        public int PuntosDeVida { get => puntosDeVida; set => puntosDeVida = value; }
    }
}