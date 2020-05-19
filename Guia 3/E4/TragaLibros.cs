using System.Collections.Generic;
namespace E4
{
    public class TragaLibros
    {
        List<Libro> listalibros = new List<Libro>();
        
        int cont=0;
        public TragaLibros()
        {

        }

        public void Leer(string titulo,string autor)
        {
            listalibros.Add(new Libro(titulo,autor));
            foreach (var i in listalibros)
            {
               // if(i.titulo==titulo)
              //      listalibros.Remove(i.titulo);
            }

        }

        public int CalcularCI()
        {
            foreach (var i in listalibros)
            {
                cont++;
            }
            
            return (5*cont);
        }
    }
}