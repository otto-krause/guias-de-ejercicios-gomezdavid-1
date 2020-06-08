using System.Collections.Generic;
namespace E3
{
    public abstract class Consola
    {
        protected List<string> juegos;
        protected int puntos;
        public Consola(int puntos)
        {
            this.puntos = 0;
            juegos = new List<string>();
        }

        public abstract void Agregar(string nombreJuego);
        public abstract void JugarJuego(int horasDeJuego);
        public int RevisarPuntaje()
        {
            return puntos;
        }
    }
}