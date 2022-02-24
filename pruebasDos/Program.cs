namespace PruebaDos{
    class Program{
        static void Main(string[] args){
           //Confeccionar un programa que lea por teclado tres números distintos y nos muestre el mayor.
            int num1, num2, num3;
            string linea;

            Console.WriteLine("Ingrese primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese numero dos: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("Ingrese numero tres: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if(num1 > num2 && num1 > num3){
                Console.WriteLine($"{num1} es el mayor");
            }else{
                if(num2 > num3){
                    Console.WriteLine($"{num2} es el mayor");
                }else{
                    Console.WriteLine($"{num3} es el mayor");
                }
            }

        }
    }
}
