namespace UCURide
{
    public class Conductor : Usuario
    {
       private int calificacionc;

       private string biografia;

       private string vehiculo;

       public int Calificacionc
       {
           get
           {
               return this.calificacionc;
           }
           set
           {
               this.calificacionc = value;
           }
       }

              public string Bigrafia
       {
           get
           {
               return this.biografia;
           }
           set
           {
               this.biografia = value;
           }
       }
       
              public string Vehiculo
       {
           get
           {
               return this.vehiculo;
           }
           set
           {
               this.vehiculo = value;
           }
       }
       

        public Conductor(string nombre, string apellido) 
            : base(nombre, apellido)
        {
        }


    }
}