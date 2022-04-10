using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatriz
{
    class Septimo
    {
        private int[,] mat;

        public void Cargar()
        {
            Console.WriteLine("Cuantas filas tiene la matriz");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);

            Console.WriteLine("Cuantas columnas tiene la matriz");
            linea = Console.ReadLine();
            int columnas = int.Parse(linea);

            mat = new int[filas, columnas];

            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write("Ingrese componente: ");
                    linea = Console.ReadLine();
                    mat[i, j] = int.Parse(linea);
                }
            }
        }
        public void Intercambiar()
        {
            for (int i = 0; i < mat.GetLength(1); i++)
            {
                int aux = mat[0, i];
                mat[0, i] = mat[1, i];
                mat[1, i] = aux;
            }
        }
        public void Imprimir()
        {
            for(int i = 0; i < mat.GetLength(0); i++)
            {
                for(int j = 0; j < mat.GetLength(1); j++)
                {
                    Console.Write(mat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
