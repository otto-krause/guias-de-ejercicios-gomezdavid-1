using System;

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Ponystation4 ponystation = new Ponystation4(0);
            CajaX cajaX = new CajaX(0);
            PC pc = new PC(0);

            int menuConsola = 0;
            int opciones = 0;
            string nombreJuego;
            int horasDeJuego = 0;


            do
            {
                Console.WriteLine("Eliga el tipo de Consola:\n[1]Ponystation\n[2]PC\n[3]CajaX\n[0]Salir");

                menuConsola = Int32.Parse(Console.ReadLine());

                switch (menuConsola)
                {
                    case 1:

                        do
                        {
                            Console.WriteLine("[1]Ingresar juego\n[2]Jugar\n[3]Ver puntaje\n[0]Salir");

                            opciones = Int32.Parse(Console.ReadLine());

                            switch (opciones)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese el nombre del juego:\n");
                                    nombreJuego = Console.ReadLine();
                                    ponystation.Agregar(nombreJuego);
                                    break;
                                case 2:
                                    Console.WriteLine("Ingrese las horas de juego:\n");
                                    horasDeJuego = Int32.Parse(Console.ReadLine());
                                    ponystation.JugarJuego(horasDeJuego);
                                    break;
                                case 3:
                                    Console.WriteLine("El puntaje es: " + ponystation.RevisarPuntaje());
                                    break;
                                default:
                                    break;
                            }
                        }
                        while (opciones != 0);
                        break;
                    case 2:
                        do
                        {
                            Console.WriteLine("[1]Ingresar juego\n[2]Jugar\n[3]Ver puntaje\n[0]Salir");

                            opciones = Int32.Parse(Console.ReadLine());

                            switch (opciones)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese el nombre del juego:\n");
                                    nombreJuego = Console.ReadLine();
                                    pc.Agregar(nombreJuego);
                                    break;
                                case 2:
                                    Console.WriteLine("Ingrese las horas de juego:\n");
                                    horasDeJuego = Int32.Parse(Console.ReadLine());
                                    pc.JugarJuego(horasDeJuego);
                                    break;
                                case 3:
                                    Console.WriteLine("El puntaje es: " + pc.RevisarPuntaje());
                                    break;
                                default:
                                    break;
                            }
                        }
                        while (opciones != 0);
                        break;
                    case 3:
                        do
                        {
                            Console.WriteLine("[1]Ingresar juego\n[2]Jugar\n[3]Ver puntaje\n[0]Salir");

                            opciones = Int32.Parse(Console.ReadLine());

                            switch (opciones)
                            {
                                case 1:
                                    Console.WriteLine("Ingrese el nombre del juego:\n");
                                    nombreJuego = Console.ReadLine();
                                    cajaX.Agregar(nombreJuego);
                                    break;
                                case 2:
                                    Console.WriteLine("Ingrese las horas de juego:\n");
                                    horasDeJuego = Int32.Parse(Console.ReadLine());
                                    cajaX.JugarJuego(horasDeJuego);
                                    break;
                                case 3:
                                    Console.WriteLine("El puntaje es: " + cajaX.RevisarPuntaje());
                                    break;
                                default:
                                    break;
                            }
                        }
                        while (opciones != 0);
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Ingrese una opcion valida");
                        break;
                }
            }
            while (menuConsola != 0);

        }
    }
}
