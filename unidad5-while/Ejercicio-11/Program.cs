using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa para ingresar una lista de numeros que corta cuando se ingresa un cero y luego mostrar:
            //la cantidad de numeros primos, la cantidad de numeros pares, la cantidad de positivos y la cantidad de negativos.

            int n, con = 0, divisor = 1, primos = 0, pares = 0, negativos = 0, positivos = 0;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                while (divisor <= n)
                {
                    if(n % divisor == 0)
                        con++;
                    divisor++;    
                }  
            
            if(con == 2)
                primos++;
            if(n % 2 == 0)
                pares++;
            if(n > 0)
                positivos++;
            else
                negativos++;

            Console.WriteLine("Ingrese un numero:");
            n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("la cantidad de numeros primos es: " + primos);
            Console.WriteLine("La cantidad de numeros pares es: " + pares);
            Console.WriteLine("La cantidad de numeros positivos es: " + positivos);
            Console.WriteLine("La cantidad de numeros negativos es: " + negativos);
        }
    }
}
