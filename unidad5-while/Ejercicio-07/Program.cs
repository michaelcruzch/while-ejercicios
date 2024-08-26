using System;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de numeros que corta cuando se ingresa un cero y luego mostrar por pantalla
            // el maximo de ellos y la posicion en la que fue ingresado.

            int n, pos = 0, max = 0;

            Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            while (n != 0){
            
                if(pos == 0){
                    max = n;
                    pos = 1;
                }else if(n > max){
                    max = n;
                    pos++;
                }

                Console.WriteLine("Ingrese un numero");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("el numero maximo es: " + max + " y la posicion es: " + pos);
        }
    }
}