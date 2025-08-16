using System;

namespace Ejercicio_2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Solicitar al usuario que ingrese su edad
            Console.Write("Por favor, ingresa tu edad: ");
            string edad = Console.ReadLine();

            if (int.TryParse(edad, out int edadNumerica))
            {
                // Verificar si la edad es mayor o igual a 18
                if (edadNumerica >= 18)
                {
                    Console.WriteLine("Eres mayor de edad.");
                }
                else
                {
                    Console.WriteLine("Eres menor de edad.");
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingresa un número válido para la edad.");
            
           }
        }
    }
}
