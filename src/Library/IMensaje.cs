using System;

namespace UCURide
{
    public interface IMessage <T>
    {
        void Mensaje (T usuario);
        string Foto {get; set;}
        string Message {get; set;}
        
        
    }
}