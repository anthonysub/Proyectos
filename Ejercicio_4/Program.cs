
using System;

class Libro
{
	public required string Titulo { get; set; }
	public required string Autor { get; set; }
	public int Anio { get; set; }
	public required string Genero { get; set; }

	public void MostrarDatos()
	{
		Console.WriteLine($"Título: {Titulo}");
		Console.WriteLine($"Autor: {Autor}");
		Console.WriteLine($"Año: {Anio}");
		Console.WriteLine($"Género: {Genero}");
	}
}

class Program
{
	static void Main(string[] args)
	{
		Libro libro = new Libro();

		Console.Write("Ingrese el título del libro: ");
		libro.Titulo = Console.ReadLine()!;

		Console.Write("Ingrese el autor del libro: ");
		libro.Autor = Console.ReadLine()!;

		Console.Write("Ingrese el año de publicación: ");
		int.TryParse(Console.ReadLine(), out int anio);
		libro.Anio = anio;

		Console.Write("Ingrese el género del libro: ");
		libro.Genero = Console.ReadLine()!;

		Console.WriteLine("\nInformación del libro ingresado:");
		libro.MostrarDatos();
	}
}
