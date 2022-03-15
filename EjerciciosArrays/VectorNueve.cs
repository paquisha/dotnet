public class VectorNueve{
    private string[] nombre;
    private float[] sueldos;
    public void Cargar(){
        nombre = new string[5];
        sueldos = new float[5];

        for(int i = 0; i < nombre.Length; i++){
            Console.Write("Ingrese el nombre del empleado: ");
            nombre[i] = Console.ReadLine();
            Console.Write("Ingrese el sueldo: ");
            string linea = Console.ReadLine();
            sueldos[i] = float.Parse(linea);
        }
    }
    public void MayorSueldo(){
        float mayor = sueldos[0];
        int pos = 0;
        for(int i = 1; i < nombre.Length; i++){
            if(sueldos[i] > mayor){
                mayor = sueldos[i];
                pos = i;
            }
        }
        Console.WriteLine($"El empleado con mayor sueldo es: {nombre[pos]}");
        Console.WriteLine($"Tiene un sueldo: {mayor}");
    }
}