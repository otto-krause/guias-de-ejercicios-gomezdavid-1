using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            Constructora constructora = new Constructora();
            int horas=0;
            int presupuesto=0;

            Console.WriteLine("Ingrese el presupuesto para la construccion:");
            presupuesto = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad de horas para la construccion:");
            horas = Int32.Parse(Console.ReadLine());
            constructora.ContratistasMensajes(horas);
            Console.WriteLine(constructora.SePuedeLlevarACaboElProyecto(presupuesto));
        }
    }
}
