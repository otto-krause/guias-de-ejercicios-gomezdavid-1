using System.Collections.Generic;
namespace E5
{
    public class Persona
    {
        private List<string> conocimientos;

        public Persona()
        {
            conocimientos = new List<string>();
            conocimientos.Add("Alquimia");
            conocimientos.Add("Actuacion");
            conocimientos.Add("Mecanica");
            conocimientos.Add("Fisica");
            conocimientos.Add("Quimica");
            conocimientos.Add("Abogacia");
            conocimientos.Add("Historia");
        }

        public List<string> Conocimientos { get => conocimientos; set => conocimientos = value; }
    }
}