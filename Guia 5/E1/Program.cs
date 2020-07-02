using System;
using System.Collections.Generic;
using System.Linq;

namespace E1
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persona> listaPersonas = new List<Persona>{new Persona("Enzo","Perez",28),new Persona("Martin","Perez Di Salvo",17),new Persona("Juan","Lopez",28)};

            Console.WriteLine("\n");
            Console.WriteLine("Personas Mayores de Edad (+18)");

            listaPersonas.Where(persona => persona.Edad >= 18)
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre+ " "+ persona.Apellido+" "+persona.Edad));

            Console.WriteLine("\n");
            Console.WriteLine("Personas que se llaman 'Juan'");

            listaPersonas.Where(persona => persona.Nombre == "Juan" )
            .ToList()
            .ForEach(persona => Console.WriteLine(persona.Nombre + " " + persona.Apellido + " " + persona.Edad));
            
            Console.WriteLine("\n");
            Console.WriteLine("¿Cuantas personas que se apellidan 'Perez' hay?");
            int personasQueSeApellidanPerez = listaPersonas.Count(persona => persona.Apellido == "Perez");
            Console.WriteLine(personasQueSeApellidanPerez);
           
        }
    }
}
