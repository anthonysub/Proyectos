using System;
using System.Collections.Generic;

class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }

    public Producto(string nombre, decimal precio)
    {
        Nombre = nombre;
        Precio = precio;
    }

    public override string ToString()
    {
        return $"{Nombre} - ${Precio:F2}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Crear una lista de productos con sus precios
        List<Producto> productos = new List<Producto>
        {
            new Producto("Laptop", 899.99m),
            new Producto("Smartphone", 499.99m),
            new Producto("Audífonos", 59.99m),
            new Producto("Monitor", 299.99m),
            new Producto("Teclado", 45.99m),
            new Producto("Mouse", 29.99m)
        };

        Console.WriteLine("Productos que cuestan más de $100:");
        Console.WriteLine("----------------------------------");

        // Usar FindAll() para encontrar y mostrar productos que cuestan más de 100
        List<Producto> productosCaros = productos.FindAll(p => p.Precio > 100);

        if (productosCaros.Count > 0)
        {
            foreach (var producto in productosCaros)
            {
                Console.WriteLine(producto);
            }
            Console.WriteLine($"\nSe encontraron {productosCaros.Count} productos con precio mayor a $100");
        }
        else
        {
            Console.WriteLine("No se encontraron productos con precio mayor a $100");
        }
    }
}