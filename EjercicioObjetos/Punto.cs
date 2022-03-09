class Punto{
    private int x, y;

    public void Inicializar(){
        string linea;
        Console.WriteLine("Ingrese coordenada x: ");
        linea = Console.ReadLine();
        x = int.Parse(linea);
        Console.WriteLine("Ingrese coordenada y: ");
        linea = Console.ReadLine();
        y = int.Parse(linea);
    }

    public void ImprimirCuadrante(){
        if(x > 0 && y > 0){
            Console.WriteLine("se encuentra en el primer cuadrante");
        }else{
            if(x < 0 && y > 0){
                Console.WriteLine("se encuentra en el segundo cuadrante");
            }else{
                if(x < 0 && y < 0){
                    Console.WriteLine("se encuentra en el tercer cuadrante");
                }else{
                    if(x > 0 && y < 0){
                        Console.WriteLine("se encuentra en el cuarto cuadrante");
                    }
                }
            }
        }
    }
}