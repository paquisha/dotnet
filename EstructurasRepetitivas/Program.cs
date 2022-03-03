using System;

namespace EstructurasRepetitivas
{
    class Program
    {
        static void Main(string[] args)
        {
            int options;
            string linea;

            Console.WriteLine("Ingrese opcion:\n"+
                "1. Escribir un programa que solicite ingresar 10 notas de alumnos y nos informe\n"+
                "cuántos tienen notas mayores o iguales a 7 y cuántos menores.\n"+
                "2. Se ingresan un conjunto de n alturas de personas por teclado. Mostrar la altura promedio de las personas.\n"+
                "3. En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y $500, realizar un programa que lea los\n"+
                "sueldos que cobra cada empleado e informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más de $300.\n"+
                "Además el programa deberá informar el importe que gasta la empresa en sueldos al personal.\n"+
                "4. Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc. (No se ingresan valores por teclado)\n"+
                "5. Mostrar los múltiplos de 8 hasta el valor 500. Debe aparecer en pantalla 8 - 16 - 24, etc.\n"+
                "6. Realizar un programa que permita cargar dos listas de 15 valores cada una. Informar con un mensaje cual de las dos listas\n"+
                "tiene un valor acumulado mayor (mensajes Lista 1 mayor, Lista 2 mayor, Listas iguales) Tener en cuenta que puede haber dos o\n"+
                "más estructuras repetitivas en un algoritmo.\n"+
                "7. Desarrollar un programa que permita cargar n números enteros y luego nos informe cuántos valores fueron pares y cuántos impares.\n"+
                "Emplear el operador “%” en la condición de la estructura condicional:\n"+
                "if (valor%2==0) //Si el if da verdadero luego es par.");
                linea = Console.ReadLine();
                options = int.Parse(linea);

                switch(options){
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
                        Console.WriteLine("");
                        break;
                }

                void primero(){
                    int x = 0, contadorMayores = 0, contadorMenores = 0, contadorIguales = 0;
                    float notas;
                    string linea;
                    while(x <= 10){
                        Console.WriteLine("Ingrese nota: ");
                        linea = Console.ReadLine();
                        notas = float.Parse(linea);

                        if(notas > 7){
                            contadorMayores += 1;
                        }else{
                            if(notas == 7){
                                contadorIguales += 1;
                            }else{
                                contadorMenores += 1;
                            }
                        }
                        x++;
                    }

                    Console.WriteLine($"Mayores a 7: {contadorMayores}\n");
                    Console.WriteLine($"Iguales a 7: {contadorIguales}\n");
                    Console.WriteLine($"Menores a 7: {contadorMenores}");
                }

                void segundo(){
                    int x = 1, limite;
                    string linea;
                    float alturas, suma = 0, promedio;
                    Console.WriteLine("Ingrese total de alumnos: ");
                    linea = Console.ReadLine();
                    limite = int.Parse(linea);

                    while(x <= limite){
                        Console.WriteLine("Ingrese altura: ");
                        linea = Console.ReadLine();
                        alturas = float.Parse(linea);
                        suma = suma + alturas;
                        x = x + 1;
                    }                
                    promedio = suma/limite;
                    Console.WriteLine($"Altura promedio: {promedio}");
                }

                void tercero(){
                    float sueldo, sumaSueldos = 0;
                    string linea;
                    int x = 1, empleados, contadorSueldosMenores = 0, constadorSueldosMayores = 0;
                    
                    Console.WriteLine("Agrege cantidad de empleados:");
                    linea = Console.ReadLine();
                    empleados = int.Parse(linea);

                    while(x <= empleados){
                        Console.WriteLine("Ingrese el sueldo del empleado: ");
                        linea = Console.ReadLine();
                        sueldo = float.Parse(linea);
                        if(sueldo <= 300){
                            contadorSueldosMenores++;
                        }else{
                            constadorSueldosMayores++;
                        }
                        sumaSueldos = sumaSueldos + sueldo;
                        x++;
                    }
                    Console.WriteLine($"Empleados que cobran entre 100 y 300: {contadorSueldosMenores}");
                    Console.WriteLine($"Empleados que cobran mas de 300: {constadorSueldosMayores}");
                    Console.WriteLine($"Importe de sueldos: ${sumaSueldos}");
                }

                void cuarto(){
                    int x = 1, suma = 0;
                    while(x <= 25){
                        suma = suma + 11;
                        Console.Write(suma);
                        Console.Write("-");
                        x++;
                    }
                }

                void quinto(){
                    int x = 8;
                    while(x <= 500){
                       Console.Write(x);
                       Console.Write("-");
                       x += 8;
                    }
                }

                void sexto(){
                    int x = 1, sumaListaA = 0, sumaListaB = 0, valor, y = 1;
                    string linea;
                    while(x <= 15){
                        Console.WriteLine("Ingrese Valor lista A: ");
                        linea = Console.ReadLine();
                        valor = int.Parse(linea);
                        sumaListaA += valor;
                        x++;
                    }

                    while(y <= 15){
                        Console.WriteLine("Ingrese Valor lista B: ");
                        linea = Console.ReadLine();
                        valor = int.Parse(linea);
                        sumaListaB += valor;
                        y++;
                    }
                    if(sumaListaA > sumaListaB){
                        Console.WriteLine($"Lista A es mayor ${sumaListaA}");
                    }else{
                        Console.WriteLine($"Lista B es mayor ${sumaListaB}");
                    }
                }

                void septimo(){
                    int x= 1, valor, contadorPares = 0, contadorImpares = 0;
                    string linea;

                    Console.WriteLine("Ingrese cantidad de numeros a comparar: ");
                    linea = Console.ReadLine();
                    valor = int.Parse(linea);

                    while(x <= valor){
                        Console.WriteLine("Ingrese numero: ");
                        linea = Console.ReadLine();
                        valor = int.Parse(linea);
                        if(valor%2 == 0){
                            contadorPares++;
                        }else{
                            contadorImpares++;
                        }
                        x++;
                    }
                    Console.WriteLine($"Cantidad de pares ${contadorPares}");
                    Console.WriteLine($"Cantidad de impares ${contadorImpares}");
                }
        }
    }
}
