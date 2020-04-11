namespace E4
{
    public class Gatito
    {
        string nombre;
        bool vacunas;
        int energia;

        public Gatito(string nombre, bool vacunas, int energia)
        {
            this.nombre=nombre;
            this.vacunas=vacunas;
            this.energia=energia;
        }

        public string Nombre()
        {
            return nombre;
        }

        public bool estaSaludable()
        {
            return vacunas && energia > 30;
        }

        public bool estaVacunado()
        {
            return vacunas;
        }

        public int Jugar(int tiempo)
        {
            return energia-=(2*tiempo);
        }

        public int Comer()
        {
            return energia+=50;
        }


    }
}