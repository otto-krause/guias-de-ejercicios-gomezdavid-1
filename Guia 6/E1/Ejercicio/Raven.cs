using System.Collections.Generic;
using System.Linq;
namespace Ejercicio
{
    public class Raven : Titan
    {
        List<string> pensamientos;
        private int felicidad;
        private int porcionesDePizza;

        public List<string> Pensamientos { get => pensamientos; set => pensamientos = value; }
        public int Felicidad { get => felicidad; set => felicidad = value; }
        public int PorcionesDePizza { get => porcionesDePizza; set => porcionesDePizza = value; }

        public Raven(List<string> pensamientos, int felicidad, int porcionesDePizza, int tristeza) : base(tristeza)
        {
            this.pensamientos = new List<string>();
            this.felicidad = felicidad;
            this.porcionesDePizza = porcionesDePizza;

        }

        public override void ComerPizza()
        {
            felicidad += 2 * porcionesDePizza;
        }

        public override bool EstaTriste()
        {
            return Poder() >= 5 && felicidad == 10;
        }

        public override int Poder()
        {
            int cantidadDePensamientosNegativos = 0;
            return cantidadDePensamientosNegativos = pensamientos.Where(x => x.EndsWith("Papi") || x.EndsWith("perrito") || x.EndsWith("Robocop") || x.Contains("Pipo") || x.EndsWith("MANTECA")).Count();

        }

        public override void LlorarPorRobocop()
        {
            pensamientos.RemoveAt(0);
        }
    }
}