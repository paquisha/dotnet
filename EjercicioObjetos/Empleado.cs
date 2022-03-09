class Empleado{
    private string nombre;
    private float sueldo;

    public void Inicializar(){
        string linea;
        Console.WriteLine("Ingrese nombre: ");
        nombre = Console.ReadLine();
        Console.WriteLine("Ingrese sueldo: ");
        linea = Console.ReadLine();
        sueldo = float.Parse(linea);
    }

    public void Imprimir(){
        Console.WriteLine($"nombre: {nombre}");
        Console.WriteLine($"sueldo: {sueldo}");
    }

    public void PagaImpuestos(){
        if(sueldo > 3000){
            Console.WriteLine($"Empleado: {nombre}, debe pagar impuestos");
        }else{
            Console.WriteLine($"Empleado: {nombre}, no pagar impuestos");
        }
    }
}