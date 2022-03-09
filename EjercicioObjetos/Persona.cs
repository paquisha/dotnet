class Persona{
    public string nombre;
    public int edad;

    public void inicializar(){
        Console.WriteLine("Ingrese nombre: ");
        nombre = Console.ReadLine();
        string linea;
        Console.WriteLine("Ingrese edad: ");
        linea = Console.ReadLine();
        edad = int.Parse(linea); 
    }

    public void imprimir(){
        Console.WriteLine($"Nombre: {nombre}");
        Console.WriteLine($"Edad: {edad}");
    }

    public void EsMayorEdad(){
        if(edad >= 18){
            Console.WriteLine("Es mayor de edad");
        }else{
            Console.WriteLine("No es mayor de edad");
        }
    }
}