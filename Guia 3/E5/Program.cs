using System;

namespace E5
{
    class Program
    {
        static void Main(string[] args)
        {
            ShadowArmor shadowarmor = new ShadowArmor();
            MegamanX x = new MegamanX();
            Armadura armadura = new FalconArmor();
            int menu = 0;

            do
            {
                Console.WriteLine("\n");
                Console.WriteLine("/////Megaman\\\\ X\n[1]Conocer Fuerza\n[2]X Entrena\n[3]Cambia armadura a Shadow Armor\n");
                Console.WriteLine("////Armadura\\\\\n[4]Bonificacion de Daño\n[5]Entrenar con la Armadura\n[0]Salir");
                menu = Int32.Parse(Console.ReadLine());

                switch(menu)
                {
                    case 1:
                        Console.WriteLine(x.Fuerza());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese los minutos de entrenamiento:");
                        int minutos=Int32.Parse(Console.ReadLine());
                        x.Entrenar(minutos);
                        break;
                    case 3:
                        x.CambiarArmadura(shadowarmor);
                        break;
                    case 4:
                        Console.WriteLine(armadura.BonificacionDeDaño());
                        break;
                    case 5:
                        Console.WriteLine("Ingrese los minutos de entrenamiento con la Armadura:");
                        minutos = Int32.Parse(Console.ReadLine());
                        armadura.Entrenamiento(minutos);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Opcion no valida, por favor ingrese de nuevo");
                        break;
                }
            }
            while (menu != 0);
        }
    }
}
