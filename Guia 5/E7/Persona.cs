using System.Collections.Generic;
namespace E7
{
    public class Persona
    {
        private List<Publicacion> listaPublicacionesP1;
        private List<Publicacion> listaPublicacionesP2;

        public Persona()
        {
            listaPublicacionesP1 = new List<Publicacion>();
            listaPublicacionesP2 = new List<Publicacion>();
            listaPublicacionesP1.Add(new Publicacion("Con amigos de anoche", new Foto("C:/Users/David/Desktop/Fotos-Con-Amigos/>" , "14/3",2020, "Jorge, Luis, David, Pepe, Carlos")));
            listaPublicacionesP1.Add(new Publicacion("Con el que no abandona:p", new Foto("C:/Users/David/Desktop/Fotos-Con-Amigos/>" , "02/12",2003, "David, Pepe")));
            listaPublicacionesP2.Add(new Publicacion("Con el amigoo", new Foto("C:/Users/Pepe/Desktop/Fotos/>" , "02/12",2003, "David, Pepe")));
        }

        public List<Publicacion> ListaPublicacionesP1 { get => listaPublicacionesP1;}
        public List<Publicacion> ListaPublicacionesP2 { get => listaPublicacionesP2;}
    }
}