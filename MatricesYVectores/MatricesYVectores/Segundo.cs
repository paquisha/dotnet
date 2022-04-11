using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesYVectores
{
    class Segundo
    {
        private string[] paises;
        private int[,] tempmen;
        private int[] temptri;
        public void Cargar()
        {
            paises = new string[4];
            tempmen = new int[4, 3];
            for(int i = 0; i < paises.Length; i++)
            {
                Console.Write("Ingrese el nombre del pais:");
                paises[i] = Console.ReadLine();
                for(int j = 0; j < tempmen.GetLength(1); j++)
                {
                    Console.Write("Ingrese temperatura mensual:");
                    string linea = Console.ReadLine();
                    tempmen[i, j] = int.Parse(linea);
                }
            }
        }
        public void ImprimirTempMensuales()
        {
            for(int i = 0; i < paises.Length; i++)
            {
                Console.Write($"Paises: {paises[i]}:");
                for (int j = 0; j < tempmen.GetLength(1); j++) 
                {
                    Console.Write(tempmen[i,j] + " ");
                }
                Console.WriteLine();
            }
        }
        public void CalcularTemperaturaTri()
        {
            temptri = new int[4];
            for(int i = 0; i < tempmen.GetLength(0); i++)
            {
                int suma = 0;
                for(int j = 0; j < tempmen.GetLength(1); j++)
                {
                    suma = suma + tempmen[i, j];
                }
                temptri[i] = suma / 3;
            }
        }
        public void ImprimirTemperaturaTrimestrales()
        {
            Console.WriteLine("Temperaturas trimestrales: ");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine($"{paises[i]} {temptri[i]}");
            }
        }
        public void PaisMayorTemperaturaTri()
        {
            int may = temptri[0];
            string nom = paises[0];
            for(int i = 0; i < paises.Length; i++)
            {
                if(temptri[i] > may)
                {
                    may = temptri[i];
                    nom = paises[i];
                }
            }
            Console.WriteLine($"Pais con temperatura trimestral mayor es: {nom} que tiene una temperatura de {may}");
        }
    }
}
