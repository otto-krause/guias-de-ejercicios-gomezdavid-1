using System;

namespace E6
{
    public class Matematica
    {
        
    public void Fibonacci(int num)
        {
            int i = 0;
            int fibo = 0;
            int fibo1 = 1;



            while (i < num)
            {


                fibo += fibo1;
                Console.WriteLine(fibo);

                if(fibo + fibo1 > num)
                {
                    break;
                }

                fibo1 += fibo;
                Console.WriteLine(fibo1);

                if(fibo + fibo1 > num)
                {
                    break;
                }
            }
        }

        public void Factorial(int num)
        {
            int fact=1;

            for (int i = 1; i <= num; i++)
            {
                fact=fact*i;
            }

            Console.WriteLine(fact);
        }

        public void Mayor(int num, int num1)
        {
            if(num>num1)
            {
                Console.WriteLine(num);
            }
            else
            {
                if(num1>num)
                {
                    Console.WriteLine(num1);
                }
                else
                {
                    Console.WriteLine("Los numeros son iguales");
                }
            }
        }

        public void Menor(int num,int num1)
        {
            if(num1<num)
            {
                Console.WriteLine(num1);
            }
            else
            {
                if(num<num1)
                {
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Son iguales");
                }
            }
        }

        public void Cubo (int num)
        {
            int cubo=num;

            for (int i = 0; i < 2; i++)
            {
                cubo=cubo*num;
            }

            Console.WriteLine(cubo);
        }

    }
}