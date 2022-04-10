using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatriz
{
    class Octavo
    {
        private int[,] mat;
        public void Cargar()
        {
            Console.Write("Cuantas filas tiene la matriz:");
            string linea = Console.ReadLine();
            int filas = int.Parse(linea);

            Console.Write("Cuantas columnas tiene la matriz:");
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
        public void ImprimirVertices()
        {
            Console.WriteLine($"Vertice superior izquierdo: {mat[0,0]}");
            Console.WriteLine($"Vertice superior derecho: {mat[0, mat.GetLength(1)-1]}");
            Console.WriteLine($"Vertice inferior izquierdo: {mat[mat.GetLength(0)-1,0]}");
            Console.WriteLine($"Vertice inferior derecho: {mat[mat.GetLength(0)-1,mat.GetLength(1)-1]}");
        }
    }
}
