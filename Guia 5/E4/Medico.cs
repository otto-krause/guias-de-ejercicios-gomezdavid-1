namespace E4
{
    public class Medico
    {
        private string nombre;
        private string apellido;
        private string especialidad;
        private int cantidadDeTurnos;

        public string Nombre { get => nombre; set => nombre = value; }

        public Medico(string nombre, string apellido, string especialidad, int cantidadDeTurnos)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.especialidad = especialidad;
            this.cantidadDeTurnos = cantidadDeTurnos;
        }

        public bool EstaDisponible()
        {
            return cantidadDeTurnos < 50;
        }

        public bool EsDeEsaEspecialidadYEstaDisponibble(string especialidad)
        {
            return this.especialidad == especialidad && EstaDisponible();
        }

        public void AsignarTurno()
        {
            cantidadDeTurnos++;
        }
    }
}