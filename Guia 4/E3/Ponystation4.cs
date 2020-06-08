using System.Collections.Generic;

namespace E3
{
    public class Ponystation4 : Consola
    {
        public Ponystation4(int puntos) : base(puntos)
        {
        }

        public override void Agregar(string nombreJuego)
        {
            juegos.Add(nombreJuego);
            puntos+=29;
        }
        public override void JugarJuego(int horasDeJuego)
        {
            puntos+=3*horasDeJuego;
        }
    }
}