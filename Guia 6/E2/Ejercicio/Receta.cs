using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Receta
    {
        private List<Ingrediente> listaIngredientes;
        private List<int> pasos;
        

        public Receta(List<Ingrediente> listaIngredientes, List<int> pasos)
        {
            this.listaIngredientes = listaIngredientes;
            this.pasos = pasos;
        }

        public List<Ingrediente> ListaIngredientes { get => listaIngredientes; set => listaIngredientes = value; }
        public List<int> Pasos { get => pasos; set => pasos = value; }

        public bool EsDeGordo()
        {
            return listaIngredientes.Sum(x => x.Calorias) > 2000;
        }

        public bool EsRapida()
        {
            return listaIngredientes.Count/pasos.Count > 1;
        }

        public int DevuelveLasCaloriasTotales()
        {
            int sumaDeCaloriasTotales=0;
            return sumaDeCaloriasTotales = listaIngredientes.Sum(x => x.Calorias);
        }
    }
}