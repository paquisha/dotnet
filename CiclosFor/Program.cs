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
                            "b) La cantidad de triángulos cuya superficie es mayor a 12.");
            linea = Console.ReadLine();
            opcion = int.Parse(linea);

            switch(opcion){
                case 1:
                    primero();
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }

            async void primero(){
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
        }
    }
}
