using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroes heroe = new Heroes(new QuirckNormal(5,"Hell Flame",false),0,0,true,false);

            //Pregunta:
                //Cuales son las lineas de codigo se deberian ejecutar para saber si el quirk es peligroso?
            
            //Respuesta:
                Console.WriteLine(heroe.Quirk.EsPeligroso());
        }
    }
}
