using System;

namespace Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            //segun tres nota ingresadas calcular promedio
            //si es mayor a 7 paso
            //si es > 4 o <=6 supletorio
            //si es menor a 4 se quedo

            float num1, num2, num3, promedio;
            string linea;

            Console.WriteLine("Ingrese primera nota: ");
            linea = Console.ReadLine();
            num1 = float.Parse(linea);

            Console.WriteLine("Ingrese segunda Nota: ");
            linea = Console.ReadLine();
            num2 = float.Parse(linea);

            Console.WriteLine("Ingrese tercer numero: ");
            linea = Console.ReadLine();
            num3 = float.Parse(linea);

            promedio = (num1 + num2 + num3)/3;

            if(promedio >= 7)
            {
                Console.WriteLine("Aprobado");
            }
            else
            {
                if(promedio > 4 && promedio <= 6)
                {
                    Console.WriteLine("Supletorio");
                }
                else
                {
                    Console.WriteLine("Reprobado");
                }
            }

            int valor1 = 13;
            int valor2 = 7;

            if(valor1 < valor2)
            {
                Console.WriteLine("valor uno es menor");
            }
            else
            {
                Console.WriteLine("Valor 2 es menor");
            }

        }
    }
}
