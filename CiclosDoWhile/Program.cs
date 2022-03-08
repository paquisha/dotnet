using System;

namespace CiclosDoWhile{
    class Program{
        static void Main(string[] args){
            int opcion;
            string linea;

            Console.Write("Escoja una opcion: ");
            Console.WriteLine("1. Escribir un programa que solicite la carga de un número entre 0 y 999,\n"+
                    "y nos muestre un mensaje de cuántos dígitos tiene el mismo. Finalizar el programa cuando se cargue el valor 0.\n"+
                    "2. Escribir un programa que solicite la carga de números por teclado, obtener su promedio."+
                    "Finalizar la carga de valores cuando se cargue el valor 0.\n"+
                    "3. Realizar un programa que permita ingresar el peso (en kilogramos) de piezas.\n"+
                    "El proceso termina cuando ingresamos el valor 0. Se debe informar:\n"+
                    "a) Cuántas piezas tienen un peso entre 9.8 Kg. y 10.2 Kg.?, cuántas con más de 10.2 Kg.? y cuántas con menos de 9.8 Kg.?\n"+
                    "b) La cantidad total de piezas procesadas.\n"+
                    "4. Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999\n"+
                    "(no sumar dicho valor, indica que ha finalizado la carga). Imprimir el valor acumulado e\n"+
                    "informar si dicho valor es cero, mayor a cero o menor a cero.\n"+
                    "5. En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada cuenta corriente se conoce:\n"+
                    "número de cuenta y saldo actual. El ingreso de datos debe finalizar al ingresar un valor negativo en el número de cuenta.\n"+
                    "Se pide confeccionar un programa que lea los datos de las cuentas corrientes e informe:\n"+
                    "a)De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo que:\n"+
                    "Estado de la cuenta\n"+
                    "'Acreedor' si el saldo es >0.\n"+
                    "'Deudor' si el saldo es <0.\n"+
                    "'Nulo' si el saldo es =0.\n"+
                    "b) La suma total de los saldos acreedores.");

            linea = Console.ReadLine();
            opcion = int.Parse(linea);

            switch(opcion){
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
                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

            void primero(){
                int valor;
                string linea;
                do{
                    Console.WriteLine("Ingrese un valor entre el 0 y el 999");
                    linea = Console.ReadLine();
                    valor = int.Parse(linea);

                    if(valor >= 100){
                        Console.WriteLine("Tiene tres digitos");
                    }else{
                        if(valor >= 10){
                            Console.WriteLine("Tiene dos digitos");
                        }else{
                            Console.WriteLine("Tiene un digito");
                        }
                    }
                }while(valor != 0);
            }

            void segundo(){
                int suman = 0, cantidad = 0, valor, promedio;
                string linea;
                do{
                    Console.WriteLine("Ingrese un valor");
                    linea = Console.ReadLine();
                    valor = int.Parse(linea);
                    if(valor != 0){
                        suman += valor;
                        cantidad++;
                    }
                }while(valor != 0);
                if(cantidad != 0){
                    promedio = suman/cantidad;
                    Console.WriteLine($"El promedio de los valores ingresados es: {promedio}");
                }else{
                    Console.WriteLine("No se ingresaron valores");
                }
            }

            void tercero(){
                int cantidad1 = 0, cantidad2 = 0, cantidad3 = 0, suma;
                string linea;
                float peso;

                do{
                    Console.Write("Ingrese el peso de la pieza");
                    linea = Console.ReadLine();
                    peso = float.Parse(linea);
                    if(peso > 10.2){
                        cantidad1++;
                    }else{
                        if(peso >= 9.8){
                            cantidad2++;
                        }else{
                            if(peso > 0){
                                cantidad3++;
                            }
                        }
                    }
                }while(peso != 0);

                suma = cantidad1 + cantidad2 + cantidad3;
                Console.Write($"Piezas aptas: {cantidad2}");
                Console.Write($"Piezas con un peso superior a 10.2: {cantidad1}");
                Console.Write($"Piezas con un peso superior a 9.8: {cantidad3}");
                Console.Write($"Cantidad de piezas procesadas: {suma}");
            }

            void cuarto(){
                int suma = 0, valor;
                string linea;

                do{
                    Console.WriteLine("Ingrese valor: ");
                    linea = Console.ReadLine();
                    valor = int.Parse(linea);
                    if(valor != 9999){
                        suma += valor;
                    }                    
                }while(valor != 9999);
                Console.WriteLine($"suma es: {suma}");
                if(suma > 0){
                    Console.WriteLine($"suma es mayor a cero: {suma}");
                }else{
                    if(suma < 0){
                        Console.WriteLine($"suma es menor a cero: {suma}");
                    }else{
                        Console.WriteLine($"suma es cero: {suma}");
                    }
                }
            }

            void quinto(){
                string linea;
                int numeroCuenta;
                float saldoActual, suma = 0;
                do{
                    Console.WriteLine("Ingrese numero de cuenta: ");
                    linea = Console.ReadLine();
                    numeroCuenta = int.Parse(linea);

                    Console.WriteLine("Ingrese saldo de la cuenta: ");
                    linea = Console.ReadLine();
                    saldoActual = float.Parse(linea);

                    Console.WriteLine($"Numero de cuenta: {numeroCuenta}");
                    Console.WriteLine($"Saldo disponible: {saldoActual}");

                    if(saldoActual > 0){
                        Console.WriteLine("Acreedor");
                        suma += saldoActual;
                    }else{
                        if(saldoActual < 0){
                            Console.WriteLine("Deudor");
                        }else{
                            Console.WriteLine("Nulo");
                        }
                    }
                    
                }while(numeroCuenta < 0);

                Console.WriteLine($"Suma de saldo de acreedores: {suma}");
            }

        }
    }
}
