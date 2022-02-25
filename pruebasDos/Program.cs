namespace PruebaDos{
    class Program{
        static void Main(string[] args){
            /*
            De un operario se conoce su sueldo y los años de antigüedad. Se pide confeccionar un programa que lea los datos de entrada e informe:
            a) Si el sueldo es inferior a 500 y su antigüedad es igual o superior a 10 años, otorgarle un aumento del 20 %, mostrar el sueldo a pagar.
            b)Si el sueldo es inferior a 500 pero su antigüedad es menor a 10 años, otorgarle un aumento de 5 %.
            c) Si el sueldo es mayor o igual a 500 mostrar el sueldo en pantalla sin cambios.
            */
            float sueldo, porcentaje;
            int antiguedad;
            string linea;
            Console.WriteLine("Ingrese el sueldo del operario: ");
            linea = Console.ReadLine();
            sueldo = float.Parse(linea);
            Console.WriteLine("Ingrese la antiguedad del operario: ");
            linea = Console.ReadLine();
            antiguedad = int.Parse(linea);
            if(sueldo < 500 && antiguedad >= 10){
                porcentaje = 20*sueldo/100;
                sueldo = sueldo + porcentaje;
                Console.WriteLine($"sueldo mas aumento de 20%: {sueldo}");
            }else{
                if(sueldo < 500 && antiguedad < 10){
                    porcentaje = 5*sueldo/100;
                    sueldo = sueldo + porcentaje;
                    Console.WriteLine($"sueldo mas aumento de 5%: {sueldo}");
                }else{
                     Console.WriteLine($"sueldo del operario es: {sueldo}");
                }
            }

            //Escribir un programa que pida ingresar la coordenada de un punto en el plano, 
            //es decir dos valores enteros x e y (distintos a cero). Posteriormente imprimir 
            //en pantalla en que cuadrante se ubica dicho punto. (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0, etc.)

            /*int x, y;
            string linea;

            Console.WriteLine("Ingrese coordenada en x: ");
            linea = Console.ReadLine();
            x = int.Parse(linea);

            Console.WriteLine("Ingrese coordenada en y: ");
            linea = Console.ReadLine();
            y = int.Parse(linea);

            if(x > 0 && y > 0){
                Console.WriteLine($"({x} y {y}) estan en el primer cuadrante");
            }else{
                if(x < 0 && y > 0){
                    Console.WriteLine($"({x} y {y}) estan en el segundo cuadrante");
                }else{
                    if(x < 0 && y < 0){
                        Console.WriteLine($"({x} y {y} estan en el tercer cuadrante)");
                    }else{
                        if(x > 0 && y < 0){
                            Console.WriteLine($"({x} y {y} estan en el cuarto cuadrante)");
                        }
                    }
                }
            }*/
            
           /*Confeccionar un programa que lea por teclado tres números distintos y nos muestre el mayor.
            int num1, num2, num3;
            string linea;

            Console.WriteLine("Ingrese primer numero: ");
            linea = Console.ReadLine();
            num1 = int.Parse(linea);

            Console.WriteLine("Ingrese numero dos: ");
            linea = Console.ReadLine();
            num2 = int.Parse(linea);

            Console.WriteLine("Ingrese numero tres: ");
            linea = Console.ReadLine();
            num3 = int.Parse(linea);

            if(num1 > num2 && num1 > num3){
                Console.WriteLine($"{num1} es el mayor");
            }else{
                if(num2 > num3){
                    Console.WriteLine($"{num2} es el mayor");
                }else{
                    Console.WriteLine($"{num3} es el mayor");
                }
            }*/


        }
    }
}
