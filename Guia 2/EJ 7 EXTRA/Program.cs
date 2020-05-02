using System;

namespace EJ_7_EXTRA
{
    class Program
    {
        static void Main(string[] args)
        {
            Argentina argentina = new Argentina();
            int menu=0;
            
            Console.WriteLine("[1]Bajar el precio del petroleo\n[2]Habla Millai por TV\n[3]CoronaVairas\n[4]Estado De la Inflacion\n[5]¿Esta Argentina en Default?\n[0]Salir");
            do
            {
                menu = Int32.Parse(Console.ReadLine());

                switch(menu)
                {
                    case 1:
                        argentina.BajarElPrecioDelPetroleo();
                        break;
                    case 2:
                        argentina.MillaiHablaPorTv();
                        break;
                    case 3:
                        argentina.CoronaVairas();
                        break;
                    case 4:
                        Console.WriteLine("" + argentina.EstadoDeLaInflacion());
                        break;
                    case 5:
                        Console.WriteLine("" + argentina.ArgentinaDefault());
                        break;
                }
            }
            while(menu!=0);

        }
    }
}
