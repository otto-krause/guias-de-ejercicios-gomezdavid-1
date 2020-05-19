using System.Collections.Generic;
namespace E2
{
    public class Albañiles : ContratistaINT
    {
        public bool MMO = true;
        public int cobro=0;
        public int edad=0;
        List<Contratistas> albañiles = new List<Contratistas>();

        public Albañiles()
        {
            this.MMO = true;
            this.cobro = 0;
            this.edad = 0;
            albañiles.Add(new Contratistas(0,23,true));
            albañiles.Add(new Contratistas(0,35,true));
            albañiles.Add(new Contratistas(0,56,true));
            albañiles.Add(new Contratistas(0,21,false));
            albañiles.Add(new Contratistas(0,39,true));
        }

        public void Trabajar(int horas)
        {
            foreach (var i in albañiles)
            {
                if(i.edad>=20&&i.edad<=30)
                    i.cobro=horas*50;
                    if(i.MMO==true)
                        AumentoMMO();
                if(i.edad>30&&i.edad<=50)
                    i.cobro=horas*90;
                    if(i.MMO==true)
                        AumentoMMO();
                i.cobro=horas*120;
                if(i.MMO==true)
                    AumentoMMO();

            }
        }
        public int Cobrar()
        {
            foreach (var i in albañiles)
            {
                this.cobro+=i.cobro;
            }
            return this.cobro;
        }
        public void AumentoMMO()
        {
            this.cobro+=50;
        }
    }
}