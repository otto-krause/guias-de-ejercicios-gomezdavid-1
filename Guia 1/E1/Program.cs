using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector = new int[10];

            float suma = 0;

            int aux = 0; 

            Console.WriteLine("Ingrese diez numeros: \n");

            for (int i = 0; i < 10; i++)
            {
                vector[i] = Int32.Parse(Console.ReadLine());

                suma += vector[i];
            }
            
            for (int I = 0; I < (10-1); I++)
	        {
		        for (int J = I+1; J < 10; J++)
		        {
			        if (vector[I]>vector[J])
			        {
				        aux=vector[I];
				        vector[I]=vector[J];
				        vector[J]=aux;
			        }
		        }
	        }       

            Console.WriteLine("\nLa suma de los numeros ingresados es: " + suma);
            Console.WriteLine("\nEl promedio de los numeros ingresados es: " + suma/10);
            Console.WriteLine("\nEL menor numero ingresado es: {0}",vector[0]); 
            Console.WriteLine("\nVector Ordenado de Mayor a menor: ");

            for (int K = 9; K >= 0; K--)
            {
                Console.WriteLine("{0}",vector[K]);
            }   


        }
    }
}
