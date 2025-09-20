using System;

class Producto
{
    public string Nombre { get; set; }
    public decimal Precio { get; set; }
    public int Cantidad { get; set; }

    // Constructor
    public Producto(string nombre, decimal precio, int cantidad)
    {
        Nombre = nombre;
        Precio = precio;
        Cantidad = cantidad;
    }

    public void MostrarInfo()
    {
        Console.WriteLine($"Producto: {Nombre} | Precio: Q{Precio} | Cantidad: {Cantidad}");
    }
}

class Program
{
    static void Main()
    {
        Producto p1 = new Producto("Laptop", 4500.50m, 3);
        p1.MostrarInfo();
    }
}
