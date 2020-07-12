using System.Collections.Generic;
using System.Linq;
using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();

            Console.WriteLine("Ultimos 5 elementos de la lista");
            foreach (var i in p.Conocimientos.Skip(Math.Max(0,p.Conocimientos.Count() - 5)))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Primeros cuatro elementos ordenados alfabeticamente:");
            foreach (var i in p.Conocimientos.GetRange(0,4).OrderBy(x => x))
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Cuantos Elementos con terminacion 'cion' ");
            int elementosConTerminacionCion = p.Conocimientos.Where(x => x.EndsWith("cion")).Count();
            Console.WriteLine(elementosConTerminacionCion);

        }
    }
}
