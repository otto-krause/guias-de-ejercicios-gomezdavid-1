using System.Collections.Generic;
using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            TragaLibros tragalibros = new TragaLibros();

            int aux=0;
            string titulo="";
            string autor="";

            
            do
            {
                Console.WriteLine("Ingrese que desea hacer\n[1]Agregar un libro leido\n[2]Calcular CI\n[0]Salir");
                aux=Int32.Parse(Console.ReadLine());

                switch(aux)
                {
                    case 1:
                        Console.WriteLine("Ingrese el titulo y luego el autor");
                        titulo=Console.ReadLine();
                        autor=Console.ReadLine();
                        tragalibros.Leer(titulo,autor);
                        break;
                    
                    case 2:
                        Console.WriteLine(tragalibros.CalcularCI());
                        break;
                }
                
            }
            while(aux!=0);
        }
    }
}
