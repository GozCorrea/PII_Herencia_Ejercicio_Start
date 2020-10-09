using System;
using TwitterUCU;
using System.Collections.Generic;
namespace UCURide
{
    public class ConductorMensaje : IMessage<T>
    {
        public void Mensaje (T conductor)
        {
            this.Foto = conductor.Foto;
            this.Message = conductor.Biografia;
        }
        
        public string Foto {get; set;}
        public string Message {get; set;}
    }
    
}