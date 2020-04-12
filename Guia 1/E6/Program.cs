using System;

namespace E6
{
    class Program
    {   
        static void Main(string[] args)
        {
            Matematica matematica = new Matematica();

            int aux=0,num=0,num1=0;

            do
            {
                Console.WriteLine("MENU DE OPCIONES:\nFibonacci[1]\nFactorial[2]\nMayor[3]\nMenor[4]\nCubo[5]\nSalir[0]");
                
                aux=int.Parse(Console.ReadLine());

                switch(aux)
                {
                    case 1:
                        Console.WriteLine("Ingrese un numero:");
                        num = int.Parse(Console.ReadLine());
                        matematica.Fibonacci(num);
                        break;

                    case 2:
                        Console.WriteLine("Ingrese un numero:");
                        num = int.Parse(Console.ReadLine());
                        matematica.Factorial(num);
                        break;


                    case 3:
                        Console.WriteLine("Ingrese dos numeros");
                        num=int.Parse(Console.ReadLine());
                        num1=int.Parse(Console.ReadLine());
                        matematica.Mayor(num,num1);
                        break;

                    case 4:
                        Console.WriteLine("Ingrese dos numeros:");
                        num=int.Parse(Console.ReadLine());
                        num1=int.Parse(Console.ReadLine());
                        matematica.Menor(num,num1);
                        break;

                    case 5:
                        Console.WriteLine("Ingrese un numero:");
                        num=int.Parse(Console.ReadLine());
                        matematica.Cubo(num);
                        break;
                }
            }
            while(aux != 0);
        }
    
    }
}
