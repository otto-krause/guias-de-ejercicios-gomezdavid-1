namespace E1
{
    public class Homero : Empleado
    {
        private int donas;

        public Homero()
        {
            this.donas = 0;
        }

        public bool estaDistraido()
        {
            return donas<2;
        }

        public void Comer()
        {
            donas--;
        }

        public void Comprar()
        {
            donas+=12;
        }
    }
}