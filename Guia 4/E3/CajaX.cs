using System.Collections.Generic;

namespace E3
{
    public class CajaX : Consola
    {
        public CajaX(int puntos) : base(puntos)
        {
        }

        public override void Agregar(string nombreJuego)
        {
            juegos.Add(nombreJuego);
            puntos+=25;
        }
        public override void JugarJuego(int horasDeJuego)
        {
            puntos+=horasDeJuego*4;
        }
    }
}