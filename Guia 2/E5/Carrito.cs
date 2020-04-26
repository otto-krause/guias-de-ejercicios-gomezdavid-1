using System.Collections.Generic;
namespace E5
{
    public class Carrito
    {
        public List<Producto> productos = new List<Producto>();

        public Carrito()
        {
            productos.Add(new Producto("Jabon",30));
            productos.Add(new Producto("Oreos",50));
            productos.Add(new Producto("Shampoo",120));
            productos.Add(new Producto("Leche",45));
        }
    }
}