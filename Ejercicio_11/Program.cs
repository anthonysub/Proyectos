using System;
using System.Collections.Generic;

namespace EjemploGeneral
{
    // ================================
    // 1️⃣ CLASE COMPUTADORA
    // ================================
    public class Monitor
    {
        public string Marca { get; set; }
        public int Pulgadas { get; set; }

        public Monitor(string marca, int pulgadas)
        {
            Marca = marca;
            Pulgadas = pulgadas;
        }
    }

    public class Teclado
    {
        public string Tipo { get; set; }
        public string Idioma { get; set; }

        public Teclado(string tipo, string idioma)
        {
            Tipo = tipo;
            Idioma = idioma;
        }
    }

    public class Mouse
    {
        public string Tipo { get; set; }
        public int DPI { get; set; }

        public Mouse(string tipo, int dpi)
        {
            Tipo = tipo;
            DPI = dpi;
        }
    }

    public class Computadora
    {
        public Monitor Monitor { get; set; }
        public Teclado Teclado { get; set; }
        public Mouse Mouse { get; set; }

        public Computadora(Monitor monitor, Teclado teclado, Mouse mouse)
        {
            Monitor = monitor;
            Teclado = teclado;
            Mouse = mouse;
        }

        public void MostrarDetalles()
        {
            Console.WriteLine("=== COMPUTADORA ===");
            Console.WriteLine($"Monitor: {Monitor.Marca}, {Monitor.Pulgadas}\"");
            Console.WriteLine($"Teclado: {Teclado.Tipo}, idioma {Teclado.Idioma}");
            Console.WriteLine($"Mouse: {Mouse.Tipo}, {Mouse.DPI} DPI\n");
        }
    }

    // ================================
    // 2️⃣ SISTEMA DE BIBLIOTECA
    // ================================
    public class Libro
    {
        public string Titulo { get; set; }
        public string Autor { get; set; }

        public Libro(string titulo, string autor)
        {
            Titulo = titulo;
            Autor = autor;
        }
    }

    // COMPOSICIÓN: El estante contiene varios libros
    public class Estante
    {
        public List<Libro> Libros { get; set; } = new List<Libro>();

        public void AgregarLibro(Libro libro)
        {
            Libros.Add(libro);
        }

        public void MostrarLibros()
        {
            Console.WriteLine("Libros en el estante:");
            foreach (var libro in Libros)
            {
                Console.WriteLine($"- {libro.Titulo} de {libro.Autor}");
            }
        }
    }

    // AGREGACIÓN: El bibliotecario administra varios estantes
    public class Bibliotecario
    {
        public string Nombre { get; set; }
        public List<Estante> Estantes { get; set; } = new List<Estante>();

        public Bibliotecario(string nombre)
        {
            Nombre = nombre;
        }

        public void AdministrarEstante(Estante estante)
        {
            Estantes.Add(estante);
        }

        public void MostrarBiblioteca()
        {
            Console.WriteLine("=== BIBLIOTECA ===");
            Console.WriteLine($"Bibliotecario: {Nombre}");
            foreach (var estante in Estantes)
            {
                estante.MostrarLibros();
            }
            Console.WriteLine();
        }
    }

    // ================================
    // 3️⃣ CLASE CASA (Composición y Agregación)
    // ================================
    public class Habitacion
    {
        public string Nombre { get; set; }
        public int MetrosCuadrados { get; set; }

        public Habitacion(string nombre, int metros)
        {
            Nombre = nombre;
            MetrosCuadrados = metros;
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }

        public Persona(string nombre)
        {
            Nombre = nombre;
        }
    }

    public class Casa
    {
        // Composición
        public List<Habitacion> Habitaciones { get; set; } = new List<Habitacion>();

        // Agregación
        public Persona Propietario { get; set; }

        public Casa(Persona propietario)
        {
            Propietario = propietario;
        }

        public void AgregarHabitacion(Habitacion habitacion)
        {
            Habitaciones.Add(habitacion);
        }

        public void MostrarCasa()
        {
            Console.WriteLine("=== CASA ===");
            Console.WriteLine($"Propietario: {Propietario.Nombre}");
            Console.WriteLine("Habitaciones:");
            foreach (var h in Habitaciones)
            {
                Console.WriteLine($"- {h.Nombre} de {h.MetrosCuadrados} m²");
            }
            Console.WriteLine();
        }
    }

    // ================================
    // MÉTODO PRINCIPAL
    // ================================
    public class Program
    {
        public static void Main()
        {
            // --- COMPUTADORA ---
            var monitor = new Monitor("LG", 27);
            var teclado = new Teclado("Mecánico", "Español");
            var mouse = new Mouse("Óptico", 1600);
            var pc = new Computadora(monitor, teclado, mouse);
            pc.MostrarDetalles();

            // --- BIBLIOTECA ---
            var libro1 = new Libro("Cien Años de Soledad", "Gabriel García Márquez");
            var libro2 = new Libro("El Principito", "Antoine de Saint-Exupéry");
            var estante = new Estante();
            estante.AgregarLibro(libro1);
            estante.AgregarLibro(libro2);

            var bibliotecario = new Bibliotecario("Laura");
            bibliotecario.AdministrarEstante(estante);
            bibliotecario.MostrarBiblioteca();

            // --- CASA ---
            var persona = new Persona("Carlos");
            var casa = new Casa(persona);
            casa.AgregarHabitacion(new Habitacion("Sala", 20));
            casa.AgregarHabitacion(new Habitacion("Cocina", 15));
            casa.MostrarCasa();
        }
    }
}
