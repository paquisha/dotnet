using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatriz
{
    class Tercero
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[3, 4];
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingrese numero:");
                    string linea = Console.ReadLine();
                    mat[i, j] = int.Parse(linea);
                }
            }
        }

        public void PrimeraFila()
        {
            Console.WriteLine("Primera fila de la matriz:");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(mat[0, i]);
            }
        }

        public void UltimaFila()
        {
            Console.WriteLine("Ultima fila de la matriz:");
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(mat[2, i]);
            }
        }

        public void PrimeraColumna()
        {
            Console.WriteLine("Primera Columna:");
            for(int i = 0; i < 3; i++)
            {
                Console.WriteLine(mat[i, 0]);
            }
        }
    }
}
