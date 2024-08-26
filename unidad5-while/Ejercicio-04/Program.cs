using System;

namespace Ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite dos numeros y luego muestre los numeros entre el menor y el mayor de ellos.

            int a, b, mayor, menor;

            Console.WriteLine("ingrese un numero:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese un numero:");
            b = int.Parse(Console.ReadLine());

            if(a > b){
                mayor = a;
                menor = b;
            }else{
                mayor = b;
                menor = a;
            }

            while (menor < mayor)
            {
                Console.WriteLine(menor);
                menor++;
            }


        }
    }
}
