using System;

namespace Ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que solicite una lista de numeros que corta cuando se ingresa un cero y luego emitir por pantalla
            //el maximo de los numeros negativos y el minimo de los numeros positivos.

            int n, banderaNegativo = 0, BanderaPositivo = 0, maxNegativo = 0, minPositivo = 0;

            Console.WriteLine("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            while (n != 0)
            {
                if(n < 0){
                    if(banderaNegativo == 0){
                        maxNegativo = n;
                        banderaNegativo = 1;
                    }else if(n < maxNegativo)
                        maxNegativo = n;
                }else if(BanderaPositivo == 0){
                    minPositivo = n;
                    BanderaPositivo = 1;
                }else if(n < minPositivo)
                    minPositivo = n;

                Console.WriteLine("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El maximo de numeros negativos es: " + maxNegativo + " El minimo de numero positivos es: " + minPositivo);
            
        }
    }
}
