public class VectorDos{
    private float[] alturas;
    private float promedio;

    public void Cargar(){
        alturas = new float[5];
        for(int i = 0; i < alturas.Length; i++){
            Console.WriteLine("Ingrese Altura de la persona: ");
            string linea = Console.ReadLine();
            alturas[i] = float.Parse(linea);
        }
    }

    public void CalcularPromedio(){
        float suma;
        suma = 0;
        for(int i = 0; i < alturas.Length; i++){
            suma = suma + alturas[i];
        }
        promedio = suma/alturas.Length;
        Console.WriteLine($"Promedio de alturas es {promedio}");
    }

    public void MayoresMenores(){
        int mayores = 0, menores = 0;
        for(int i = 0; i < alturas.Length; i++){
            if(alturas[i] > promedio){
                mayores++;
            }else{
                if(alturas[i] < promedio){
                    menores++;
                }
            }
        }
        Console.WriteLine($"Cantidad de personas mayores al promedio: {mayores}");
        Console.WriteLine($"Cantidad de personas menores al promedio: {menores}");
    }
}