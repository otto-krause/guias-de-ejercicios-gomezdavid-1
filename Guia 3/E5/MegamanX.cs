namespace E5
{
    public class MegamanX
    {
        private int xBuster = 0;
        private Armadura armadura;
        public int XBuster { get => xBuster; }
        public MegamanX()
        {
            this.xBuster = 0;
            this.armadura = new FalconArmor();
        }


        public int Fuerza()
        {
            return (xBuster + armadura.BonificacionDeDaño());
        }

        public void Entrenar(int minutos)
        {
            xBuster += minutos * 2;
        }

        public void CambiarArmadura(Armadura cambioarmadura)
        {
            armadura = cambioarmadura;
        }
    }
}