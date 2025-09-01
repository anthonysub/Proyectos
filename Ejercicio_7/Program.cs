using System;

namespace EjerciciosExcepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            // ===============================
            // EJERCICIO 1: División con manejo de excepciones
            // ===============================
            try
            {
                Console.WriteLine("=== División de dos números ===");
                Console.Write("Ingrese el primer número: ");
                double num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Ingrese el segundo número: ");
                double num2 = Convert.ToDouble(Console.ReadLine());

                if (num2 == 0)
                {
                    Console.WriteLine("Error: No se puede dividir entre cero.");
                }
                else
                {
                    double resultado = num1 / num2;
                    Console.WriteLine($"Resultado: {num1} / {num2} = {resultado}");
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debe ingresar un número válido.");
            }

            Console.WriteLine(); // Salto de línea


            // ===============================
            // EJERCICIO 2: Validar precio
            // ===============================
            try
            {
                Console.WriteLine("=== Validación de Precio ===");
                Console.Write("Ingrese el precio del producto: ");
                string input = Console.ReadLine();

                if (!double.TryParse(input, out double precio))
                {
                    throw new FormatException("El precio debe ser numérico.");
                }

                if (precio <= 0)
                {
                    throw new ArgumentException("El precio debe ser un valor positivo.");
                }

                Console.WriteLine($"Precio registrado correctamente: Q{precio}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocurrió un error inesperado: {ex.Message}");
            }
        }
    }
}
