namespace UCURide
{
    public class Pasajero : Usuario, IUser
    {
       private int calificacionpasajero;
       private int CantidadCalificaciones = 0;
       public int CalificacionPasajero
       {
           get
           {
               return this.calificacionpasajero;
           }
           set
           {
               this.calificacionpasajero = value;
           }
       }

        public Pasajero(string nombre, string apellido) 
            : base(nombre, apellido)
        {
        }
        public void CalificarPasajero(int calificacion)
        {
            CantidadCalificaciones ++;
            CalificacionPasajero = (calificacion + CalificacionPasajero*(CantidadCalificaciones-1))/CantidadCalificaciones;
        }

    }
}