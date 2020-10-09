using System.Collections.Generic;
using System;


namespace UCURide
{
    public class UCURideShare<Usuario>
    {
        List<Usuario> usuarios = new List<Usuario>();
        Twitter twitter = Twitter.Instance;
        public void Add(Usuario usuario)
        {
            //twitter.Send(usuario);
            usuarios.Add(usuario);
        }
        public void Mostrar() 
        {
            Console.WriteLine(usuarios.Count);
        }
    }
}