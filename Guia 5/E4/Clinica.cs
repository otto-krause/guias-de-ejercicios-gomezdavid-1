using System.Linq;
using System.Collections.Generic;
namespace E4
{
    public class Clinica
    {
        List<Medico> listaMedicos = new List<Medico>();

        public Clinica()
        {
            Medico N1 = new Medico("Jorge","Perez","Traumatologia",49);
            listaMedicos.Add(N1);
            Medico N2 = new Medico("Carlos","Volgswagen","Neumonologia",55);
            listaMedicos.Add(N1);
            Medico N3 = new Medico("Hernesto","VillaGran","Dermatologia",2);
            listaMedicos.Add(N1);
        }

        public Medico BuscarMedico(string especialidad)
        {
            foreach (var medico in listaMedicos.Where(medico => medico.EsDeEsaEspecialidadYEstaDisponibble(especialidad)))
            {
                medico.AsignarTurno();
                return medico;
            }
            return null;
        }
    }
}