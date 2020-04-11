using System;

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
        
            Gatito manchis = new Gatito("manchis",true,30);

            int aux=0;

            do
            {
                Console.WriteLine("MENU DE OPCIONES:\nNombre del gatito[1]\nSalud[2]\nVacunas[3]\nJugar[4]\nComer[5]\nSalir[0]\nIngrese una opcion\n");

                aux = Int32.Parse(Console.ReadLine());

                switch(aux)
                {
                    case 1:
                         Console.WriteLine("EL nombre del gatito es: " + manchis.Nombre());
                         break;
                    
                    case 2:
                         Console.WriteLine("El gatito esta saludable? " + manchis.estaSaludable());
                         break;

                    case 3:
                         Console.WriteLine("El gatito esta vacunado?" + manchis.estaVacunado());
                         break;

                    case 4:
                         Console.WriteLine("Ingrese cuanto tiempo jugara el gatito: ");
                         int tiempo=Int32.Parse(Console.ReadLine());
                         Console.WriteLine("energia restante: " + manchis.Jugar(tiempo));
                         break;

                    case 5:
                         Console.WriteLine("El gatito ha comido\n");
                         Console.WriteLine("Energia restante: " + manchis.Comer());
                         break;



                }
            }
            while(aux !=0 );     

        }
    }
}
