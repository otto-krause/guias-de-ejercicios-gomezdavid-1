namespace Ejercicio
{
    public abstract class Quirk
    {
        protected int tiempoDeUso; //en horas.
        protected string nombre;
        protected bool consecuenciasEnElUsuario; //un quirk puede tener consecuencias en el usuario.

        public Quirk(int tiempoDeUso, string nombre, bool consecuenciasEnElUsuario)
        {
            this.tiempoDeUso = tiempoDeUso;
            this.nombre = nombre;
            this.consecuenciasEnElUsuario = consecuenciasEnElUsuario;
        }

        public abstract int Poder();

        public abstract bool EsPeligroso();
    }
}