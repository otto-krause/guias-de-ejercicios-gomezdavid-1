using System.Collections.Generic;
namespace E2
{
    public class Constructora
    {
        public int horas=0;
        Pintores pintoresOBJ = new Pintores();
        Plomeros plomerosOBJ = new Plomeros();
        Albañiles albañilesOBJ = new Albañiles();
        ContratistaINT ContratistaInterface = null;

        public Constructora()
        {
            this.horas=0;
        }
        public void ContratistasMensajes(int horas)
        {    
            ContratistaInterface.Trabajar(horas);
        } 
        public bool SePuedeLlevarACaboElProyecto(int presupuesto)
        {
            if(presupuesto>CobroTotal())
                return true;
            return false;
        }

        public int CobroTotal()
        {
            return (pintoresOBJ.Cobrar()+plomerosOBJ.Cobrar()+albañilesOBJ.Cobrar());
        }
    }
}