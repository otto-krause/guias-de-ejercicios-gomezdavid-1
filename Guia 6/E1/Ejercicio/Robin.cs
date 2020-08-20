using System.Collections.Generic;
using System.Linq;

namespace Ejercicio
{
    public class Robin : Titan
    {
        List<Arma> arsenal;
        private int porcionesDePizza;

        public List<Arma> Arsenal { get => arsenal; set => arsenal = value; }
        public int PorcionesDePizza { get => porcionesDePizza; set => porcionesDePizza = value; }

        public Robin(List<Arma> arsenal, int tristeza) : base(tristeza)
        {
            this.arsenal = arsenal;
            this.porcionesDePizza = 0;
        }

        public override void ComerPizza()
        {
            tristeza -= porcionesDePizza;
        }

        public override void LlorarPorRobocop()
        {
            tristeza += 6;
        }

        public override bool EstaTriste()
        {
            Arma armaMasFuerte = arsenal.OrderByDescending(arma => arma.Fuerza()).First();
            return armaMasFuerte.Fuerza() < 100 && tristeza > 25;
        }

        public override int Poder()
        {
            Arma arma = arsenal.OrderByDescending(arma => arma.Fuerza()).First();
            return arma.Fuerza() - tristeza;
        }
    }

}