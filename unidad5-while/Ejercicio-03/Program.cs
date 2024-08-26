using System;

namespace Ejercicio_03
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite la edad de un grupo de personas. El programa debera pedir edades hasta que
            //se ingrese una edad menor a 18 años. Debera mostrar por pantalla cuantas personas mayores se registraron.

            int edad, con = 0;

            Console.WriteLine("ingrese la edad:");
            edad = int.Parse(Console.ReadLine());

            while (edad > 18)
            {
                con++;
                Console.WriteLine("Ingrese la edad");
                edad = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Las personas mayores a 18 son: " + con);
        }
    }
}
