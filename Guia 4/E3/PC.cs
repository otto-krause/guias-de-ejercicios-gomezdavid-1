using System.Collections.Generic;

namespace E3
{
    public class PC : Consola
    {
        public PC(int puntos) : base(puntos)
        {
        }

        public override void Agregar(string nombreJuego)
        {
            juegos.Add(nombreJuego);
        }
        public override void JugarJuego(int horasDeJuego)
        {
            puntos+=10*horasDeJuego;
        }
    }
}