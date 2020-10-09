using System;
using TwitterUCU;

namespace UCURide
{
    public class ConductorMensaje : IMessage
    {
        public ConductorMensaje (string foto, string message, string bio)
        {
            this.Foto = foto;
            this.Message = message;
        }
        
        public string Foto {get; set;}
        public string Message {get; set;}
    }
    
}