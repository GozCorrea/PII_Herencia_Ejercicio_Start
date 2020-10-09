using System;
//using TwitterUCU;

namespace UCURide
{
    public class PasajeroMensaje : IMessage
    {
        
        public void Mensaje (Pasajero pasajero)
        {
            this.Foto = pasajero.Foto;
            this.Message = pasajero.Nombre;
        }
        
        public string Foto {get; set;}
        public string Message {get; set;}
    }

}