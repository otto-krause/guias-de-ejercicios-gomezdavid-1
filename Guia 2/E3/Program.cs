using System;

/*3) Hacer un programa en el que se represente un album de figuritas del mundial.
En cada figurita aparece el nombre del jugador, su posición, país y el número de figurita.
Crearemos también la clase Album que contiene una lista con las figuritas que ya se agregaron.
Se pide:
A)Agregar una figurita al álbum: para esto el usuario ingresará los datos de la figurita por pantalla,
y el abum controlará que esa figurita no haya sido ingresada previamente.
B)Mostrar CuantosDelanteros hay. 
C)Mostrar CuantosMediocampostas hay.
D)Decirle al usuario si el album EstaCompleto, para ello sabemos que en el álbum hay 32 equipos con 11 jugadores cada uno.

Nota: Pensar para los puntos B y C una forma de no repetir código.
*/

namespace E3
{
    class Program
    {
        static void Main(string[] args)
        {
            Album mundial2014 = new Album();

            string nombre, posicion, pais;
            int numFigurita;

            Console.WriteLine("Album Figuritas Mundial 2014");
            Console.WriteLine("Ingresar nombre del jugador: ");
            nombre=Console.ReadLine();
            Console.WriteLine("Ingrese la posicion: ");
            posicion=Console.ReadLine();
            Console.WriteLine("Ingrese el pais: ");
            pais=Console.ReadLine();
            Console.WriteLine("Ingrese el numero de Figurita: ");
            numFigurita=Int32.Parse(Console.ReadLine());
            mundial2014.AgregarFigurita(nombre,posicion,pais,numFigurita);
            mundial2014.CantidadDeDelanterosYMedioCampistas(posicion);
            mundial2014.EstaCompleto();
        }
    }
}
