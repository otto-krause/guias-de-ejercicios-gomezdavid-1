using System.Collections.Generic;
namespace Ejercicio
{
    public class VaritaDeAcebo : Varita
    {
        public VaritaDeAcebo(int potencia) : base(potencia)
        {
    
        }

        public override int TiempoDePreparacionDeLaReceta(Receta receta)
        {
            return receta.ListaIngredientes.Count + potencia;
        }
    }
}