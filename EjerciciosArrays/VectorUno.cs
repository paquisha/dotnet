public class VectorUno{
    private int[] sueldos;
    public async void Cargar(){
        sueldos = new int[5];
        for(int i = 0; i < 5; i++){
            Console.WriteLine("Ingrese valor del componente: ");
            string linea = Console.ReadLine();
            sueldos[i] = int.Parse(linea);
        }
    }

    public async void Imprimir(){
        for(int i = 0; i < 5; i++){
            Console.WriteLine(sueldos[i]);
        }
    }
}