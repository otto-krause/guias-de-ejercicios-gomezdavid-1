using System;
using System.Collections.Generic;
namespace E3
{
    public class Album
    {
        List<Figurita> figuritas = new List<Figurita>();
        int cont1=0,cont2=0,cont3=0;

        public Album()
        {
            figuritas.Add(new Figurita("Ezequiel", "Delantero","Japon",13));
            figuritas.Add(new Figurita("Fabrizio", "Lateral","Brasil",30));
            figuritas.Add(new Figurita("David", "Defensor","Paraguay",7));
        }

        public void AgregarFigurita (string nombre, string posicion, string pais, int numFigurita)
        {
            foreach (var aux in figuritas)
            {
                if(numFigurita==aux.numFigurita)
                {
                    Console.WriteLine("La figurita ya esta en el album");
                }
                else
                {
                    Figurita figurita = new Figurita(nombre,posicion,pais,numFigurita);
                    figuritas.Add(figurita);
                    //figuritas.Add(new Figurita(nombre,posicion,pais,numFigurita));
                }
            }
        }

        public void CantidadDeDelanterosYMedioCampistas(string posicion)
        {
            foreach (var aux in figuritas)
            {
                if(aux.posicion=="Mediocampista")cont1+=1;
                if(aux.posicion=="Delantero")cont2+=1;    
            }

            Console.WriteLine("Cantidad de delanteros: "+cont2);
            Console.WriteLine("Cantidad de mediocampistas: " +cont1);
        }

        public void EstaCompleto()
        {
            foreach (var aux in figuritas)
            {
                if(aux.numFigurita!=0)cont3+=1;
            }

            if(cont3==352)Console.WriteLine("El album esta completo");
            if(cont3!=352)Console.WriteLine("El abum no esta completo");
        }
    }
}