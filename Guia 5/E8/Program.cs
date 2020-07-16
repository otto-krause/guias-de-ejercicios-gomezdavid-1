using System;

namespace E8
{
    class Program
    {
        static void Main(string[] args)
        {
            Matematicas2 m2 = new Matematicas2();
            int num=0;

            Console.WriteLine("Ingrese elementos a la lista de numeros:");
            num = Int32.Parse(Console.ReadLine());
            do
            {
                m2.ListaNumerosEnteros.Add(num);
                num = Int32.Parse(Console.ReadLine());
            }
            while(num!=0);

            Console.WriteLine();
            Console.WriteLine("Numeros primos:");
            foreach (var i in m2.NumerosPrimos())Console.WriteLine(i);

            Console.WriteLine();
            Console.WriteLine("Numeros Pares:");
            foreach (var i in m2.NumerosPares())Console.WriteLine(i);

            Console.WriteLine();
            Console.WriteLine("Lista de numeros sin repetir:");
            foreach (var i in m2.NumerosSinRepetir())Console.WriteLine(i);

            Console.WriteLine();
            Console.WriteLine("Suma de los numeros: "+m2.SumaDeLosNumeros());

            Console.WriteLine();
            Console.WriteLine("Maximo numero de la lista: "+m2.NumeroMaximo());

            Console.WriteLine();
            Console.WriteLine("Minimo numero de la lista: "+m2.NumeroMinimo());
            
        }
    }
}
