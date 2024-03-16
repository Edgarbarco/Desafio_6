using System;

namespace NumeroPrimo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar al usuario que ingrese un número
            Console.WriteLine("Ingrese un número entero positivo: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)

            {
                //Variable para determinar si el número es primo
                bool esPrimo = true;

                //Recorrer todos los números desde 2 hasta la raíz cuadrada del número ingresado
                for (int i = 2; i <= Math.Sqrt(numero); i++)
                {
                    //Si el número actual es divisible por el número que se está evaluando, no es primo
                    if (numero % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }
                }

                //Si el número es primo, mostrar un mensaje
                if (esPrimo)
                {
                    Console.WriteLine("El número {0} es primo", numero);
                }
                else
                {
                    Console.WriteLine("El número {0} no es primo", numero);
                }
            }
        }
    }

}
