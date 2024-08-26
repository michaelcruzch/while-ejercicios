using System;

namespace Ejercicio_08
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de numeros que corta cuando se ingresa un cero y luego mostrar por pantalla
            //el menor y el segundo menor

            int n, minimo1, minimo2, bandera;

            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            minimo1 = n;
            minimo2 = 0;
            bandera = 0;

            while (n != 0)
            {
                if(n < minimo1){
                    minimo2 = minimo1;
                    minimo1 = n;
                    bandera = 1;
                    
                    
                }else if(bandera == 0){
                    minimo2 = n;
                    bandera = 1;
                }else if(n < minimo2)
                    minimo2 = n;

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }

                Console.WriteLine("el numero minimo es: " + minimo1 + "el segundo  minimo es: " + minimo2);
            
                    
            
        }
    }
}
