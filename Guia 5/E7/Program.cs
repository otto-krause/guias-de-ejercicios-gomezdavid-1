using System.Linq;
using System;

namespace E7
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            Persona p2 = new Persona();

            Console.WriteLine("Ver las fotos del ultimo año de una persona:"); 
            int mayorAnio=p1.ListaPublicacionesP1.Max(x => x.Foto.Anio); 
            foreach (var i in p1.ListaPublicacionesP1.Where(x => x.Foto.Anio == mayorAnio))Console.WriteLine(i.Texto+" "+i.Foto.FechaDeCreacionDiaYMes+" "+i.Foto.Anio+" "+i.Foto.PersonasEtiquetdas+" "+i.Foto.DirectorioDeAlmacenamiento);
           
            Console.WriteLine("Dadas dos personas ver las fotos en las que ambos estan etiquetados");
            foreach (var i in p1.ListaPublicacionesP1.Join(p2.ListaPublicacionesP2, x => x.Foto.PersonasEtiquetdas, j => j.Foto.PersonasEtiquetdas,(x,j) => x))Console.WriteLine(i.Texto);
            //pensar en hacer clase 'amigo'

            Console.WriteLine("Ver todas las publicaciones que tengan mas de 300 caracteres:");
            foreach (var i in p1.ListaPublicacionesP1.Where(x => x.Texto.Length>300))Console.WriteLine(i.Texto+" "+i.Foto.FechaDeCreacionDiaYMes+" "+i.Foto.Anio+" "+i.Foto.PersonasEtiquetdas+" "+i.Foto.DirectorioDeAlmacenamiento);
        }
    }
}
