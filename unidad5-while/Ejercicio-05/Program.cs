using System;

namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que muestre los numeros del 1 al 100 de 5 en 5. Ejemplo: 0, 5, 10 ...

            int n = 0;

            while (n < 100)
            {
                n+=5;
                Console.WriteLine(n);

            }
        }
    }
}
