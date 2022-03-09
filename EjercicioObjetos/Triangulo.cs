class Triangulo{
    private int lado1, lado2, lado3;

    public void Inicializar(){
        string linea;

        Console.WriteLine("Medida Lado 1: ");
        linea = Console.ReadLine();
        lado1 = int.Parse(linea);

        Console.WriteLine("Medida Lado 2: ");
        linea = Console.ReadLine();
        lado2 = int.Parse(linea);

        Console.WriteLine("Medida Lado 3: ");
        linea = Console.ReadLine();
        lado3 = int.Parse(linea);
    }

    public void LadoMayor(){
        Console.Write("lado mayor: ");
        if(lado1 > lado2 && lado1 > lado3){
            Console.WriteLine($"Lado uno es mayor: {lado1}");
        }else{
            if(lado2 > lado3){
                Console.WriteLine($"Lado dos es mayor: {lado2}");
            }else{
                Console.WriteLine($"Lado tres es el mayor: {lado3}");
            }
        }
    }

    public void EsEquilatero(){
        if(lado1 == lado2 && lado1 == lado3){
            Console.WriteLine("Es un triangulo Equilatero");
        }else{
            Console.WriteLine("No es un triangulo Equilatero");
        }
    }
}