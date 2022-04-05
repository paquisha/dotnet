using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatriz
{
    class Segundo
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[4,4];
            for(int i = 0; i < 4; i++)
            {
                for(int j = 0; j < 4; j++)
                {
                    Console.WriteLine("Ingrese componente:");
                    string linea = Console.ReadLine();
                    mat[i, j] = int.Parse(linea);
                }
            }
        }

        public void ImprimirDiagonal()
        {
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(mat[i,i]+" ");
            }
        }
    }
}
