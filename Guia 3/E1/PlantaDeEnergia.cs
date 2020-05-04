namespace E1
{
    public class PlantaDeEnergia
    {
        MrBurns burns = new MrBurns();
        private Empleado empleado;
        private int barrasDeUranio;

        public PlantaDeEnergia(MrBurns burns, Empleado empleado, int barrasDeUranio)
        {
            this.burns = burns;
            this.empleado = empleado;
            this.barrasDeUranio = barrasDeUranio;
        }

        public bool estaEnPeligro()
        {
            return (barrasDeUranio > 10000 && empleado.estaDistraido())
                    || !burns.esMillonario();
        }

        public void CambiarEmpleado(Empleado nuevoEmpleado)
        {
            empleado = nuevoEmpleado;
        }
    }
}