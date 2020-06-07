using System;
using System.Collections.Generic;
namespace E2
{
    public class MonstersInc
    {
        public List<Monstruo> listaMonstruos;
        private int energia;

        public int Energia { get => energia; }

        public MonstersInc()
        {
            this.energia = 0;
            listaMonstruos.Add(new Peligroso(0, "Randall Boggs"));
            listaMonstruos.Add(new Peligroso(0, "Henry J. Waternoose"));
            listaMonstruos.Add(new Peligroso(0, "James P. Sullivan"));
            listaMonstruos.Add(new Amigable(0, "Mike Wazowski"));
            listaMonstruos.Add(new Amigable(0, "George Sanderson"));
            listaMonstruos.Add(new Amigable(0, "Bile"));
        }

        public void NocheDeSustos()
        {
            foreach (var i in listaMonstruos)
            {
                i.Asustar();
            }
        }

        public void NocheDeRisas()
        {
            foreach (var i in listaMonstruos)
            {
                i.Reir();
            }
        }

        public int EnergiaEmpresa()
        {
            foreach (var i in listaMonstruos)
            {
                energia += i.Respeto;
            }
            return Energia;
        }

        public string listarMonstruosRespetables()
        {
            foreach (var i in listaMonstruos)
            {
                if(i.Respetable())
                    Console.WriteLine(i.NombreMonstruo + " Es Respetable, puntos de respeto: " + i.Respeto);
                    
            }
            return "Ningun monstruo es Respetable";     
        }
    }
}