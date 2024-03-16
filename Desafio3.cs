using System;

namespace PromedioEstudiante
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables para almacenar la suma y la cantidad de calificaciones
            double sumaCalificaciones = 0;
            int cantidadCalificaciones = 0;

            //Bucle para ingresar las calificaciones
            while (true)
            {
                //Solicitar al usuario que ingrese una calificación
                Console.WriteLine("Ingrese una calificación (1-10) o escriba 'fin' para terminar: ");
                string input = Console.ReadLine() ?? "";

                //Verificar si el usuario escribió "fin"
                if ((input ?? "").ToLower() == "fin")
                {
                    break;
                }

                //Verificar si la entrada es un número
                double calificacion;
                if (!double.TryParse(input, out calificacion))
                {
                    Console.WriteLine("Entrada no válida. Ingrese un número entre 1 y 10.");
                    continue;
                }

                //Verificar si la calificación está entre 1 y 10
                if (calificacion < 1 || calificacion > 10)
                {
                    Console.WriteLine("La calificación debe estar entre 1 y 10.");
                    continue;
                }

                //Agregar la calificación a la suma
                sumaCalificaciones += calificacion;
                cantidadCalificaciones++;
            }

            //Calcular el promedio
            double promedio = sumaCalificaciones / cantidadCalificaciones;

            //Mostrar el promedio
            Console.WriteLine("El promedio del estudiante es: {0}", promedio);
        }
    }
}
