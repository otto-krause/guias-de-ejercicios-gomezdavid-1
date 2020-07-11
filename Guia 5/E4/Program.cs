using System;

/*Crear la clase Medico que tiene los atributos nombre, apellido, especialidad y cantidad de turnos.
Sabemos que un médico EstaDisponible cuando tiene menos de 50 turnos asignados.
Crear la clase Clinica, que deberá tener una lista de médicos ya cargada.

El programa deberá poder asignar turnos a los pacientes,
para ello el usuario ingresara la especialidad deseada y el programa le dirá si hay algún médico disponible,
en caso positivo le dirá el nombre del médico que lo atenderá,
en caso negativo se le dirá que lo intente de nuevo más tarde.
*/

namespace E4
{
    class Program
    {
        static void Main(string[] args)
        {
            Clinica clinica = new Clinica();
            Console.WriteLine("Ingrese especialidad: ");
            string especialidad = Console.ReadLine();
            while (especialidad != "salir")
            {
                Medico medico = clinica.BuscarMedico(especialidad);
                if (medico != null)
                    Console.WriteLine("Se encontro el medico el/la medico/a " + medico.Nombre);
                else
                    Console.WriteLine("No se encontro turno disponible");
                Console.WriteLine("Ingrese especialidad: ");
                especialidad = Console.ReadLine();
            }
        }
    }
}
