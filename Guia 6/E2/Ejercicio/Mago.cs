using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Mago
    {
        private Varita varitaMagica;
        private List<Receta> listaDeRecetas;

        public Mago(Varita varitaMagica, List<Receta> listaDeRecetas)
        {
            this.varitaMagica = varitaMagica;
            this.listaDeRecetas = listaDeRecetas;
        }

        public Varita VaritaMagica { get => varitaMagica; set => varitaMagica = value; }
        public List<Receta> ListaDeRecetas { get => listaDeRecetas; set => listaDeRecetas = value; }

        public bool EsUnLento(Receta receta)
        {
            return varitaMagica.TiempoDePreparacionDeLaReceta(receta)>30;
        }

        public bool NoSeCuida()
        {
            return listaDeRecetas.Where(x => x.EsDeGordo()==true).ToList().Count > listaDeRecetas.Count/2;
        }
    }
}