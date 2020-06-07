namespace E2
{
    public abstract class Monstruo
    {
        private int respeto;
        private string nombreMonstruo;

        public int Respeto { get => respeto; set => respeto = value; }
        public string NombreMonstruo { get => nombreMonstruo; set => nombreMonstruo = value; }

        public Monstruo(int respeto, string nombreMonstruo)
        {
            this.respeto = respeto;
        }

        public abstract void Asustar();
        public abstract void Reir();
        public bool Respetable()
        {
            return respeto > 70;
        }

    }
}