namespace Ejercicio
{
    public class OneForAll : Quirk
    {
        public int contadorDeTraspasos;
        public OneForAll(int contadorDeTraspasos ,int tiempoDeUso, string nombre, bool consecuenciasEnElUsuario) : base(tiempoDeUso, nombre, consecuenciasEnElUsuario)
        {
        }

        public override int Poder()
        {
            return (tiempoDeUso * nombre.Length) + ((((tiempoDeUso*nombre.Length)*15)/100)*contadorDeTraspasos);
        }

        public override bool EsPeligroso() //siempre es peligroso
        {
            return true;
        }

        //habilidad de traspasarse a un usuario
        public void TraspasarQuirk()
        {
            contadorDeTraspasos++;
        }
    }
}