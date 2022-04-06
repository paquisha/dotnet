using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatriz
{
    class Quinto
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.WriteLine("Cuantas filas tiene la matriz:");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);

            Console.WriteLine("Cuantas Columnas tiene la matriz:");
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

        public void Imprimir()
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j <mat.GetLength(1); j++)
                {
                    Console.WriteLine(mat[i,j]+" ");
                }
                Console.WriteLine();
            }
        }

        public void ImprimirUltimaFila()
        {
            Console.WriteLine("Ultima fila");
            for(int i = 0; i < mat.GetLength(1); i++)
            {
                Console.WriteLine(mat[mat.GetLength(0) - 1, i] + " ");
            }
        }
    }
}
