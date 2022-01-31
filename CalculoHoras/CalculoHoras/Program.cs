int horasTrabajadas;
float costoHora;
float sueldo;
string linea;

Console.Write("ingresar horas trabajadas: ");
linea = Console.ReadLine();
horasTrabajadas = int.Parse(linea);

Console.Write("Ingrese pago por hora: ");
linea = Console.ReadLine();
costoHora = int.Parse(linea);

sueldo = horasTrabajadas * costoHora;

Console.Write("sueldo total: " + sueldo);
Console.ReadKey();
