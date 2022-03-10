public class VectorTres{
    private float[] turnoDia;
    private float[] turnoTarde;

    public async void Cargar(){
        string linea;
        turnoDia = new float[4];
        turnoTarde = new float[4];
        Console.WriteLine("Sueldos de empleados del turno de la ma;ana.");
        for(int i = 0; i < 4; i++){
            Console.Write("Ingrese sueldo: ");
            linea = Console.ReadLine();
            turnoDia[i] = float.Parse(linea);
        }
        Console.WriteLine("Sueldos de empleados del turno de la tarde");
        for(int i = 0; i < 4; i++){
            Console.Write("Ingrese sueldo:");
            linea = Console.ReadLine();
            turnoTarde[i] = float.Parse(linea);
        }
    }

    public async void CalcularGastos(){
        float dia = 0, tarde = 0;
        for(int i = 0; i < 4; i++){
            dia = dia + turnoDia[i];
            tarde = tarde + turnoTarde[i];
        }
        Console.WriteLine($"Total de gastos de la ma;ana {dia}");
        Console.WriteLine($"Total de gastos de la tarde: {tarde}");
    }
}