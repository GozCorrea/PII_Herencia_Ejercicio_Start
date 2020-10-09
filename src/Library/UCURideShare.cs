using System.Collections.Generic;
using System;


namespace UCURide
{
    public class UCURideShare <Usuario>
    {
        List <Usuario> usuarios = new List<Usuario>();

        public void Add (Usuario usuario)
        {
            usuarios.Add(usuario);

        }

        public void Mostrar() 
        {
            Console.WriteLine (usuarios.Count);
        }




    }
}