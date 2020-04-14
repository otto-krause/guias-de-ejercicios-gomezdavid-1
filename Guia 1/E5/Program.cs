using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangulo triangulo = new Triangulo(2,2,2);

            int a=0,b=0,c=0,aux=0;

            Console.WriteLine("Ingrese los tres lados del triangulo:");
            a=Int32.Parse(Console.ReadLine());
            b=Int32.Parse(Console.ReadLine());
            c=Int32.Parse(Console.ReadLine());

            do
            {
                Console.WriteLine("MENU DE OPCIONES\nISOSCELES[1]\nESCALENO[2]\nEQUILATERO[3]\nTRIANGULO RECTANGULO[4]\nINGRESE UNA OPCION");
                aux = int.Parse(Console.ReadLine());

                switch(aux)
                {
                    case 1:
                        triangulo.EsIsosceles(a,b,c);
                        break;

                    case 2:
                        triangulo.EsEscaleno(a,b,c);
                        break;

                    case 3:
                        triangulo.EsEquilatero(a,b,c);
                        break;

                    case 4:
                        triangulo.EsTrianguloRectangulo(a,b,c);
                        break;

                }

            }
            while(aux != 0);


        }
    }
}
