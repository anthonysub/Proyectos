using System;

class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public int Anio { get; set; }

    // Constructor 1: Marca y modelo
    public Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
        Anio = 0; // por defecto si no se ingresa año
    }

    // Constructor 2: Marca, modelo y año
    public Vehiculo(string marca, string modelo, int anio)
    {
        Marca = marca;
        Modelo = modelo;
        Anio = anio;
    }

    public void MostrarInfo()
    {
        if (Anio != 0)
            Console.WriteLine($"Vehículo: {Marca} {Modelo} {Anio}");
        else
            Console.WriteLine($"Vehículo: {Marca} {Modelo}");
    }
}

class Program3
{
    static void Main()
    {
        Vehiculo v1 = new Vehiculo("Toyota", "Corolla");
        Vehiculo v2 = new Vehiculo("Honda", "Civic", 2022);

        v1.MostrarInfo(); // Sin año
        v2.MostrarInfo(); // Con año
    }
}
