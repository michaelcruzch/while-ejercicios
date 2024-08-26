using System;

namespace Ejercicio_09
{
    class Program
    {
        static void Main(string[] args)
        {
            //Realizar nuevamente el ejercicio 8 pero ahora debe devolver ademas la posicion en la que
            // fue encontrado cada uno de los minimos.

            int n, minimo1, posicion, posicion1, minimo2, posicion2, bandera;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            minimo1 = n;
            minimo2 = 0;
            bandera = 0;
            posicion = 1;
            posicion2 = 0;
            posicion1 = posicion;

            while (n != 0)
            {
                if(n < minimo1){
                    minimo2 = minimo1;
                    minimo1 = n;
                    posicion2 = posicion1;
                    posicion1 = posicion;
                    bandera = 1;
                    
                }else if(bandera == 0){
                    minimo2 = n;
                    bandera = 1;
                    posicion2 = posicion;
                }else if(n < minimo2){
                    minimo2 = n;
                    posicion2 = posicion;
                }
                posicion++;

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("el minimo es: " + minimo1 + " en la posicicion: " + posicion1);
            Console.WriteLine("el segundo minimo es: " + minimo2 + " en la posicion: " + posicion2);


        }
    }
}
