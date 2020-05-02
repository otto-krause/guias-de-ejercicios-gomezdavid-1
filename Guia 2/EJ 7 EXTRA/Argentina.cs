using System.Collections.Generic;
namespace EJ_7_EXTRA
{
    public class Argentina
    {
        List<Alfajor> alfajores = new List<Alfajor>();

        public Argentina()
        {
            alfajores.Add(new Alfajor("Jorgito Chocolate",50,"Jorgito"));
            alfajores.Add(new Alfajor("Triple Fruta",35,"Guaymayen"));
            alfajores.Add(new Alfajor("Capitan Del Espacio Dulce de Leche",30,"Capitan Del Espacio"));
            alfajores.Add(new Alfajor("Milka Torta",50,"Milka"));
        }

        public void BajarElPrecioDelPetroleo()
        {
            foreach (var i in alfajores)
            {
                i.precio+=80;
            }
        }

        public void MillaiHablaPorTv()
        {
            foreach (var i in alfajores)
            {
                i.precio+=i.precio*2;
            }
        }

        public void CoronaVairas()
        {
            foreach (var i in alfajores)
            {
                if(i.empresa!="Guaymayen")
                    i.precio+=1000;
            }
        }

        public string EstadoDeLaInflacion()
        {
            int suma=0;

            foreach (var i in alfajores)
            {
                suma+=i.precio;
            }

            if(suma<500)
                return "Es normal";
            if(suma>500&&suma<1000)
                return "Es super";
            return "Es hyper";
        }

        public string ArgentinaDefault()
        {
            if(EstadoDeLaInflacion()=="Es hyper")
                return "Esta en default";
            return "No esta en default";
        }

    }
}