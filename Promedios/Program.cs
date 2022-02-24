namespace Promedios{
    class Program{
        static void Main(string[] args){
            double nota1, nota2, nota3, promedio;
            string linea;

            Console.WriteLine("Ingrese primera nota: ");
            linea = Console.ReadLine();
            nota1 = double.Parse(linea);

            Console.WriteLine("Ingrese segunda nota: ");
            linea = Console.ReadLine();
            nota2 = double.Parse(linea);

            Console.WriteLine("Ingrese tercera nota: ");
            linea = Console.ReadLine();
            nota3 = double.Parse(linea);

            promedio = (nota1 + nota2 + nota3)/3;

            if(promedio >= 7){
                Console.WriteLine($"Aprovado, promedio: {promedio}");
            }else{
                if(promedio < 7 && promedio >=5){
                    Console.WriteLine($"Suspenso, promedio: {promedio}");
                }else{
                    Console.WriteLine($"Reprobado, promedio: {promedio}");
                }
            }
        }
    }
}