public class VectorSiete{
    private int[] vectorUno;

    public void Inicializar(){
        string linea;
        vectorUno = new int[10];
        Console.WriteLine("Carga de valores:");
        for(int i = 0; i < vectorUno.Length; i++){
            Console.WriteLine("Ingrese numero: ");
            linea = Console.ReadLine();
            vectorUno[i] = int.Parse(linea);
        }
    }
    public void verificadorOrdenamiento(){
        int orden = 1;
        for(int i = 0; i < vectorUno.Length - 1; i++){
            if(vectorUno[i + 1] < vectorUno[i]){
                orden = 0;
            }
        }
        if(orden == 1){
            Console.WriteLine("Esta ordenado de mayor a menor");
        }else{
            Console.WriteLine("No esta ordenado de mayor a menor");
        }
    }
    public void Ordenado(){
        Array.Sort(vectorUno);
        Console.WriteLine("Array ordenado");
        foreach(int value in vectorUno){
            Console.WriteLine(value + " ");
        }
    }
}