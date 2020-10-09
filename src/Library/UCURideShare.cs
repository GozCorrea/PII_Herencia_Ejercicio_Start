using System.Collections.Generic;
using System;

// La clase UCURideShare cumple con el patron Singleton porque solo puede existir una instancia de ella.
// Esto lo hicimos para que la lista de Usuario creada con todos los usuarios del sistema sea única.
namespace UCURide
{
    public class UCURideShare<Usuario>
    {
        private readonly static UCURideShare<Usuario> instance = new UCURideShare<Usuario>();
        private UCURideShare()
        {
        }
        public static UCURideShare<Usuario> Instance
        {
            get
            {
                return instance;
            }
        }
        List<UCURide.Usuario> usuarios = new List<UCURide.Usuario>();
        Twitter twitter = Twitter.Instance;
        public void Add(UCURide.Usuario usuario)
        {
            usuarios.Add(usuario);
            twitter.Send(usuario);
        }
        public void Mostrar() 
        {
            Console.WriteLine(usuarios.Count);
        }
    }
}