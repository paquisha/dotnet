using System;

namespace MatricesYVectores
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string linea;

            Console.WriteLine("Escoja una opcion:");
            Console.WriteLine("1. Se tiene la siguiente información:\n");
            Console.WriteLine("· Nombres de 4 empleados.\n");
            Console.WriteLine("· Ingresos en concepto de sueldo, cobrado por cada empleado, en los últimos 3 meses.\n");
            Console.WriteLine("Confeccionar el programa para:\n");
            Console.WriteLine("a) Realizar la carga de la información mencionada.\n");
            Console.WriteLine("b) Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para cada empleado.\n");
            Console.WriteLine("c) Mostrar por pantalla el total pagado en sueldos a todos los empleados en los últimos 3 meses\n");
            Console.WriteLine("d) Obtener el nombre del empleado que tuvo el mayor ingreso acumulado\n");
            Console.WriteLine("2. Se desea saber la temperatura media trimestral de cuatro paises. Para ello se tiene como dato las temperaturas\n"+
                "medias mensuales de dichos paises.\n"+
                "Se debe ingresar el nombre del país y seguidamente las tres temperaturas medias mensuales.\n"+
                "Seleccionar las estructuras de datos adecuadas para el almacenamiento de los datos en memoria.\n"+
                "a - Cargar por teclado los nombres de los paises y las temperaturas medias mensuales.\n"+
                "b - Imprimir los nombres de las paises y las temperaturas medias mensuales de las mismas.\n"+
                "c - Calcular la temperatura media trimestral de cada país.\n"+
                "d - Imprimir los nombres de los paises y las temperaturas medias trimestrales.\n"+
                "e - Imprimir el nombre del país con la temperatura media trimestral mayor.");
            linea = Console.ReadLine();
            opcion = int.Parse(linea);

            switch (opcion)
            {
                case 1:
                    primero();
                    break;
                case 2:
                    segundo();
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }

            void primero()
            {
                Primero primero = new Primero();
                primero.Cargar();
                primero.CalcularSumaSueldos();
                primero.ImprimirTotalPagado();
                primero.EmpleadoMayorSueldo();
            }

            void segundo()
            {
                Segundo segundo = new Segundo();
                segundo.Cargar();
                segundo.ImprimirTempMensuales();
                segundo.CalcularTemperaturaTri();
                segundo.ImprimirTemperaturaTrimestrales();
                segundo.PaisMayorTemperaturaTri();
            }
        }
    }
}
