// See https://aka.ms/new-console-template for more information
string linea;
int opcion;

Console.WriteLine("Escoja una opcion:");
Console.WriteLine("1. Se desea guardar los sueldos de 5 operarios.\n"+
    "2. Definir un vector de 5 componentes de tipo float que representen las alturas de 5 personas.\n"+
    "Obtener el promedio de las mismas. Contar cuántas personas son más altas que el promedio y cuántas más bajas.\n"+
    "3. Una empresa tiene dos turnos (mañana y tarde) en los que trabajan 8 empleados (4 por la mañana y 4 por la tarde)\n"+
    "Confeccionar un programa que permita almacenar los sueldos de los empleados agrupados por turno.\n"+
    "Imprimir los gastos en sueldos de cada turno.\n"+
    "4. Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:\n"+
    "El valor acumulado de todos los elementos del vector.\n"+
    "El valor acumulado de los elementos del vector que sean mayores a 36.\n"+
    "Cantidad de valores mayores a 50.\n"+
    "5. Realizar un programa que pida la carga de dos vectores numéricos enteros de 4 elementos.\n"+
    "Obtener la suma de los dos vectores, dicho resultado guardarlo en un tercer vector del mismo tamaño. Sumar componente a componente.\n"+
    "6. Se tienen las notas del primer parcial de los alumnos de dos cursos, el curso A y el curso B, cada curso cuenta con 5 alumnos.\n"+
    "Realizar un programa que muestre el curso que obtuvo el mayor promedio general.\n"+
    "7. Cargar un vector de 10 elementos y verificar posteriormente si el mismo está ordenado de menor a mayor.");
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
        quinto();
        break;
    case 6:
        sexto();
        break;
    case 7:
        septimo();
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

void cuarto(){
    VectorCuatro vectorCuatro = new VectorCuatro();
    vectorCuatro.Iniciar();
    vectorCuatro.Suma();
    vectorCuatro.MayoresTreintaYSeis();
    vectorCuatro.MayoresCincuenta();
}

void quinto(){
    VectorCinco vectorCinco = new VectorCinco();
    vectorCinco.Inicializar();
    vectorCinco.SumaVectores();
}

void sexto(){
    VectorSeis vectorSeis = new VectorSeis();
    vectorSeis.Iniciar();
    vectorSeis.PromedioMayor();
}

void septimo(){
    VectorSiete vectorSiete = new VectorSiete();
    vectorSiete.Inicializar();
    vectorSiete.verificadorOrdenamiento();
    vectorSiete.Ordenado();
}
