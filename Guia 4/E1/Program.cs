using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            Perro toby = new Perro(0);
            Pajaro Caniggia = new Pajaro(0);
            int menu = 0;

            Console.WriteLine("[1]Perro Come\n[2]Perro Juega\n[3]Perro Duerme\n[4]Gato Come\n[5]Gato Juega\n[6]Gato Duerme\n[0]Salir");
            
            do
            {
                menu = Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("El perro ha ganado +15 de energia al Comer\nEnergia Actual:");
                        Console.WriteLine(toby.Comer());
                        break;
                    case 2:
                        Console.WriteLine("El perro ha perdido -20 de energia al Jugar\nEnergia Actual:");
                        Console.WriteLine(toby.Jugar());
                        break;
                    case 3:
                        Console.WriteLine("Cada vez que el perro Duerme recupera +50 de energia\nEnergia Actual:");
                        Console.WriteLine(toby.Dormir());
                        break;
                    case 4:
                        Console.WriteLine("El pajaro ha ganado +10 de energia al Comer\nEnergia Actual:");
                        Console.WriteLine(Caniggia.Comer());
                        break;
                    case 5:
                        Console.WriteLine("El pajaro ha perdido -5 de energia al Jugar\nEnergia Actual:");
                        Console.WriteLine(Caniggia.Jugar());
                        break;
                    case 6:
                        Console.WriteLine("Cada vez que el pajaro Duerme recupera +50 de energia\nEnergia Actual:");
                        Console.WriteLine(Caniggia.Dormir());
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            }
            while (menu != 0);
        }
    }
}
