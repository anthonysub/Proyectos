using System;

// Interfaz para impresión
public interface IImprimible
{
    void Imprimir();
}

// Clase Factura
public class Factura : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo factura con detalles de compra...");
    }
}

// Clase Reporte
public class Reporte : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo reporte con gráficos y estadísticas...");
    }
}

// Clase Etiqueta
public class Etiqueta : IImprimible
{
    public void Imprimir()
    {
        Console.WriteLine("Imprimiendo etiqueta con código de barras...");
    }
}