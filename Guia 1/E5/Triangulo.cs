using System;

namespace E5
{
    public class Triangulo
    {
        int a=0,b=0,c=0;

        public Triangulo(int a, int b, int c)
        {
            this.a=a;
            this.b=b;
            this.c=c;
        }

        public void  EsIsosceles (int a, int b, int c)
        {
            if(a==b&&a!=c)
            {
                Console.WriteLine("Verdadero");
            }
            else
            {
                if(a==c&&a!=b)
                {
                    Console.WriteLine("Verdadero");
                }
                else
                {
                    if(b==c&&b!=a)
                    {
                        Console.WriteLine("Verdadero");
                    }
                    else
                    {
                        Console.WriteLine("Falso");
                    }
                }
            }
        }

        public void EsEscaleno(int a, int b, int c)
        {
            if(a!=b&&a!=c)
            {
                if(b!=c)
                {
                    Console.WriteLine("Verdadero");
                }
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }

        public void EsEquilatero(int a, int b, int c)
        {
            if(a==b&&a==c)
            {
                Console.WriteLine("Verdadero");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }

        public void EsTrianguloRectangulo(int a, int b, int c)
        {
            double exp1=0,exp2=0,auxsuma,raizcuadrada=0,raizcuadrada2=0;

            
            exp1=Math.Pow(a,2);
            exp2=Math.Pow(b,2);

            auxsuma=exp1+exp2;

            raizcuadrada=Math.Sqrt(auxsuma);

            raizcuadrada2=Math.Sqrt(Math.Pow(c,2)-Math.Pow(a,2));

            if(c==raizcuadrada&&exp1==raizcuadrada2)
            {
                Console.WriteLine("Verdadero");
            }
            else
            {
                Console.WriteLine("Falso");
            }
        }


    }
}