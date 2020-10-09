using System;
using TwitterUCU;

namespace UCURide
{
    public class PasajeroMensaje : IMessage
    {
        
        public PasajeroMensaje (string foto, string nombre)
        {
            this.Foto = foto;
            this.Message = nombre;
        }
        
        public string Foto {get; set;}
        public string Message {get; set;}
    }
    }
}