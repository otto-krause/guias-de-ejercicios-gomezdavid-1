using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class SpidermanNoir : SpidermanClasico
    {
        public PeterParker peterparker;
        public SpidermanNoir(Traje traje, int fuerza,PeterParker peterparker) : base(traje, fuerza)
        {
            this.peterparker = peterparker;
        }

        public override int Poder()
        {
            return peterparker.Poder() +  traje.ListaDeArmas.Count;
        }
    }
}