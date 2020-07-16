using System;

/*Crear la clase Matematicas2, la cual recibe listas de números enteros y devuelve:
Primos: devuelve solo los números que son primos.
Pares: devuelve solo los números que son pares.
Aplanar: muestra la lista sin repetidos.
Suma: devuelve la sumatoria de todos los números.
SumaDePrimos: devuelve la sumatoria de todos los números que son primos.
Máximo: devuelve el número más grande.
Minimo: Devuelve el número más chico.
*/

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
