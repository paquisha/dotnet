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
                Console.WriteLine("Realizar un programa que pida cargar una fecha cualquiera,"+
                    "luego verificar si dicha fecha corresponde a Navidad.");
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
                Console.WriteLine("Se ingresan tres valores por teclado, si todos son iguales se imprime la suma del"+
                    "primero con el segundo y a este resultado se lo multiplica por el tercero.");
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
                Console.WriteLine("Se ingresan por teclado tres números, si todos los valores"+
                    "ingresados son menores a 10, imprimir en pantalla la leyenda"+
                    "Todos los números son menores a diez");
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
                Console.WriteLine("Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10,"+
                    "imprimir en pantalla la leyenda"+"Alguno de los números es menor a diez");
                int num1, num2, num3;
                string linea;
                Console.WriteLine("Ingrese primer numero: ");
                linea = Console.ReadLine();
                num1 = int.Parse(linea);
                Console.WriteLine("Ingrese segundo numero: ");
                linea = Console.ReadLine();
                num2 = int.Parse(linea);
                Console.WriteLine("Ingrese tercer numero: ");
                linea = Console.ReadLine();
                num3 = int.Parse(linea);

                if(num1 < 10 || num2 < 10 || num3 < 10)
                {
                    Console.WriteLine("Al menos un numero es menor a 10");
                }
                else
                {
                    Console.WriteLine("todos son mayores a 10");
                }
            }

            static void quinto()
            {
                Console.WriteLine("Escribir un programa que pida ingresar la coordenada de un punto en el plano,"+
                    "es decir dos valores enteros x e y (distintos a cero).Posteriormente imprimir en pantalla"+
                    "en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0, 2º Cuadrante: x < 0 Y y > 0, etc.)");
                int num1, num2;
                string linea;
                Console.WriteLine("Ingrese primera c0ordenada: ");
                linea = Console.ReadLine();
                num1 = int.Parse(linea);
                Console.WriteLine("Ingrese segunda coordenada: ");
                linea = Console.ReadLine();
                num2 = int.Parse(linea);

                if(num1 > 0 && num2 > 0)
                {
                    Console.WriteLine($"x: {num1}, y: {num2}, pertenece al primer cuadrante");
                }
                else
                {
                    if (num1 < 0 && num2 > 0)
                    {
                        Console.WriteLine($"x: {num1}, y: {num2}, pertenece al segundo cuadrante");
                    }
                    else
                    {
                        if(num1 < 0 && num2 < 0)
                        {
                            Console.WriteLine($"x: {num1}, y: {num2}, pertenece a la tercer cuadrante");
                        }
                        else
                        {
                            if(num1 > 0 && num2 < 0)
                            {
                                Console.WriteLine($"x: {num1}, y: {num2}, pertenece al cuarto cuadrante");
                            }
                        }
                    }
                }
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
