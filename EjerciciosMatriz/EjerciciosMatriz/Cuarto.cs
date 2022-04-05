using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosMatriz
{
    class Cuarto
    {
        private int[,] mat;

        public void Cargar()
        {
            mat = new int[2, 5];
            Console.WriteLine("Matriz por Columna:");
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 2; j++)
                {
                    Console.WriteLine("Ingrese componente " + " de la fila " + j + " y la columna " + i +" :");
                    string linea = Console.ReadLine();
                    mat[j, i] = int.Parse(linea);
                }
            }
        }
        
        public void Imprimir()
        {
            for(int i = 0; i < 2; i++)
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
