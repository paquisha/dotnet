namespace CondicionalesAnidadas{
    class Program{
        static void Main(string[] args){
            int numero;

            string linea;

            Console.WriteLine("Menu opciones: ");
            Console.WriteLine("1. Mostrar mayor");
            Console.WriteLine("2. Positivo, negativo o null");
            Console.WriteLine("3. Cifras de un numero");
            Console.WriteLine("4. Postulante de empleo");
            linea = Console.ReadLine();
            numero = int.Parse(linea);

            switch(numero){
                case 1:
                    primerEjercicio();
                    break;
                case 2:
                    segundoEjercicio();
                    break;
                case 3:
                    tercerEjercicio();
                    break;
                case 4:
                    cuartoEjercicio();
                    break;
                default:
                    Console.WriteLine("seleccion no validad");
                    break;
            }

            static void primerEjercicio(){
                Console.WriteLine("Se cargan por teclado tres números distintos." +
                    "Mostrar por pantalla el mayor de ellos.");
                int num1, num2, num3;
                string linea;
                Console.WriteLine("Ingrese primer: ");
                linea = Console.ReadLine();
                num1 = int.Parse(linea);

                Console.WriteLine("Ingrese segundo: ");
                linea = Console.ReadLine();
                num2 = int.Parse(linea);

                Console.WriteLine("Ingrese tercer: ");
                linea = Console.ReadLine();
                num3 = int.Parse(linea);

                if(num1 > num2 && num1 > num3){
                    Console.WriteLine($"{num1} es el numero mayor");                    
                }else{
                    if(num2 > num3){
                        Console.WriteLine($"{num2} es el numero mayor");
                    }else{
                        Console.WriteLine($"{num3} es el numero mayor");
                    }
                }

            }

            static void segundoEjercicio(){
                Console.WriteLine("Se ingresa por teclado un valor entero, mostrar una leyenda que indique" +
                 "si el número es positivo, nulo o negativo.");

                 int num1;
                 string linea;
                 Console.WriteLine("Ingrese numero: ");
                 linea = Console.ReadLine();
                 num1 = int.Parse(linea);
                 if(num1 > 0){
                     Console.WriteLine($"{num1} es positivo");
                 }else{
                     if(num1 < 0 ){
                         Console.WriteLine($"{num1} es negativo");
                     }else{
                         Console.WriteLine($"{num1} es null");
                     }
                 }

            }

            static void tercerEjercicio(){
                Console.WriteLine("Confeccionar un programa que permita cargar un"+
                "número entero positivo de hasta tres cifras y muestre un mensaje" +
                "indicando si tiene 1, 2, o 3 cifras. Mostrar un mensaje de error"+
                "si el número de cifras es mayor.");

                int num1;
                string linea;
                Console.WriteLine("Ingresar numero: ");
                linea = Console.ReadLine();
                num1 = int.Parse(linea);

                if(num1 < 0){
                    Console.WriteLine("solo numero positivos");
                }else{
                    if(num1 < 10){
                        Console.WriteLine($"{num1} solo tiene una cifra");
                    }else{
                        if(num1 > 10 && num1 < 100){
                            Console.WriteLine($"{num1} tiene dos cifras");
                        }else{
                            Console.WriteLine($"{num1} tiene tres cifras");
                        }
                    }
                }
            }

            static void cuartoEjercicio(){
                Console.WriteLine("Un postulante a un empleo, realiza un test de"+
                "capacitación, se obtuvo la siguiente información:"+
                "cantidad total de preguntas que se le realizaron y la cantidad de"+
                "preguntas que contestó correctamente. Se pide confeccionar un programa"+
                "que ingrese los dos datos por teclado e informe el nivel del mismo"+
                "según el porcentaje de respuestas correctas que ha obtenido, y sabiendo que:");

                Console.WriteLine("Nivel máximo: Porcentaje>=90%.");
                Console.WriteLine("Nivel medio:	Porcentaje>=75% y <90%.");
                Console.WriteLine("Nivel regular:	Porcentaje>=50% y <75%.");
                Console.WriteLine("Fuera de nivel:	Porcentaje<50%.");

                int totalPreguntas, preguntasCorrectas;
                string linea;
                Console.WriteLine("Ingrese total de preguntas: ");
                linea = Console.ReadLine();
                totalPreguntas = int.Parse(linea);

                Console.WriteLine("Ingrese preguntas correctas: ");
                linea = Console.ReadLine();
                preguntasCorrectas = int.Parse(linea);

                int porcentaje = preguntasCorrectas * 100 / totalPreguntas;

                if(porcentaje >= 90){
                    Console.WriteLine($"nivel maximo {porcentaje}");
                }else{
                    if(porcentaje >= 75 && porcentaje <90){
                        Console.WriteLine($"nivel medio {porcentaje}");
                    }else{
                        if(porcentaje >= 50 && porcentaje < 75){
                            Console.WriteLine($"nivel regular {porcentaje}");
                        }else{
                            Console.WriteLine($"fuera de nivel {porcentaje}");
                        }
                    }
                }

            }
        }
    }
}
