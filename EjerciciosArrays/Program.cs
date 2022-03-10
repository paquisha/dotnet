// See https://aka.ms/new-console-template for more information
string linea;
int opcion;

Console.WriteLine("Escoja una opcion:");
Console.WriteLine("1. Se desea guardar los sueldos de 5 operarios.\n"+
    "2. Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.\n"+
    "Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.\n"+
    "3. Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde)\n"+
    "Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por turno.\n"+
    "Imprimir los gastos en sueldos de cada turno.\n");
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
    default:
        Console.WriteLine("Opcion no valida");
        break;
}

void primero(){
    VectorUno vectorPrueba = new VectorUno();
    vectorPrueba.Cargar();
    vectorPrueba.Imprimir();
}

void segundo(){
    VectorDos vectorDos = new VectorDos();
    vectorDos.Cargar();
    vectorDos.CalcularPromedio();
    vectorDos.MayoresMenores();
}

void tercero(){
   VectorTres vectorTres = new VectorTres();
   vectorTres.Cargar();
   vectorTres.CalcularGastos(); 
}
