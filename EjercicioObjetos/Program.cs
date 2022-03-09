// See https://aka.ms/new-console-template for more information
string linea;
int opcion;

Console.WriteLine("Escoja una opcion:");
Console.WriteLine("1. Confeccionar una clase que permita carga el nombre y la edad de una persona.\n"+
    "Mostrar los datos cargados. Imprimir un mensaje si es mayor de edad (edad>=18)\n"+
    "2. Desarrollar un programa que cargue los lados de un triángulo e implemente los siguientes métodos:\n"+
    "inicializar los atributos, imprimir el valor del lado mayor y otro método que muestre si es equilátero o no.\n"+
    "3. Desarrollar una clase que represente un punto en el plano y tenga los siguientes métodos: cargar los valores\n"+
    "de x e y, imprimir en que cuadrante se encuentra dicho punto (concepto matemático, primer cuadrante si x e y\n"+
    "son positivas, si x<0 e y>0 segundo cuadrante, etc.)\n"+
    "4. Desarrollar una clase que represente un Cuadrado y tenga los siguientes métodos:\n"+
    "cargar el valor de su lado, imprimir su perímetro y su superficie.\n"+
    "5. Confeccionar una clase que represente un empleado. Definir como atributos su nombre y su sueldo.\n"+
    "Confeccionar los métodos para la carga, otro para imprimir sus datos y por último uno que imprima un\n"+
    "mensaje si debe pagar impuestos (si el sueldo supera a 3000)\n"+
    "6. Implementar la clase operaciones. Se deben cargar dos valores enteros, calcular su suma, resta,\n"+
    "multiplicación y división, cada una en un método, imprimir dichos resultados.");
linea = Console.ReadLine();
opcion = int.Parse(linea);

switch(opcion){
    case 1:
        primero();
        break;
    case 2:
        segundo();
        break;
    case 3:
        tercero();
        break;
    case 4:
        cuarto();
        break;
    case 5:
        cinco();
        break;
    case 6:
        sexto();
        break;
    default:
        Console.WriteLine("Opcion no valida");
        break;
}

void primero(){
    Persona persona1 = new Persona();
    persona1.inicializar();
    persona1.imprimir();
    persona1.EsMayorEdad();
}

void segundo(){
    Triangulo triangulo1 = new Triangulo();
    triangulo1.Inicializar();
    triangulo1.LadoMayor();
    triangulo1.EsEquilatero();
}

void tercero(){
    Punto punto1 = new Punto();
    punto1.Inicializar();
    punto1.ImprimirCuadrante();
}

void cuarto(){
    Cuadrado cuadrado1 = new Cuadrado();
    cuadrado1.Inicializar();
    cuadrado1.ImprimirPerimetro();
    cuadrado1.ImprimirSuperficie();
}

void cinco(){
    Empleado empleado1 = new Empleado();
    empleado1.Inicializar();
    empleado1.Imprimir();
    empleado1.PagaImpuestos();
}

void sexto(){
    Operacion operacion1 = new Operacion();
    operacion1.Inicializar();
    operacion1.suma();
    operacion1.resta();
    operacion1.multiplicacion();
    operacion1.division();
}