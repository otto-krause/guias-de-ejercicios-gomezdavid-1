using System.Linq;
using System.Collections.Generic;
namespace E10
{
    public class Colegio
    {
        private List<ExAlumnos> listaAlumnos;

        public Colegio()
        {
            listaAlumnos = new List<ExAlumnos>();
            listaAlumnos.Add(new ExAlumnos(2,200001,5));
            listaAlumnos.Add(new ExAlumnos(6,200001,5));
            listaAlumnos.Add(new ExAlumnos(2,200001,5));
            listaAlumnos.Add(new ExAlumnos(3,200001,5));
            listaAlumnos.Add(new ExAlumnos(2,200001,0));
            listaAlumnos.Add(new ExAlumnos(2,200001,0));
        }

        public List<ExAlumnos> ListaAlumnos { get => listaAlumnos; set => listaAlumnos = value; }

        public int Poliglotas()
        {
            int cantPoli=0;
            return cantPoli = (listaAlumnos.Where(i => i.CantidadDeIdiomasAprendidos > 5)).Count();
        }

        public int Exitosos()
        {
            int cantExitosos=0;
            return cantExitosos = (ListaAlumnos.Where(x => x.Sueldo>200000)).Count();
        }

        public bool Bilingues()
        {
            int cantAlumnos=0;
            int cantAlumnosBilingues=0;
            cantAlumnos = listaAlumnos.Count;
            cantAlumnosBilingues += (listaAlumnos.Where(i => i.CantidadDeIdiomasAprendidos >= 2)).Count();
            return (cantAlumnosBilingues==cantAlumnos);
        }

        public int Viajeros()
        {
            int cantViajeros=0;
            return cantViajeros = listaAlumnos.Where(x => x.CantidadDePaisesVisitados>4).Count();
        }

        public bool CursoExitoso()
        {
            return (Exitosos()>5&&Viajeros()>3&&Bilingues()&&Poliglotas()>=1);
        }

    }
}