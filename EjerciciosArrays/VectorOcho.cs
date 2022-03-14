public class VectorOcho{
    private int[] vectorUno;

    public void Inicializar(){
        string linea;
        int tamanio;
        Console.WriteLine("Ingrese tamanio del vector: ");
        linea = Console.ReadLine();
        tamanio = int.Parse(linea);

        vectorUno = new int[tamanio];
        for(int i = 0; i < vectorUno.Length; i++){
            Console.WriteLine("Ingrese valor:");
            linea = Console.ReadLine();
            vectorUno[i] = int.Parse(linea);
        }
    }

    public void Suma(){
        int suma = 0;
        for(int i = 0; i < vectorUno.Length; i++){
            suma = suma + vectorUno[i];
        }
        Console.WriteLine($"La suma es: {suma}");
    }
}