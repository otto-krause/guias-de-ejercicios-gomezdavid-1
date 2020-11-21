using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Pandillas
    {
        private List<Villanos> pandillaDeVillanos;

        public Pandillas(List<Villanos> pandillaDeVillanos)
        {
            this.pandillaDeVillanos = pandillaDeVillanos;
        }

        public int SumatoriaDePoderes()
        {
            return pandillaDeVillanos.Sum(x => x.Quirk.Poder());
        }

    }
}