using System;

namespace CiclosFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string linea;

            Console.WriteLine("Escoja opcion: ");
            Console.WriteLine("1. Confeccionar un programa que lea n pares de datos, cada par de datos corresponde a la medida de la base y\n"+
                            "la altura de un triángulo. El programa deberá informar:\n"+
                            "a) De cada triángulo la medida de su base, su altura y su superficie.\n"+
                            "b) La cantidad de triángulos cuya superficie es mayor a 12.\n"+
                            "2. Desarrollar un programa que solicite la carga de 10 números e imprima la suma de los últimos 5 valores ingresados.\n"+
                            "3. Desarrollar un programa que muestre la tabla de multiplicar del 5 (del 5 al 50)\n"+
                            "4. Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos muestre la tabla de multiplicar"+
                            "del mismo (los primeros 13 términos)Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el 39.\n"+
                            "5. Realizar un programa que lea los lados de n triángulos, e informar:"+
                            "a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)\n"+
                            "b) Cantidad de triángulos de cada tipo.\n"+
                            "c) Tipo de triángulo que posee menor cantidad.");
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
                    tercero();
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }

            void primero(){
               float altura = 0, baseTr = 0, superficie = 0;
               string linea;
               int i, triangulos, contadorTriangulos = 0;

               Console.WriteLine("Ingrese numero de triangulos a evaluar: ");
               linea = Console.ReadLine();
               triangulos = int.Parse(linea);
               for(i = 0; i <= triangulos; i++){
                   Console.WriteLine("Ingrese base: ");
                   linea = Console.ReadLine();
                   baseTr = float.Parse(linea);

                   Console.WriteLine("Ingrese altura: ");
                   linea = Console.ReadLine();
                   altura = float.Parse(linea);

                   superficie = baseTr * altura;

                   Console.WriteLine($"Base: {baseTr}");
                   Console.WriteLine($"Altura: {altura}");
                   Console.WriteLine($"Superfice: {superficie}");

                   if(superficie > 12){
                       contadorTriangulos++;
                   }
               }
               Console.WriteLine($"triangulos con superfice mayor a 12: {contadorTriangulos}");
            }

            void segundo(){
                string linea;
                int suma = 0, valor;
                for(int i = 0; i <= 10; i++){
                    Console.WriteLine("Ingrese valor: ");
                    linea = Console.ReadLine();
                    valor = int.Parse(linea);
                    if(i > 4){
                        suma = suma + valor;
                    }
                }
                Console.WriteLine($"la suma de los 5 ultimos numeros es: {suma}");
            }

            void tercero(){
                int numero;
                string linea;

                Console.WriteLine("Ingrese multiplicador");
                linea = Console.ReadLine();
                numero = int.Parse(linea);

                for(int i = 1; i <= 15; i++){
                    Console.Write($"{i} x {numero} = {i*numero}\n");
                }
            }
        }
    }
}
