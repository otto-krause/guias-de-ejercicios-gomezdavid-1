namespace Ejercicio
{
    public class Heroes
    {
        private Quirk quirk;
        private int contadorDeVictorias;
        private int contadorDeDerrotas;
        private bool licenciaDeHeroe;
        private bool actaDeDefuncion;

        public Heroes(Quirk quirk, int contadorDeVictorias, int contadorDeDerrotas, bool licenciaDeHeroe, bool actaDeDefuncion)
        {
            this.quirk = quirk;
            this.contadorDeVictorias = contadorDeVictorias;
            this.contadorDeDerrotas = contadorDeDerrotas;
            this.licenciaDeHeroe = licenciaDeHeroe;
            this.actaDeDefuncion = actaDeDefuncion;
        }

        public Quirk Quirk { get => quirk; set => quirk = value; }
        public int ContadorDeVictorias { get => contadorDeVictorias;}
        public int ContadorDeDerrotas { get => contadorDeDerrotas;}
        public bool LicenciaDeHeroe { get => licenciaDeHeroe;}
        public bool ActaDeDefuncion { get => actaDeDefuncion;}
    }
}