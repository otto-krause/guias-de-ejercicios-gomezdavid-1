using System.Collections.Generic;
namespace Ejercicio
{
    public class Traje
    {
        private int resistencia;
        private List<Arma> listaDeArmas;

        public Traje(int resistencia, List<Arma> listaDeArmas)
        {
            this.resistencia = resistencia;
            this.listaDeArmas = listaDeArmas;
        }

        public int Resistencia { get => resistencia; }
        public List<Arma> ListaDeArmas { get => listaDeArmas; }
    }
}