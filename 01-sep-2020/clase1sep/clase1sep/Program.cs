﻿using System;

namespace clase1sep
{
    class Program
    {
        static void Main(string[] args)
        {
            //armar un juego para adivinar un numero utilizando una variable random,
            //dar 3 chances al jugador para que acierte, si acierta salen del bucle y
            //    le dan un mensaje y si no aciertan imprimen un mensaje dando el numero secreto
            //armar un metodo que reciba como parametros el mensaje a mostrar al usuario y devuelva el numero ingresado

            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Ingrese el numero");
                string valor = Console.ReadLine();
                numero = int.Parse(valor);
                if (numero == secreto) break;
            }
            if (numero == secreto)
            {
                Console.WriteLine("Ganaste");
            }
            else
            {
                Console.WriteLine("Perdiste el numero era " + secreto);
            }

           
        }

    }
}
