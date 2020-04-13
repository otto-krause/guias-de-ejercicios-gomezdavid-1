using System;
namespace E7

{
    public class Celular
    {
        bool NFC,Bluethoot;
        int almacenamiento=0,apps=0;

        public Celular (bool NFC, bool Bluethoot,int almacenamiento,int apps)
        {
            this.NFC=NFC;
            this.Bluethoot=Bluethoot;
            this.almacenamiento=almacenamiento;
            this.apps=apps;
        }

        public void MemoriaDisponible(int apps,int almacenamiento,Camaras frontal, Camaras trasera,int resolucionMegapixeles,int cantidadDeFotos)
        {
            almacenamiento=frontal.PesoTotalDeFotos(resolucionMegapixeles,cantidadDeFotos)-trasera.PesoTotalDeFotos(resolucionMegapixeles,cantidadDeFotos)-(apps*70);
            Console.WriteLine(almacenamiento);
        }

        public bool TeCargaLaSube()
        {
            return NFC;
        }
    }
}