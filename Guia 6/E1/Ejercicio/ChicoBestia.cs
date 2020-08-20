namespace Ejercicio
{
    public class ChicoBestia : Titan
    {
        private string nombreDelColor;

        public string NombreDelColor { get => nombreDelColor; set => nombreDelColor = value; }

        public ChicoBestia(string nombreDelColor, int tristeza) : base(tristeza)
        {
            this.nombreDelColor = nombreDelColor;
        }

        public override void ComerPizza()
        {
            nombreDelColor = "Amarillo patito fluorescente de las montañas del himalaya amazonico";
        }

        public override void LlorarPorRobocop()
        {
            tristeza -= 8;
            if (tristeza < 0) tristeza = 0;
        }

        public override bool EstaTriste()
        {
            return tristeza > 5;
        }
        
        public override int Poder()
        {
            int cantidadDeLetrasDelColor;
            return cantidadDeLetrasDelColor = (nombreDelColor.Length) * 13;
        }

        public void CambiarDeColor(string nuevoColor)
        {
            nombreDelColor = nuevoColor;
            tristeza += 4;
        }

        public int MetodoQueDevuelveLaTristezaDeChicoBesita()
        {
            return tristeza;
        }


    }
}