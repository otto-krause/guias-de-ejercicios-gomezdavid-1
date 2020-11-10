namespace Ejercicio
{
    public class AdultoComun
    {
        private int cantidadDeNiñosConMasDe15CaramelosQueIntentaronAsustarloAntes;

        public AdultoComun(int cantidadDeNiñosConMasDe15CaramelosQueIntentaronAsustarloAntes)
        {
            this.cantidadDeNiñosConMasDe15CaramelosQueIntentaronAsustarloAntes = cantidadDeNiñosConMasDe15CaramelosQueIntentaronAsustarloAntes;
        }

        public int Tolerancia()
        {
            return 10*cantidadDeNiñosConMasDe15CaramelosQueIntentaronAsustarloAntes;
        }
        public double Asustarse(int capacidadDeSustoNiño)
        {
            if(capacidadDeSustoNiño>Tolerancia())
                return Tolerancia()/2;
            return 0;
        }
    }
}