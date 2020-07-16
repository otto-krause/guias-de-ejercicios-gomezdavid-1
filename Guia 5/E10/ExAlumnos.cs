namespace E10
{
    public class ExAlumnos
    {
        private int cantidadDeIdiomasAprendidos;
        private int sueldo;
        private int cantidadDePaisesVisitados;

        public ExAlumnos(int cantidadDeIdiomasAprendidos, int sueldo, int cantidadDePaisesVisitados)
        {
            this.cantidadDeIdiomasAprendidos = cantidadDeIdiomasAprendidos;
            this.sueldo = sueldo;
            this.cantidadDePaisesVisitados = cantidadDePaisesVisitados;
        }

        public int CantidadDeIdiomasAprendidos { get => cantidadDeIdiomasAprendidos; set => cantidadDeIdiomasAprendidos = value; }
        public int Sueldo { get => sueldo; set => sueldo = value; }
        public int CantidadDePaisesVisitados { get => cantidadDePaisesVisitados; set => cantidadDePaisesVisitados = value; }
    }
}