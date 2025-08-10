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
            Console.Write("Seleccione una opción: ");
            string opcion = Console.ReadLine();

            if (opcion == "6")
                break;

            if (opcion == "5")
            {
                Console.Write("Ingrese un número entero para calcular el factorial: ");
                int n = int.Parse(Console.ReadLine());
                Console.WriteLine($"El factorial de {n} es {Factorial(n)}");
            }
            else
            {
                Console.Write("Ingrese el primer número: ");
                double num1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese el segundo número: ");
                double num2 = double.Parse(Console.ReadLine());

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
                        if (num2 != 0)
                            Console.WriteLine($"Resultado: {num1 / num2}");
                        else
                            Console.WriteLine("Error: División por cero.");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }
            }
            Console.WriteLine();
        }
    }

    static long Factorial(int n)
    {
        if (n < 0)
            throw new ArgumentException("El número debe ser no negativo.");
        long resultado = 1;
        for (int i = 2; i <= n; i++)
            resultado *= i;
        return resultado;
    }
}