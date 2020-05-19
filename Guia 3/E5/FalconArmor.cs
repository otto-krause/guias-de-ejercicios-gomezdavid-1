namespace E5
{
    public class FalconArmor : Armadura
    {
        private int potencia = 0;
        private int resistencia = 0;

        public FalconArmor()
        {
            this.potencia = 25;
            this.resistencia = 10;
        }

        public int BonificacionDeDaño()
        {
            return ((potencia + resistencia) / 2);
        }

        public void Entrenamiento(int minutos)
        {
            resistencia -= minutos;
            if (resistencia < 0)
                resistencia = 0;
            potencia += 10;
        }
    }
}