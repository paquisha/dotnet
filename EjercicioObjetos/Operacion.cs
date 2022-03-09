class Operacion{
    private float valorUno, valorDos;

    public void Inicializar(){
        string linea;
        Console.WriteLine("Ingrese primer numero: ");
        linea = Console.ReadLine();
        valorUno = float.Parse(linea);
        Console.WriteLine("Ingrese segundo numero: ");
        linea = Console.ReadLine();
        valorDos = float.Parse(linea);
    }
    public void suma(){
        float suma = valorUno + valorDos;
        Console.WriteLine($"Suma es: {suma}");
    }    
    public void resta(){
        float resta = valorUno - valorDos;
        Console.WriteLine($"Resta es: {resta}");
    }
    public void multiplicacion(){
        float multiplicacion = valorUno * valorDos;
        Console.WriteLine($"Multiplicacion: {multiplicacion}");
    }
    public void division(){
        float division = valorUno / valorDos;
        Console.WriteLine($"Division: {division}");
    }
}