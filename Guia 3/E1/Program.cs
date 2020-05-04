using System;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {

            Homero homero = new Homero();
            Lenny lenny = new Lenny();
            MrBurns burns = new MrBurns();
            PatoBalancin pato = new PatoBalancin();
            PlantaDeEnergia planta = new PlantaDeEnergia(burns, homero, 10001);

            string opcion = "";
            Console.WriteLine("[1]Ver si la planta esta en peligro\n" +
                "[2]Homero come dona\n" +
                "[3]Homero compra donas\n" +
                "[4]Lenny toma cerveza\n" +
                "[5]Cambiar empleado por Homero\n" +
                "[6]Cambiar empleado por Lenny\n" +
                "[7]Cambiar empleado por el Pato\n" +
                "[8]Despojar a burns de sus riquezas");

            do
            {
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine(planta.estaEnPeligro());
                        break;
                    case "2":
                        homero.Comer();
                        break;
                    case "3":
                        homero.Comprar();
                        break;
                    case "4":
                        lenny.tomarCerveza();
                        break;
                    case "5":
                        planta.CambiarEmpleado(homero);
                        break;
                    case "6":
                        planta.CambiarEmpleado(lenny);
                        break;
                    case "7":
                        planta.CambiarEmpleado(pato);
                        break;
                    case "8":
                        burns.despojarRiqueza();
                        break;
                    default:
                        opcion = "salir";
                        break;
                }
            }
            while (opcion != "salir");
        }
    }
}
