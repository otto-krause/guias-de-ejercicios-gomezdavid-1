using System;

namespace E2
{
    class Program
    {
        static void Main(string[] args)
        {
            MonstersInc empresa = new MonstersInc();
            int menu=0;
            

            Console.WriteLine("[1]Noche De Sustos\n[2]Noche de Risas\n[3]Ver Monstruos Respetables\n"+
            "[4]Ver Energia de la Empresa\n[0]Salir");

            do
            {
                menu = Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                         empresa.NocheDeSustos();
                         break;
                    case 2:
                         empresa.NocheDeRisas();
                         break;
                    case 3:
                         empresa.listarMonstruosRespetables();
                         break;
                    case 4:
                         empresa.EnergiaEmpresa();
                         break;
                    case 0:
                         break;
                    default:
                         Console.WriteLine("Ingrese una opcion valida");
                         break;
                }
            }
            while(menu!=0);
        }
    }
}
