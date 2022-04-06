using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatriz
{
    class Sexto
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.WriteLine("Cuantas filas tiene la matriz:");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);

            Console.WriteLine("Cuantas columnas tiene la matriz:");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);

            mat = new int[filas, columnas];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.WriteLine("Ingrese componente:");
                    linea = Console.ReadLine();
                    mat[i, j] = int.Parse(linea);
                }
            }
        }

        public void ImprimirMayor()
        {
            int mayor = mat[0, 0];
            int filaMayor = 0;
            int columnaMayor = 0;

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    if(mat[i,j] > mayor)
                    {
                        mayor = mat[i, j];
                        filaMayor = i;
                        columnaMayor = j;
                    }
                }
            }
            Console.WriteLine("El elemento mayor es: " + mayor);
            Console.WriteLine($"Se encuentra en la fila: {filaMayor} y en la columna: {columnaMayor}");
        }
    }
}
