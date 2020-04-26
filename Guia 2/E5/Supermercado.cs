using System.Collections.Generic;
namespace E5
{
    public class Supermercado
    {
        List<List<Producto>> carritos = new List<List<Producto>>();
        int acu=0;

        public Supermercado()
        {
            carritos=new List<List<Producto>>();
        }

        public int Ganancia()
        {
            foreach (List<Producto> subList in carritos)
            {
                foreach (var i in carritos)
                {
                    acu+=i.precio;
                }
            }
            return acu;
        }
    }
}