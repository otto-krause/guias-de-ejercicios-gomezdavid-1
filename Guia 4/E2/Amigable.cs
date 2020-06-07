using System.Collections.Generic;
namespace E2
{
    public class Amigable : Monstruo
    {
        public Amigable(int respeto, string nombreMonstruo) : base(respeto, nombreMonstruo)
        {

        }


        public override void Asustar()
        {
            Respeto += 7;
        }

        public override void Reir()
        {
            Respeto += 1;
        }

    }
}