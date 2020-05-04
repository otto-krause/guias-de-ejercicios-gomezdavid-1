namespace E1
{
    public class MrBurns
    {
        private bool poseeRiquezas = true;

        public MrBurns()
        {
            this.poseeRiquezas = true;
        }

        public void despojarRiqueza()
        {
            poseeRiquezas=false;
        }

        public bool esMillonario()
        {
            return poseeRiquezas;
        }
    }
}