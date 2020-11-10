using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Legion : Malevolo
    {
        private List<Niño> listaMalevolos;

        public Legion(List<Niño> listaMalevolos)
        {
            this.listaMalevolos = listaMalevolos;
        }

        public List<Niño> ListaMalevolos { get => listaMalevolos; set => listaMalevolos = value; }

        public void AsustarAdultoComun(AdultoComun adultocomun)
        {
            throw new System.NotImplementedException();
        }

        public void AsustarAnciano(Anciano anciano, AdultoComun adultocomun)
        {
            throw new System.NotImplementedException();
        }

        public void AsustarNecio(AdultoNecio adultoNecio)
        {
            throw new System.NotImplementedException();
        }

        public int capacidadDeSustoDelNiño()
        {
            return listaMalevolos.Sum(x => x.)
        }
    }
}