using System.Collections.Generic;
using System.Linq;

namespace E8
{
    public class Matematicas2
    {
        private List<int> listaNumerosEnteros;

        public Matematicas2()
        {
            listaNumerosEnteros = new List<int>();
        }

        public List<int> NumerosPrimos()
        {
            return (listaNumerosEnteros.Where(i => VerificarSiEsPrimo(i))).ToList();
        }

        public List<int> NumerosPares()
        {
            List<int> listaNumerosPares = new List<int>();
            return(listaNumerosEnteros.Where(i => (i%2==0))).ToList();
        }

        public List<int> NumerosSinRepetir()
        {
            List<int> listaNumerosSinRepetir = new List<int>();
            listaNumerosEnteros.ForEach(x => listaNumerosSinRepetir.Add(x));
            return listaNumerosSinRepetir = listaNumerosSinRepetir.Distinct().ToList();
        }

        public int SumaDeLosNumeros()
        {
            int suma=0;
            return suma = listaNumerosEnteros.Sum();
        }

        public int NumeroMaximo()
        {
            int max=0;
            return max = listaNumerosEnteros.Max();
        }

        public int NumeroMinimo()
        {
            int min=0;
            return min = listaNumerosEnteros.Min();
        }

        private bool VerificarSiEsPrimo(int numero)
        {
            int divisor = 2;
            int resto = 0;
            while (divisor < numero)
            {
                resto = numero % divisor;
                if (resto == 0) return false;
                divisor++;
            }
            return true;
        }

        public List<int> ListaNumerosEnteros { get => listaNumerosEnteros; set => listaNumerosEnteros = value; }
    }
}