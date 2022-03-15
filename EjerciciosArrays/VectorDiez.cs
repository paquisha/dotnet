public class VectorDiez{
    private int[] Vector;
    private int menor;

    public void Cargar(){
        string linea;
        int tamanio;
        Console.Write("Ingrese tamanio de vector: ");
        linea = Console.ReadLine();
        tamanio = int.Parse(linea);
        Vector = new int[tamanio];
        for(int i = 0; i < Vector.Length; i++){
            Console.Write("Ingrese componente: ");
            linea = Console.ReadLine();
            Vector[i] = int.Parse(linea);
        }
    }
    public void MenorElemento(){
        menor = Vector[0];
        for(int i = 1; i < Vector.Length; i++){
            if(Vector[i] < menor){
                menor = Vector[i];
            }
        }
        Console.WriteLine($"elemento menor es: {menor}");
    }
    public void RepiteMenor(){
        int cant = 0;
        for(int i = 0; i < Vector.Length; i++){
            if(Vector[i] == menor){
                cant++;
            }
        }
        if(cant > 1){
            Console.WriteLine("se repite el menor en el vector");
        }else{
            Console.WriteLine("No se repite el menor en el vector");
        }
    }
}