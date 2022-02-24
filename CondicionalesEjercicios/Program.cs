namespace CondicionalesEjercicios{
    class Program{
        static void Main(string[] args){
            int num1, num2;
            string linea;

            Console.WriteLine("Ingrese primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("ingrese el segundo numero: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            if(num1 > num2){
                Console.WriteLine("la suma es: " + (num1 + num2) + "\n");
                Console.WriteLine("la resta es: "+ (num1 - num2));
            }else{
                Console.WriteLine("la multiplicacion es: " + (num1 * num2) +"\n");
                Console.WriteLine("la division es: " + (num1 / num2));
            }

        }
    }
}
