using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Zero
    {
        List<Arma> listaDeArmas;
        List<Maverick> listaDeMavericks;
        public bool LoPuedeVencer(Maverick maverick)
        {
            return Poder()>maverick.Fuerza();
        }

        public int Poder()
        {
            int poderDeSuArmaMasPoderosa;
            return poderDeSuArmaMasPoderosa = listaDeArmas.Max(x=> x.Poder());
        }

        public bool LosPuedeVencer()
        {
            int aux=0,cantidadDeMavericks;
            cantidadDeMavericks = listaDeMavericks.Count();
            aux += (listaDeMavericks.Where(i => Poder() > i.Fuerza())).Count();
            return cantidadDeMavericks==aux;
        }

        public Arma LaMasPolentosa()
        {
            Arma armaMasPolentosa;
            return armaMasPolentosa = listaDeArmas.OrderByDescending(x => x.Poder()).First();
        }
    }
}