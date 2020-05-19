using System.Collections.Generic;
namespace E2
{
    public class Pintores : ContratistaINT
    {
        public int litrosDePintura;
        public int cobro=0;
        List<Contratistas> pintores = new List<Contratistas>();

        public Pintores()
        {
            this.litrosDePintura = 0;
            pintores.Add(new Contratistas(0,19,true));
            pintores.Add(new Contratistas(0,19,true));
            pintores.Add(new Contratistas(0,19,true));
            pintores.Add(new Contratistas(0,19,true));
            pintores.Add(new Contratistas(0,19,true));
        }

        public void Trabajar(int horas)
        {
            foreach (var i in pintores)
            {
                litrosDePintura=horas*3;
                i.cobro=litrosDePintura*50;
            }
        }

        public int Cobrar()
        {
            foreach (var i in pintores)
            {
                this.cobro+=i.cobro;
            }
            return this.cobro;
        }
    }
}