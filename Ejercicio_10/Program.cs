using System;
using System.Collections.Generic;

namespace Ejercicio10_Polimorfismo
{
    // --------- Parte 1: Clase abstracta Figura ---------
    public abstract class Figura
    {
        public abstract double CalcularArea();
    }

    public class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double radio)
        {
            Radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * Radio * Radio;
        }
    }

    public class Rectangulo : Figura
    {
        public double Ancho { get; set; }
        public double Alto { get; set; }

        public Rectangulo(double ancho, double alto)
        {
            Ancho = ancho;
            Alto = alto;
        }

        public override double CalcularArea()
        {
            return Ancho * Alto;
        }
    }

    // --------- Parte 2: Clase base con método virtual ---------
    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void Presentarse()
        {
            Console.WriteLine($"Hola, soy una persona. Mi nombre es {Nombre}");
        }
    }

    public class Estudiante : Persona
    {
        public string Carrera { get; set; }

        public Estudiante(string nombre, string carrera) : base(nombre)
        {
            Carrera = carrera;
        }

        public override void Presentarse()
        {
            Console.WriteLine($"Hola, soy {Nombre} y estudio la carrera de {Carrera}");
        }
    }

    public class Profesor : Persona
    {
        public string Materia { get; set; }

        public Profesor(string nombre, string materia) : base(nombre)
        {
            Materia = materia;
        }

        public override void Presentarse()
        {
            Console.WriteLine($"Hola, soy el profesor {Nombre} y enseño {Materia}");
        }
    }

    // --------- Programa Principal ---------
    class Program
    {
        static void Main(string[] args)
        {
            // --- Parte 1: Polimorfismo con Figura ---
            List<Figura> figuras = new List<Figura>();
            figuras.Add(new Circulo(5));
            figuras.Add(new Rectangulo(4, 6));

            Console.WriteLine("Áreas de las Figuras:");
            foreach (var figura in figuras)
            {
                Console.WriteLine($"Área: {figura.CalcularArea():0.00}");
            }

            Console.WriteLine();

            // --- Parte 2: Polimorfismo con Personas ---
            List<Persona> personas = new List<Persona>();
            personas.Add(new Persona("Carlos"));
            personas.Add(new Estudiante("Ana", "Ingeniería"));
            personas.Add(new Profesor("Luis", "Matemáticas"));

            Console.WriteLine("Presentaciones:");
            foreach (var persona in personas)
            {
                persona.Presentarse();
            }

            Console.ReadKey();
        }
    }
}
