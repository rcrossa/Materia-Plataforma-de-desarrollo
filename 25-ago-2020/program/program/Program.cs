using System;

namespace program
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero = 0;
            Console.Write("ingrese un numero");

            while(numero != 10)
            {
                Console.Write("ingrese un numero");
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine(numero);
                
            }
            Console.WriteLine("Adivino el numero. Saludos");
        }
    }
}
