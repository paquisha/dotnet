using System;

namespace EjerciciosMatriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            string linea;

            Console.WriteLine("Escoja una opcion:");
            Console.WriteLine("1. Crear una matriz de 3 filas por 5 columnas con elementos de tipo int, cargar sus componentes y luego imprimirlas.\n"+
                "2. Crear y cargar una matriz de 4 filas por 4 columnas. Imprimir la diagonal principal.\n"+
                "3. Crear y cargar una matriz de 3 filas por 4 columnas. Imprimir la primer fila. Imprimir la última fila e imprimir la primer columna.\n"+
                "4. Crear una matriz de 2 filas y 5 columnas. Realizar la carga de componentes por columna (es decir primero ingresar toda la primer columna,\n"+
                "luego la segunda columna y así sucesivamente)Imprimir luego la matriz\n"+
                "5. Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir la matriz completa y la última fila.\n"+
                "6. Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir el mayor elemento y la fila y columna donde se almacena.\n"+
                "7. Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la primer fila con la segunda. Imprimir luego la matriz.\n"+
                "8. Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los cuatro valores que se encuentran en los vértices de la misma (mat[0][0] etc.)\n");
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
                case 8:
                    octavo();
                    break;
                default:
                    Console.WriteLine("opcion no valida");
                    break;
            }

            void primero()
            {
                Primero primero = new Primero();
                primero.Cargar();
                primero.Imprimir();
            }

            void segundo()
            {
                Segundo segundo = new Segundo();
                segundo.Cargar();
                segundo.ImprimirDiagonal();
            }

            void tercero()
            {
                Tercero tercero = new Tercero();
                tercero.Cargar();
                tercero.PrimeraFila();
                tercero.UltimaFila();
                tercero.PrimeraColumna();
            }

            void cuarto()
            {
                Cuarto cuarto = new Cuarto();
                cuarto.Cargar();
                cuarto.Imprimir();
            }

            void quinto()
            {
                Quinto quinto = new Quinto();
                quinto.Cargar();
                quinto.Imprimir();
                quinto.ImprimirUltimaFila();
            }

            void sexto()
            {
                Sexto sexto = new Sexto();
                sexto.Cargar();
                sexto.ImprimirMayor();
            }

            void septimo()
            {
                Septimo septimo = new Septimo();
                septimo.Cargar();
                septimo.Intercambiar();
                septimo.Imprimir();
            }

            void octavo()
            {
                Octavo octavo = new Octavo();
                octavo.Cargar();
                octavo.ImprimirVertices();
            }

        }
    }
}
