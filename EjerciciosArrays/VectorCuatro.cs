public class VectorCuatro{
    private int[] vector;

    public void Iniciar(){
        string linea;
        vector = new int[8];
        for(int i = 0; i < vector.Length; i++){
            Console.WriteLine("Ingrese Valor:");
            linea = Console.ReadLine();
            vector[i] = int.Parse(linea);
        }        
    }

    public void Suma(){
        int suma = 0;
        for(int i = 0; i < vector.Length; i++){
            suma = suma + vector[i];
        }
        Console.WriteLine($"Valor acumulador {suma}");
    }

    public void MayoresTreintaYSeis(){
        int suma = 0;
        for(int i = 0; i < vector.Length; i++){
            if(vector[i] > 36){
                suma = suma + vector[i];
            }
        }
        Console.WriteLine($"suma de mayores de 36: {suma}");
    }

    public void MayoresCincuenta(){
        int total = 0;
        for(int i = 0; i < vector.Length; i++){
            if(vector[i] > 50){
                total = total + 1;
            }
        }
        Console.WriteLine($"total mayores de 50: {total}");
    }
}