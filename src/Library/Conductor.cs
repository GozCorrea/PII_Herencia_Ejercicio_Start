namespace UCURide
{
    public class Conductor : Usuario
    {
        public string Vehiculo {get; set;}
        public string Biografia {get; set;}
        public Conductor(string vehiculo, string biografia)
        {
            this.Biografia = biografia;
            this.Vehiculo = vehiculo;
        }
        public int CalificacionConductor;
        public int CantidadCalificaciones = 0;
        public void CalificarConductor(int calificacion)
        {
            CantidadCalificaciones ++;
            CalificacionConductor = (calificacion + CalificacionConductor*(CantidadCalificaciones-1))/CantidadCalificaciones;
        }
    }
}