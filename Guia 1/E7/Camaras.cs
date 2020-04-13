using System;

namespace E7
{
    public class Camaras
    {
        int resolucionMegapixeles=0,cantidadDeFotos=0;

        public Camaras(int resolucionMegapixeles, int cantidadDeFotos)
        {
            this.resolucionMegapixeles=resolucionMegapixeles;
            this.cantidadDeFotos=cantidadDeFotos;
        }

        public int  PesoPorFoto(int resolucionMegapixeles, int cantidadDeFotos)
        {
             return cantidadDeFotos * (resolucionMegapixeles * 3);
        }

        public int PesoTotalDeFotos(int resolucionMegapixeles, int cantidadDeFotos)
        {
            return cantidadDeFotos * (resolucionMegapixeles * 3);
        }

    }
}