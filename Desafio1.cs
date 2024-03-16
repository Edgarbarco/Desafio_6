using System;

namespace NumerosPares
{
    class Program
    {
        static void Main(string[] args)
        {
            //Solicitar al usuario que ingrese un número
            Console.WriteLine("Ingrese un número entero positivo: ");
            if (int.TryParse(Console.ReadLine(), out int numero) && numero > 0)

            //Recorrer todos los números desde 1 hasta el número ingresado
            for (int i = 1; i <= numero; i++)
            {
                //Si el número actual es par, mostrarlo
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
