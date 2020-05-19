using System.Collections.Generic;
namespace E2
{
    public class Plomeros : ContratistaINT
    {
        public int cobro=0;

        List<Contratistas> plomeros = new List<Contratistas>();

        public Plomeros()
        {
            this.cobro = 0;
            plomeros.Add(new Contratistas(0,25,false));
            plomeros.Add(new Contratistas(0,25,false));
            plomeros.Add(new Contratistas(0,25,false));
            plomeros.Add(new Contratistas(0,25,false));
            plomeros.Add(new Contratistas(0,25,false));
        }

        public void Trabajar(int horas)
        {
            foreach (var i in plomeros)
            {
                i.cobro=80*horas; 
            }
        }
        public int Cobrar()
        {
            foreach (var i in plomeros)
            {
                this.cobro+=i.cobro;
            }
            return this.cobro;
        }
    }
}