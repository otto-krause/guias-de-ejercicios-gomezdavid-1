using System;
/*Crear un programa que le permita al usuario ingresar tantos números como desee hasta que ingrese un 0,
lo que se considerará como la finalización del ingreso. Estos números deben ser almacenados en una lista.

En base al programa anterior, realizar los siguientes ejercicios:

Mostrar por pantalla todos los números.
Mostrar cuántos números impares fueron ingresados.
Mostrar cúal fue el primer número par.
Mostrar los números que son mayores a 50.
Mostrar cuántos números son mayores a 50.
*/
namespace E9
{
    class Program
    {
        static void Main(string[] args)
        {
            Numeros n = new Numeros();
            int num=0;

            Console.WriteLine("Ingrese numeros a la lista:");
            num = Int32.Parse(Console.ReadLine());
            do
            {
                n.ListaNumero.Add(num);
                num = Int32.Parse(Console.ReadLine());
            }
            while(num!=0);

            Console.WriteLine();
            Console.WriteLine("Numeros de la lista:");
            n.ListaNumero.ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            Console.WriteLine("Cantidad de numeros impares: "+n.CuantosNumerosImparesHay());

            Console.WriteLine();
            Console.WriteLine("Primer numero Par: "+n.PrimerNumeroPar());

            Console.WriteLine();
            Console.WriteLine("Numeros mayores que 50");
            n.NumerosMayoresA50().ForEach(x => Console.WriteLine(x));

            Console.WriteLine();
            Console.WriteLine("Cantidad de numeros mayores a 50: "+n.CuantosSonMayoresA50());
        }
    }
}
