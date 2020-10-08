namespace UCURide
{
    public class Pasajero : Usuario
    {
       private int calificacionp;

       public int Calificacionp
       {
           get
           {
               return this.calificacionp;
           }
           set
           {
               this.calificacionp = value;
           }
       }

        public Pasajero(string nombre) 
            : base(nombre)
        {
        }


    }
}