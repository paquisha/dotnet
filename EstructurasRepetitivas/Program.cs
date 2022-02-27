using System;

namespace EstructurasRepetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            int valor;
            string linea;

            Console.WriteLine("Ingrese valor: ");
            linea = Console.ReadLine();
            valor = int.Parse(linea);

            while(x <= valor){
                Console.Write(x);
                Console.Write(" - ");
                x++;
            }
        }
    }
}
