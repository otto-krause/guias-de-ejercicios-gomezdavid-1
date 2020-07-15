namespace E7
{
    public class Publicacion
    {
        private string texto;
        private Foto foto;

        public Publicacion(string texto, Foto foto)
        {
            this.texto = texto;
            this.foto = foto;
        }

        public string Texto { get => texto;}
        public Foto Foto { get => foto;}
    }
}