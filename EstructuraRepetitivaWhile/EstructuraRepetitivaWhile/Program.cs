using System;

namespace EstructuraRepetitivaWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0;
            while(contador <= 10)
            {
                Console.WriteLine($"numero: {contador}");
                contador = contador + 1;
            }
        }
    }
}
