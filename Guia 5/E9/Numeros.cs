using System.Linq;
using System.Collections.Generic;
namespace E9
{
    public class Numeros
    {
        List<int> listaNumero;

        public Numeros()
        {
            listaNumero = new List<int>();
        }

        public int CuantosNumerosImparesHay()
        {
            int cont=0;
            return cont = listaNumero.Where(x => x%2!=0).Count();
        }

        public int PrimerNumeroPar()
        {
            int numPar;
            return numPar = listaNumero.Where(x => (x%2==0)).First();
        }

        public List<int> NumerosMayoresA50()
        {
            List<int> numerosMayoresA50 = new List<int>();
            return numerosMayoresA50 = listaNumero.Where(x => x>50).ToList();
        }

        public int CuantosSonMayoresA50()
        {
            int cont=0;
            return cont = listaNumero.Where(x => x>50).Count();
        }

        public List<int> ListaNumero { get => listaNumero; set => listaNumero = value; }
    }
}