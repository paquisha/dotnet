float sueldo;
string linea;
Console.WriteLine("Ingrese el sueldo: ");
linea = Console.ReadLine();
sueldo = float.Parse(linea);

if(sueldo > 3000)
{
    Console.WriteLine("Esta persona debe abonar impuestos");
}
else
{
    Console.WriteLine("no debe pagar impuestos");
}
Console.ReadKey();
