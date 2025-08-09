
using System;

namespace LibroApp
{
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
			Libro miLibroFavorito = new Libro
			{
				Titulo = "Cien años de soledad",
				Autor = "Gabriel García Márquez",
				Anio = 1967,
				Genero = "Realismo mágico"
			};

			Console.WriteLine("Mi libro favorito:");
			miLibroFavorito.MostrarDatos();
		}
	}
}
