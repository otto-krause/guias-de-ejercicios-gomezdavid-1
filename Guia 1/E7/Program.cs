using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Camaras frontal = new Camaras(15,8);
            Camaras trasera = new Camaras(40,6);
            Celular iPhoneX = new Celular(true,true,64,10);  

            int aux=0, cantidadDeFotos, resolucionMegapixeles;

            do
            {

                Console.WriteLine("MENU DE OPCIONES\nMEMORIA DISPONIBLE[1]\nTE CARGA LA SUBE[2]\nPESO TOTAL DE FOTOS[3]\nPESO TOTAL POR FOTO[5]\nINGRESE UNA OPCION:");
                
                aux = int.Parse(Console.ReadLine());

                switch(aux)
                {
                    case 1:
                        Console.WriteLine("Ingrese la cantidad de fotos y la resolucion en megapixeles:");
                        cantidadDeFotos = int.Parse(Console.ReadLine());
                        resolucionMegapixeles = int.Parse(Console.ReadLine());
                        iPhoneX.MemoriaDisponible(10,64,frontal,trasera,cantidadDeFotos,resolucionMegapixeles);
                        break;

                    case 2:
                        if(iPhoneX.TeCargaLaSube())
                        {
                            Console.WriteLine("Te carga la sube");
                        }
                        break;

                    case 3:
                        Console.WriteLine("Ingrese la cantidad de fotos y la resolucion en megapixeles:");
                        cantidadDeFotos = int.Parse(Console.ReadLine());
                        resolucionMegapixeles = int.Parse(Console.ReadLine());
                        frontal.PesoTotalDeFotos(cantidadDeFotos,resolucionMegapixeles);
                        break;

                    case 4:
                        Console.WriteLine("Ingrese la cantidad de fotos y la resolucion en megapixeles:");
                        cantidadDeFotos = int.Parse(Console.ReadLine());
                        resolucionMegapixeles = int.Parse(Console.ReadLine());
                        frontal.PesoPorFoto(cantidadDeFotos,resolucionMegapixeles);
                        break;

                }


            }
            while(aux != 0);

        }
    }
}
