using System.Collections.Generic;
using System.Linq;
using System;

/*Tenemos una lista de Caballeros del Zodiaco (nombre, dios al que apoya, y una armadura, signo del zodiaco).
De cada armadura sabemos que tienen nombre, material (bronce, plata, oro). Requerimos lo siguiente:
-Mostrar todas las armaduras de los caballeros que apoyen a Atena.
-Mostrar los nombres de todos los dioses, sin repetidos.
-Mostrar a todos los signos del zodiaco que empiecen con la letra C.
*/

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<CaballerosDelZodiaco> listaCaballeros = new List<CaballerosDelZodiaco>
            {new CaballerosDelZodiaco("Shaka de Virgo","Mars","Virgo",new Armadura("Armadura Celestial","Litio")),
            new CaballerosDelZodiaco("Mu de Aries","Athena","Aries",new Armadura("Armadura del reino Oscuro","LapizLazuli"))};

            Console.WriteLine("Armaduras de Caballeros que apoyan a Athena:");/////////////a

            listaCaballeros.Where(caballero => caballero.DiosAlQueApoya == "Athena")
            .ToList()
            .ForEach(caballero => Console.WriteLine("Caballero: "+caballero.Nombre+"///Nombre armadura: "+caballero.Armadura.NombreArmadura + "///Material de Armadura: " +caballero.Armadura.Material));

            Console.WriteLine("Nombres de los Dioses(sin repetidos):");////////////////b

            List<string> nombreDioses =new List<string>();
            listaCaballeros.ForEach(i => nombreDioses.Add(i.DiosAlQueApoya));

            var DiosesSinRepetir = nombreDioses.Distinct();

            foreach (var i in DiosesSinRepetir)Console.WriteLine(i);

            Console.WriteLine("Signos del zodiaco que empiezan con la letra 'C' ");//////////////////////c

            listaCaballeros.Where(c => c.SignoDelZodiaco.StartsWith("C"))
            .ToList()
            .ForEach(c => Console.WriteLine(c.SignoDelZodiaco));
        }
    }
}
