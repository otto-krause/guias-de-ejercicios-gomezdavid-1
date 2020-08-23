namespace Ejercicio
{
    public class Ingrediente
    {
        private int calorias;
        private string nombreIngrediente;

        public Ingrediente(int calorias, string nombreIngrediente)
        {
            this.calorias = calorias;
            this.nombreIngrediente = nombreIngrediente;
        }

        public int Calorias { get => calorias; set => calorias = value; }
        public string NombreIngrediente { get => nombreIngrediente; set => nombreIngrediente = value; }

        
    }
}