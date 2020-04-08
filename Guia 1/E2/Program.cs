using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0, multiplicacion=0,resto=0,cont=0;

            Console.WriteLine("Ingrese dos numeros:");
            
            a=Int32.Parse(Console.ReadLine());
            
            b=Int32.Parse(Console.ReadLine());

            for (int i = 0; i < b; i++)
            {
                multiplicacion=multiplicacion+a;
            }

            Console.WriteLine("\nEl resultado de la multiplicacion es: " + multiplicacion);

            while( a >= 0)
            {
                a=a-b;
                if(a>=0)
                {
                  cont+=1;  
                }else{
                    resto=a+b;
                } 
            }

            Console.WriteLine("El cociente es: " + cont);
            Console.WriteLine("El resto es: " + resto);
        }
    }
}
