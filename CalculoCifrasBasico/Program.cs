namespace CalculoCifrasBasico{
    class Program{
        static void Main(string[] args){
            int num;
            string linea;

            Console.WriteLine("Ingresa numero: ");
            linea = Console.ReadLine();
            num = int.Parse(linea);

            if(num < 10){
                Console.WriteLine($"numero {num} tiene una cifra");
            }else{
                Console.WriteLine($"numero {num} tiene dos cifras");
            }
        }
    }
}