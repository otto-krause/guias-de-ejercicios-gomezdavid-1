namespace Ejercicio
{
    public class Villanos
    {
        private bool robóEnOnce;
        private bool tuvoTrabajo;
        private bool leGustaLaPizzaConPiña;
        private Quirk quirk;

        public bool RobóEnOnce { get => robóEnOnce;}
        public bool TuvoTrabajo { get => tuvoTrabajo;}
        public bool LeGustaLaPizzaConPiña { get => leGustaLaPizzaConPiña;}
        public Quirk Quirk { get => quirk;}

        public Villanos(bool robóEnOnce, bool tuvoTrabajo, bool leGustaLaPizzaConPiña, Quirk quirk)
        {
            this.robóEnOnce = robóEnOnce;
            this.tuvoTrabajo = tuvoTrabajo;
            this.leGustaLaPizzaConPiña = leGustaLaPizzaConPiña;
            this.quirk = quirk;
        }

        public bool EsMuyMalo()
        {
            return robóEnOnce == true && tuvoTrabajo == false && leGustaLaPizzaConPiña == true;
        }

        public bool AlgunaVezFueBueno()
        {
            return quirk.EsPeligroso() == false && tuvoTrabajo == true;
        }
    }
}