class Cuadrado{
    private int lado;

    public void Inicializar(){
        Console.Write("Ingrese el valor del lado: ");
        string linea;
        linea = Console.ReadLine();
        lado = int.Parse(linea);
    }

    public void ImprimirPerimetro(){
       int perimetro;
       perimetro = lado * 4;
       Console.WriteLine($"El peritro es: {perimetro}");
    }

    public void ImprimirSuperficie(){
        int superficie;
        superficie = lado * lado;
        Console.WriteLine($"Superficie es: {superficie}");        
    }
}