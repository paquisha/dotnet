using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatricesYVectores
{
    class Primero
    {
        private string[] empleados;
        private int[,] sueldos;
        private int[] sueldostot;
        public void Cargar()
        {
            empleados = new string[4];
            sueldos = new int[4, 3];
            for (int i = 0; i < empleados.Length; i++)
            {
                Console.WriteLine("Ingrese el nombre del empleado:");
                empleados[i] = Console.ReadLine();
                for (int j = 0; j < sueldos.GetLength(1); j++)
                {
                    Console.Write("Ingrese sueldo:");
                    string linea = Console.ReadLine();
                    sueldos[i, j] = int.Parse(linea);
                }
            }
        }

        public void CalcularSumaSueldos()
        {
            sueldostot = new int[4];
            for(int i = 0; i < sueldos.GetLength(0); i++)
            {
                int suma = 0;
                for(int j = 0; j < sueldos.GetLength(1); j++)
                {
                    suma = suma + sueldos[i, j];
                }
                sueldostot[i] = suma;
            }
        }

        public void ImprimirTotalPagado()
        {
            Console.WriteLine("Total de sueldos pagados por empleado: ");
            for(int i = 0; i < sueldostot.Length; i++)
            {
                Console.WriteLine(empleados[i] + " " + sueldostot[i]);
            }
        }
        public void EmpleadoMayorSueldo()
        {
            int may = sueldostot[0];
            string nom = empleados[0];
            for(int i = 0; i < sueldostot.Length; i++)
            {
                if(sueldostot[i] > may)
                {
                    may = sueldostot[i];
                    nom = empleados[i];
                }
            }
            Console.WriteLine($"el empleado con mayor sueldo es: {nom}, sueldo igual: {may}");
        }
    }
}
