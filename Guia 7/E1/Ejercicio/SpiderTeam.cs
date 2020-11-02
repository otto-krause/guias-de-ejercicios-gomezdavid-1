using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class SpiderTeam
    {
        List<SpidermanClasico> listaDeSpidermans;

        public List<SpidermanClasico> ListaDeSpidermans { get => listaDeSpidermans; set => listaDeSpidermans = value; }

        public SpiderTeam (List<SpidermanClasico> listaDeSpidermans)
        {
            this.listaDeSpidermans=new List<SpidermanClasico>();
        }
        public void PelearConAKingPin(KingPin kingpin)
        {
            //listaDeSpidermans.ForEach(i => i.Atacar(kingpin));
            foreach (var i in listaDeSpidermans)
            {
                i.Atacar(kingpin);
            }
        }

        public void VolverACasa(KingPin kinping)
        {
            if(kinping.FueVencido())
                listaDeSpidermans.OrderBy(x => x.Poder());
                int cont = listaDeSpidermans.Count;
                listaDeSpidermans.RemoveAt(0);
            throw new System.Exception("Error, KingPing no fue vencido. Ningun Spiderman pudo irse a casa");
        }

        public int FuerzaDelSpiderTeam()
        { 
            return listaDeSpidermans.Sum(x => x.Fuerza);
        }
    }
}