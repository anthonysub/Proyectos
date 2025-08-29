
using System;
using System.Collections.Generic;
using System.Linq;
public class Estudiante
{
    public string Nombre { get; set; }
    public double Nota { get; set; }
}


public class Program
{
    public static void Main()
    {
        // 1. Crear una lista de estudiantes
        List<Estudiante> estudiantes = new List<Estudiante>
        {
            new Estudiante { Nombre = "Ana", Nota = 85.5 },
            new Estudiante { Nombre = "Luis", Nota = 58.0 },
            new Estudiante { Nombre = "Marta", Nota = 92.0 },
            new Estudiante { Nombre = "Pedro", Nota = 70.0 },
            new Estudiante { Nombre = "Sofía", Nota = 60.5 }
        };

        // 2. Mostrar los aprobados (con nota >= 61)
        Console.WriteLine("--- Estudiantes Aprobados (Nota >= 61) ---");
        var aprobados = estudiantes.Where(e => e.Nota >= 61).ToList();
        
        if (aprobados.Any())
        {
            foreach (var estudiante in aprobados)
            {
                Console.WriteLine($"Nombre: {estudiante.Nombre}, Nota: {estudiante.Nota}");
            }
        }
        else
        {
            Console.WriteLine("No hay estudiantes aprobados en la lista.");
        }

        // 3. Calcular y mostrar el promedio general
        Console.WriteLine("\n--- Promedio General ---");
        if (estudiantes.Any())
        {
            double promedio = estudiantes.Average(e => e.Nota);
            Console.WriteLine($"El promedio general de la clase es: {promedio:F2}");
        }
        else
        {
            Console.WriteLine("No hay estudiantes en la lista para calcular el promedio.");
        }
    }
}