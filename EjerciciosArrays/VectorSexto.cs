public class VectorSeis{
    private float[] cursoA;
    private float[] cursoB;
    public void Iniciar(){
        string linea;
        cursoA = new float[5];
        cursoB = new float[5];
        Console.WriteLine("Notas Curso A");
        for(int i = 0; i < cursoA.Length; i++){
            Console.WriteLine("Ingrese calificacion:");
            linea = Console.ReadLine();
            cursoA[i] = float.Parse(linea);
        }
        Console.WriteLine("Notas curso B");
        for(int i = 0; i < cursoB.Length; i++){
            Console.WriteLine("Ingrese calificacion:");
            linea = Console.ReadLine();
            cursoB[i] = float.Parse(linea);
        }
    }
    public void PromedioMayor(){
        //suma promedios
        float sumaA = 0;
        float sumaB = 0;
        float promedioA;
        float promedioB;
        for(int i = 0; i < cursoA.Length; i++){
            sumaA = sumaA + cursoA[i];
        }
        for(int i = 0; i < cursoB.Length; i++){
            sumaB = sumaB + cursoB[i];
        }

        promedioA = sumaA/cursoA.Length;
        promedioB = sumaB/cursoB.Length;

        if(sumaA > sumaB){
            Console.WriteLine($"promedio cursoA es mayor {promedioA}");
        }else{
            Console.WriteLine($"promedio cursoB es mayor {promedioB}");
        }
    }
}