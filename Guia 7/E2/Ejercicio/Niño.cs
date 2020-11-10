using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Niño : Malevolo
    {
        private int capacidadDeAsustar;
        private int actitud; //indice del 1 al 10;
        private double caramelos;
        private Traje traje;
        private List<Maquillaje> listaDeMaquillajes;

        public List<Maquillaje> ListaDeMaquillajes { get => listaDeMaquillajes; set => listaDeMaquillajes = value; }
        public int CapacidadDeAsustar { get => capacidadDeAsustar; set => capacidadDeAsustar = value; }
        public double Caramelos { get => caramelos; set => caramelos = value; }
        public Traje Traje { get => traje; set => traje = value; }
        public int Actitud { get => actitud; set => actitud = value; }

        public Niño(int capacidadDeAsustar, int actitud, double caramelos, Traje traje, List<Maquillaje> listaDeMaquillajes)
        {
            this.capacidadDeAsustar = capacidadDeAsustar;
            this.actitud = actitud;
            this.caramelos = caramelos;
            this.traje = traje;
            this.listaDeMaquillajes = listaDeMaquillajes;
        }

        public int capacidadDeSustoDelNiño()
        {
            return (traje.Susto + listaDeMaquillajes.Sum(x => x.Susto)) * actitud;//devuelve la sumatorio del susto que tengan los elementos que lleva puesto(traje, maquillajes) multiplicado por la actitud.
        }

        public void AsustarAdultoComun(AdultoComun adultocomun)
        {
            if(adultocomun.Asustarse(capacidadDeSustoDelNiño())!=0)
                caramelos+=adultocomun.Asustarse(capacidadDeSustoDelNiño());
        }

        public void AsustarAnciano(Anciano anciano,AdultoComun adultocomun)
        {
            if(anciano.Asustarse(adultocomun,capacidadDeSustoDelNiño())!=0)
                caramelos+=anciano.Asustarse(adultocomun, capacidadDeSustoDelNiño());
        }

        public void AsustarNecio(AdultoNecio adultonecio)//si mas adelante no se usa, borrar.
        {

        }
    
    }
}