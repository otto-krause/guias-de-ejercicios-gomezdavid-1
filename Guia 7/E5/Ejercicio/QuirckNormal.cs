namespace Ejercicio
{
    public class QuirckNormal : Quirk
    {
        public QuirckNormal(int tiempoDeUso, string nombre, bool consecuenciasEnElUsuario) : base(tiempoDeUso, nombre, consecuenciasEnElUsuario)
        {
        }

        public override int Poder()
        {
            return tiempoDeUso * nombre.Length;
        }

        public override bool EsPeligroso()
        {
            return Poder() > 1000 && tiempoDeUso > 1 || consecuenciasEnElUsuario == true; //probar(testear) esta condicion
        }

    }
}