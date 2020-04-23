using System;
using System.Collections.Generic;
namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            int num=0,cont=0,cont2=0;

            Console.WriteLine("Ingrese numeros para la lista,para dejar de ingresar ingrese[0]");

            do
            {
                num=Int32.Parse(Console.ReadLine());
                numeros.Add(num);
            }
            while(num!=0);

            numeros.Remove(0);

            Console.WriteLine("La lista contiene los siguientes numeros:");

            foreach (int aux in numeros)
            {
                Console.WriteLine(aux);
                cont+=1;
                if(aux>50)cont2+=1;
            }
            //Lo que muestro en 4 lineas por consola se puede mostrar en una sola linea de codigo.
            Console.WriteLine("Numeros Ingresados: " + cont);
            Console.WriteLine("El primer numero ingresado: " + numeros[0]);
            Console.WriteLine("El ultimo numero ingresado: " + numeros[cont-1]);
            Console.WriteLine("Numeros Mayores a 50: " + cont2);
            
        
    }
}
}
