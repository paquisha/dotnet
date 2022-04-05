using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatriz
{
    class Primero
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[3, 5];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Ingresamos componente:");
                    string linea = Console.ReadLine();
                    mat[i, j] = int.Parse(linea);
                }
            }
        }

        public void Imprimir()
        {
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 5; j++)
                {
                    Console.WriteLine(mat[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
