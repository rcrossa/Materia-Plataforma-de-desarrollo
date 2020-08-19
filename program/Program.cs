using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Inicio de ejercicio");

            ////int dado = 1;
            //string mensaje;
            //string letra = "Argentina";
            //string valor = Console.ReadLine();

            ////dado = int.Parse(valor);
            //if (letra == "Argemtina")
            //{
            //    mensaje = "Te ganaste un auto";
            //}
            //else if (letra == "Uruguay" || letra == "Brasil")
            //{
            //    mensaje = "Te ganaste una moto";
            //}
            //else if (letra == "Bolivia" && letra == "Ecuador")
            //{
            //    mensaje = "Te ganaste un perro";
            //}
            //else
            //{
            //    mensaje = "Segui participando";
            //}
            //Console.WriteLine(mensaje);


            //----------Ejercicio 2-------

            int aux = 0;
            int numero = 0;


            for (int posicion = 0; posicion < 10; posicion++)
            {
                Console.WriteLine("Ingrese numero: ");
                numero = int.Parse(Console.ReadLine());
                aux = aux + numero;
                Console.WriteLine("La posicion es :" + posicion);
                if (aux > 50)
                {

                    break;

                }

            }



        }
    }
}
