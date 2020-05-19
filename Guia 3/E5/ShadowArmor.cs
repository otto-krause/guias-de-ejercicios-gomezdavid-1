namespace E5
{
    public class ShadowArmor : Armadura
    {
        MegamanX x = new MegamanX();
        public int nivelDeDesgaste = 1;

        public ShadowArmor()
        {
            this.nivelDeDesgaste = 1;
        }

        public void Entrenamiento(int minutos)
        {
            nivelDeDesgaste += x.XBuster;
        }
        public int BonificacionDeDaño()
        {
            return (80 / nivelDeDesgaste);
        }
    }
}