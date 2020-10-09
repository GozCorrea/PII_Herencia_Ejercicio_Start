namespace UCURide
{
    public class ConductorPool : Conductor
    {  
        
        private int capacidad;
        public int Capacidad
       {
           get
           {
               return this.capacidad;
           }
           set
           {
               this.capacidad = value;
           }
       }
        
        public ConductorPool(string nombre, string apellido)
        : base (nombre, apellido)
        {
        }
    }
}