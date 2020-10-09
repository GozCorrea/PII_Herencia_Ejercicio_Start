using System;

namespace UCURide
{
    public interface IMessageChannel
    {
        void Send (IMessage message);
        
        
    }
}