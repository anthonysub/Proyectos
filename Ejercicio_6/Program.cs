using System;
using System.Collections.Generic;
using System.Linq;

namespace EjerciciosLINQ
{
    // Clase para el primer ejercicio
    class EstudianteNota
    {
        public string Nombre { get; set; }
        public int Nota { get; set; }
    }

    // Clase para el segundo ejercicio
    class EstudianteEdad
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public double Estatura { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // ===============================
            // EJERCICIO 1: Estudiantes Aprobados
            // ===============================
            List<EstudianteNota> estudiantesNotas = new List<EstudianteNota>()
            {
                new EstudianteNota(){ Nombre="Ana", Nota=85 },
                new EstudianteNota(){ Nombre="Luis", Nota=50 },
                new EstudianteNota(){ Nombre="Carlos", Nota=70 },
                new EstudianteNota(){ Nombre="Marta", Nota=40 }
            };

            var aprobados = from e in estudiantesNotas
                            where e.Nota >= 61
                            select e;

            Console.WriteLine("=== Estudiantes Aprobados (Nota >= 61) ===");
            foreach (var est in aprobados)
            {
                Console.WriteLine($"{est.Nombre} - Nota: {est.Nota}");
            }

            Console.WriteLine(); // Salto de línea


            // ===============================
            // EJERCICIO 2: Filtrar por Edad y Estatura
            // ===============================
            List<EstudianteEdad> estudiantesEdad = new List<EstudianteEdad>()
            {
                new EstudianteEdad(){ Nombre="Ana", Edad=20, Estatura=1.70 },
                new EstudianteEdad(){ Nombre="Luis", Edad=17, Estatura=1.72 },
                new EstudianteEdad(){ Nombre="Carlos", Edad=22, Estatura=1.60 },
                new EstudianteEdad(){ Nombre="Marta", Edad=19, Estatura=1.75 }
            };

            var filtrados = from e in estudiantesEdad
                            where e.Edad >= 18 && e.Estatura > 1.65
                            select e;

            Console.WriteLine("=== Estudiantes Mayores de Edad y Estatura > 1.65m ===");
            foreach (var est in filtrados)
            {
                Console.WriteLine($"{est.Nombre} - Edad: {est.Edad}, Estatura: {est.Estatura}m");
            }
        }
    }
}
