using System.Collections.Generic;
namespace E2
{
    public class Peligroso : Monstruo
    {
        public Peligroso(int respeto, string nombreMonstruo) : base(respeto, nombreMonstruo)
        {

        }

        public override void Asustar()
        {
            Respeto += 5;
        }

        public override void Reir()
        {
            Respeto -= 2;
        }

    }
}