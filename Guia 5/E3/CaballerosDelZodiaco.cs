namespace E3
{
    public class CaballerosDelZodiaco
    {
        private string nombre;
        private string diosAlQueApoya;
        private string signoDelZodiaco;
        private Armadura armadura;

        public CaballerosDelZodiaco(string nombre, string diosAlQueApoya, string signoDelZodiaco, Armadura armadura)
        {
            this.nombre = nombre;
            this.diosAlQueApoya = diosAlQueApoya;
            this.signoDelZodiaco = signoDelZodiaco;
            this.armadura = armadura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string DiosAlQueApoya { get => diosAlQueApoya; set => diosAlQueApoya = value; }
        public string SignoDelZodiaco { get => signoDelZodiaco; set => signoDelZodiaco = value; }
        public Armadura Armadura { get => armadura; set => armadura = value; }
    }
}