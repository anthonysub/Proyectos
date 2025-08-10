using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Calculadora Básica");
            Console.WriteLine("1. Sumar");
            Console.WriteLine("2. Restar");
            Console.WriteLine("3. Multiplicar");
            Console.WriteLine("4. Dividir");
            Console.WriteLine("5. Factorial");
            Console.WriteLine("6. Salir");
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "6")
                break;

            if (opcion == "5")
            {
                Console.Write("Introduce un número entero para el factorial: ");
                if (int.TryParse(Console.ReadLine(), out int n) && n >= 0)
                {
                    Console.WriteLine($"El factorial de {n} es {Factorial(n)}");
                }
                else
                {
                    Console.WriteLine("Entrada inválida.");
                }
                continue;
            }

            Console.Write("Introduce el primer número: ");
            if (!double.TryParse(Console.ReadLine(), out double num1))
            {
                Console.WriteLine("Entrada inválida.");
                continue;
            }

            Console.Write("Introduce el segundo número: ");
            if (!double.TryParse(Console.ReadLine(), out double num2))
            {
                Console.WriteLine("Entrada inválida.");
                continue;
            }

            switch (opcion)
            {
                case "1":
                    Console.WriteLine($"Resultado: {num1 + num2}");
                    break;
                case "2":
                    Console.WriteLine($"Resultado: {num1 - num2}");
                    break;
                case "3":
                    Console.WriteLine($"Resultado: {num1 * num2}");
                    break;
                case "4":
                    if (num2 == 0)
                        Console.WriteLine("No se puede dividir por cero.");
                    else
                        Console.WriteLine($"Resultado: {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Opción inválida.");
                    break;
            }
        }
    }

    static long Factorial(int n)
    {
        long resultado = 1;
        for (int i = 2; i <= n; i++)
            resultado *= i;
        return resultado;
    }
}