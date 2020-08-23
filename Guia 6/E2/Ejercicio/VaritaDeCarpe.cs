namespace Ejercicio
{
    public class VaritaDeCarpe : Varita
    {
        public VaritaDeCarpe(int potencia) : base(potencia)
        {

        }

        public override int TiempoDePreparacionDeLaReceta(Receta receta)
        {
            return receta.Pasos.Count / potencia;
        }
    }
}