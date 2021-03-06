﻿using System;
using System.Collections;
using UCURide;

namespace PII_Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Pasajero guzman = new Pasajero ("Guzman", "Correa");
            Conductor martin = new Conductor ("Martin", "Perciante");
            ConductorPool nico = new ConductorPool ("Nico", "Lozano", 4);
            UCURideShare<Usuario> rideShare = UCURideShare<Usuario>.Instance;
            UCURideShare<Usuario> rideShare1 = UCURideShare<Usuario>.Instance;
            rideShare.Add(guzman);
            rideShare.Add(martin);
            rideShare1.Add(nico);
            rideShare.Mostrar();

            /*
            En éste método deberas mostrar un ejemplo de funcionamiento de tu programa an pseudocódigo. A continuación te 
            planteamos un ejemplo de como hacerlo. Esto no significa que te limites a hacer solamente esto, debes pensar 
            en grande!

            Usuario pasajero1 = nuevo Pasajero()
            Usuario pasajero2 = nuevo Pasajero()
            Usuario pasajero3 = nuevo Pasajero()
            Usuario conductor1 = nuevo Conductor()
            Usuario conductorPool1 = nuevo ConductorPool(maxPasajeros = 3)
            UcuRideShare rideShare = nuevo UcuRideShare()
            
            rideShare.Add(conductor1)
            Se publica en Twitter un nuevo conductor!

            rideShare.Add(conductorPool1)
            Se publica en Twitter un nuevo conductor!
            
            rideShare.Add(pasajero1)
            Se publica en Twitter nuevo registro de pasajero!
            
            rideShare.Add(pasajero2)
            Se publica en Twitter nuevo registro de pasajero!

            rideShare.Add(pasajero3)
            Se publica en Twitter nuevo registro de pasajero!
            */
        }
    }
}