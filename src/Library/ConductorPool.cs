namespace UCURide
{
    public class ConductorPool : Conductor
    {  
        
        private int cantidadpasajeros;
        public int CantidadPasajeros
       {
           get
           {
               return this.cantidadpasajeros;
           }
           set
           {
               this.cantidadpasajeros = value;
           }
       }
        
        public ConductorPool(string nombre, string apellido)
        : base (nombre, apellido)
        {
        }
    }
}