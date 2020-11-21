using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Batman
    {

        private List<Tecnologias> batiRiñonera;
        private int fuerza;
        private int vida;
        private int estres;


        public Batman(List<Tecnologias> batiRiñonera, int fuerza, int vida, int estres)
        {
            this.batiRiñonera=batiRiñonera;
            this.fuerza=fuerza;
            this.vida=800;
            this.estres=8;
        }

        public void CombatirElCrimen()
        {
            estres++;
        }

        public void DesarrolarNuevasTecnologias()
        {
            //agregar tecnologia a la lista batiRiñonera
        }

        public void LlorarPorSusPadres()
        {
            estres-=10;
            batiRiñonera.RemoveAt(0);
        }

        public double Fuerza()
        {
            return vida+batiRiñonera.Sum(x => x.Poder());
        }
    }
}