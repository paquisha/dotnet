public class VectorCinco{
    private int[] elementoUno;
    private int[] elementoDos;

    public void Inicializar(){
        string linea;
        elementoUno = new int[4];
        elementoDos = new int[4];

        Console.WriteLine("Primer Array");
        for(int i = 0; i < elementoUno.Length; i++){
            Console.WriteLine("Ingrese valor:");
            linea = Console.ReadLine();
            elementoUno[i] = int.Parse(linea);
        }

        Console.WriteLine("Segundo Array");
        for(int i = 0; i < elementoDos.Length; i++){
            Console.WriteLine("Ingrese valor:");
            linea = Console.ReadLine();
            elementoDos[i] = int.Parse(linea);
        }
    }

    public void SumaVectores(){
        int[] vectorSuma = new int[4];
        for(int i = 0; i < vectorSuma.Length; i++){
            vectorSuma[i] = elementoUno[i] + elementoDos [i]; 
        }
        Console.WriteLine("Suma de cada elemento: ");
        for(int i = 0; i < 4; i++){
            Console.WriteLine($"suma: {vectorSuma[i]}");
        }
    }
}