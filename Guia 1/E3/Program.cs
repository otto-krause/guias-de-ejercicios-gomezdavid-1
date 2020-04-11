using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
                
                int cont=0;

                Console.WriteLine("Ingrese un numero entero: \n");

                int num=Int32.Parse(Console.ReadLine());

                if(num%2==0){
                    Console.WriteLine("Es par");
                }else{
                    Console.WriteLine("Es impar");
                }

                for (int i = 1; i <= 9; i++)
                {
                    if(num%i==0)
                    {
                        cont+=1;
                    }
                }

                if(cont>=3){
                    Console.WriteLine("No es primo");
                }else{
                    Console.WriteLine("Es primo");
                }
                    
                

                
        }

    }
}
