using System;

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite UN numero y luego calcule y emita un cartel aclaratorio si el mismo es primo o no es primo

            int n, d = 1, con = 0;

            Console.WriteLine("ingrese un numero:");
            n = int.Parse(Console.ReadLine());

            
            while (d <= n)
            {
                if(n % d == 0)
                    con++;

            }
            if(con == 2)
                Console.WriteLine("El numero es PRIMO");
            else
                Console.WriteLine("El numero NO es Primo");

        

        }
    }
}
