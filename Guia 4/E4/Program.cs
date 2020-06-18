using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            int monto = 0;
            int nivel = 0;
            int menu = 0;
            int opciones = 0;
            RRHH rrhh = new RRHH(0);
            Programador programador = new Programador(0);
            Administrativo administrativo = new Administrativo(0);


            do
            {
                Console.WriteLine("Elija el tipo de empleado\n[1]RRHH\n[2]Programador\n[3]Administrativo\n[0]Salir");
                menu = Int32.Parse(Console.ReadLine());
                switch (menu)
                {
                    case 1:
                        Console.WriteLine("[1]Depositar\n[2]Extraer\n[3]Ver Caja Bancaria\n[0]Salir");
                        do
                        {
                            opciones = Int32.Parse(Console.ReadLine());
                            switch (opciones)
                            {

                                case 1:
                                    Console.WriteLine("Ingrese monto a depositar:");
                                    monto = Int32.Parse(Console.ReadLine());
                                    rrhh.Depositar(monto, nivel);
                                    break;
                                case 2:
                                    Console.WriteLine("Ingrese monto a extraer");
                                    monto = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine(rrhh.Extraer(monto));
                                    break;
                                case 3:
                                    Console.WriteLine("Usted posee " + rrhh.ConsultarCajaBancaria() + "En su Caja Bancaria");
                                    break;
                            }
                        }
                        while (opciones != 0);
                        break;

                    case 2:
                        Console.WriteLine("[1]Depositar\n[2]Extraer\n[3]Ver Caja Bancaria\n[0]Salir");
                        do
                        {
                            opciones = Int32.Parse(Console.ReadLine());
                            switch (opciones)
                            {

                                case 1:
                                    Console.WriteLine("Ingrese monto a depositar y nivel de programador:[1] Junior [2]SemiSenior [3]Senior");
                                    monto = Int32.Parse(Console.ReadLine());
                                    nivel = Int32.Parse(Console.ReadLine());
                                    programador.Depositar(monto, nivel);
                                    break;
                                case 2:
                                    Console.WriteLine("Ingrese monto a extraer");
                                    monto = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine(programador.Extraer(monto));
                                    break;
                                case 3:
                                    Console.WriteLine("Usted posee " + programador.ConsultarCajaBancaria() + "En su Caja Bancaria");
                                    break;
                            }
                        }
                        while (opciones != 0);
                        break;
                     case 3:
                         Console.WriteLine("[1]Depositar\n[2]Extraer\n[3]Ver Caja Bancaria\n[0]Salir");
                        do
                        {
                            opciones = Int32.Parse(Console.ReadLine());
                            switch (opciones)
                            {

                                case 1:
                                    Console.WriteLine("Ingrese monto a depositar:");
                                    monto = Int32.Parse(Console.ReadLine());
                                    administrativo.Depositar(monto, nivel);
                                    break;
                                case 2:
                                    Console.WriteLine("Ingrese monto a extraer");
                                    monto = Int32.Parse(Console.ReadLine());
                                    Console.WriteLine(administrativo.Extraer(monto));
                                    break;
                                case 3:
                                    Console.WriteLine("Usted posee " + administrativo.ConsultarCajaBancaria() + "En su Caja Bancaria");
                                    break;
                            }
                        }
                        while (opciones != 0);
                         break;
                }
            }
            while (menu != 0);


        }
    }
}
