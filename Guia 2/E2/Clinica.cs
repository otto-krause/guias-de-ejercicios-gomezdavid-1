using System;
using System.Collections.Generic;
namespace E2
{
    public class Clinica
    {
        List<Medico> medicos = new List<Medico>(); 
        public Clinica()
        {
            medicos.Add(new Medico("Ana","Castiñeira","Neumonologia",40));
            medicos.Add(new Medico("Guido","Kaczka","Traumatologia",21));
            medicos.Add(new Medico("Susana","Gimenez","Cardiologia",55));
            medicos.Add(new Medico("Alejandro","Wiebe","Gastroenterologia",51));
            medicos.Add(new Medico("Luisana","Lopilato","Otorrinolaringologia",31));
            medicos.Add(new Medico("Julian","Weich","Pediatria",2));
            medicos.Add(new Medico("Diego","Roriguez","Ginecologia",100));
        }

        public string AsignarTurno(string especialidad)
        {
            foreach (var aux in medicos)
            {
                if(aux.especialidad==especialidad)
                {
                    if(aux.cantidadDeTurnos<50)
                    {
                        Console.WriteLine("El medico " + aux.nombre + " Esta Disponible");
                    }
                }
            }

            return ("Intente de nuevo mas tarde");
        }
    }
}