namespace E3
{
    public class Armadura
    {
        private string nombreArmadura;
        private string material;

        public Armadura(string nombreArmadura, string material)
        {
            this.nombreArmadura = nombreArmadura;
            this.material = material;
        }

      
        public string Material { get => material; }
        public string NombreArmadura { get => nombreArmadura; set => nombreArmadura = value; }
    }
}