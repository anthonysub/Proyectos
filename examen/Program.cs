using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        try
        {
            // Lista genérica de notas
            List<double> notas = new List<double>();

            // Agregamos al menos 10 notas 
            notas.AddRange(new double[] {});

            double promedio = CalcularPromedio(notas);

            Console.WriteLine("Notas registradas:");
            foreach (var nota in notas)
            {
                Console.WriteLine(nota);
            }

            Console.WriteLine($"\nEl promedio de las notas es: {promedio:F2}");
        }
        catch (InvalidOperationException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }

    // Método para calcular el promedio
    static double CalcularPromedio(List<double> notas)
    {
        if (notas == null || notas.Count == 0)
            throw new InvalidOperationException("No se puede calcular el promedio de una lista vacía.");

        // Uso de LINQ para calcular el promedio
        return notas.Average();
    }
}
