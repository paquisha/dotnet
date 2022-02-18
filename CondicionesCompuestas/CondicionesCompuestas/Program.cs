using System;

namespace CondicionesCompuestas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string linea;

            Console.WriteLine("Escoja una opcion:\n"+
                "1. verificar si es navidad\n" +
                "2. Calculo de datos\n" +
                "3. numero menores a 10\n"+
                "4. si todos son menores a 10\n"+
                "5. cuadrantes con enteros\n"+
                "6. Aumentos empleados\n"+
                "7. calculo de rango de variacion\n");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            switch (numero)
            {
                case 1:
                    primero();
                    break;
                case 2:
                    segundo();
                    break;
                case 3:
                    tercero();
                    break;
                case 4:
                    cuarto();
                    break;
                case 5:
                    quinto();
                    break;
                case 6:
                    sexto();
                    break;
                case 7:
                    septimo();
                    break;
                default:
                    Console.WriteLine("opcion incorrecta");
                    break;
            }

            static void primero(){
                int mes, dia;
                string linea;
                Console.WriteLine("Ingrese mes: ");
                linea = Console.ReadLine();
                mes = int.Parse(linea);
                Console.WriteLine("Ingrese dia: ");
                linea = Console.ReadLine();
                dia = int.Parse(linea);

                if(mes == 12 && dia == 25)
                {
                    Console.WriteLine($"dia {dia} mes {mes}, es navidad");
                }
                else
                {
                    Console.WriteLine("No es navidad");
                }
            }

            static void segundo()
            {
                int num1, num2, num3;
                string linea;
                Console.WriteLine("Ingrese primer numero:");
                linea = Console.ReadLine();
                num1 = int.Parse(linea);
                Console.WriteLine("Ingrese segundo numero:");
                linea = Console.ReadLine();
                num2 = int.Parse(linea);
                Console.WriteLine("Ingrese tercer numero");
                linea = Console.ReadLine();
                num3 = int.Parse(linea);

                if(num1 == num2 && num1 == num3)
                {
                    Console.WriteLine("todos los numeros son iguales");
                }
                else
                {
                    if(num2 == num3)
                    {
                        Console.WriteLine("solo dos numeros son iguales");
                    }
                    else
                    {
                        Console.WriteLine("No son iguales");
                    }
                }
            }

            static void tercero()
            {
                int num1, num2, num3;
                string linea;
                Console.WriteLine("Ingrese primer numero:");
                linea = Console.ReadLine();
                num1 = int.Parse(linea);
                Console.WriteLine("Ingrese el segundo numero:");
                linea = Console.ReadLine();
                num2 = int.Parse(linea);
                Console.WriteLine("Ingrese el tercer numero:");
                linea = Console.ReadLine();
                num3 = int.Parse(linea);

                if(num1 < 10 && num2 < 10 && num3 < 10)
                {
                    Console.WriteLine("Todos los numeros son menores a 10");
                }
                else
                {
                    Console.WriteLine("Al menos un numero no es menor a 10");
                }
            }

            static void cuarto()
            {
                Console.WriteLine("cuarto ejercio");
            }

            static void quinto()
            {
                Console.WriteLine("quinto ejercio");
            }

            static void sexto()
            {
                Console.WriteLine("sexto ejercio");
            }

            static void septimo()
            {
                Console.WriteLine("septimo ejercio");
            }
        }
    }
}
