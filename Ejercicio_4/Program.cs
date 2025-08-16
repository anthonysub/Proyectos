using System;

namespace Ejercicio_4
{
    class Program
    {

        public static int Sumar(int a, int b) // Cambiado a static
        {
        return a + b;
        }

        public static int area(int a, int b) // Cambiado a static
        {
        return a * b;
        }

        public static int numero(int a) // Cambiado a static
        {
            if (a % 2 == 0)
            {
                Console.WriteLine($"{a} es un número par.");
            }
            else
            {
                Console.WriteLine($"{a} es un número impar.");
            }
            return a;
        }
        // Llamada:
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Calcular área");
            Console.WriteLine("3. Numero impar o par");
            Console.Write("Seleccione una opción: ");

            if (int.TryParse(Console.ReadLine(), out int opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.Write("Ingrese primer numero: ");
                        int.TryParse(Console.ReadLine(), out int numero1);
                        Console.Write("Ingrese segundo numero: ");
                        int.TryParse(Console.ReadLine(), out int numero2);
                        Console.WriteLine($"La suma de {numero1} + {numero2} es: {Sumar(numero1, numero2)}"); // Corregida la salida
                        break;
                    case 2:
                        Console.Write("Ingrese base: ");
                        int.TryParse(Console.ReadLine(), out int baseRectangulo);
                        Console.Write("Ingrese altura: ");
                        int.TryParse(Console.ReadLine(), out int alturaRectangulo);
                        Console.WriteLine($"El área del rectángulo es: {area(baseRectangulo, alturaRectangulo)}");
                        break;
                    case 3:
                        Console.Write("Ingrese un número: ");
                        int.TryParse(Console.ReadLine(), out int numeroParImpar);
                        numero(numeroParImpar);
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida.");
            }
        }
    }
}
