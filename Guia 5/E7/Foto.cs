namespace E7
{
    public class Foto
    {
        private string directorioDeAlmacenamiento;
        private string fechaDeCreacionDiaYMes;
        private int anio;
        private string personasEtiquetdas;

        public Foto(string directorioDeAlmacenamiento, string fechaDeCreacionDiaYMes,int anio, string personasEtiquetdas)
        {
            this.directorioDeAlmacenamiento = directorioDeAlmacenamiento;
            this.fechaDeCreacionDiaYMes = fechaDeCreacionDiaYMes;
            this.anio = anio;
            this.personasEtiquetdas = personasEtiquetdas;
        }

        public string DirectorioDeAlmacenamiento { get => directorioDeAlmacenamiento;}
        public string PersonasEtiquetdas { get => personasEtiquetdas;}
        public string FechaDeCreacionDiaYMes { get => fechaDeCreacionDiaYMes;}
        public int Anio { get => anio;}
    }
}