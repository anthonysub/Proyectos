using System;

class Estudiante
{
    public string Nombre { get; set; }
    public double Nota { get; set; }

    public Estudiante(string nombre, double nota)
    {
        Nombre = nombre;
        Nota = nota;
    }

    // Versión que muestra solo el nombre
    public void MostrarInfo()
    {
        Console.WriteLine($"Estudiante: {Nombre}");
    }

    // Versión que muestra nombre y nota
    public void MostrarInfo(bool mostrarNota)
    {
        if (mostrarNota)
            Console.WriteLine($"Estudiante: {Nombre} | Nota: {Nota}");
        else
            MostrarInfo();
    }
}

class Program2
{
    static void Main()
    {
        Estudiante e1 = new Estudiante("Ana", 85.5);

        e1.MostrarInfo();             // Muestra solo nombre
        e1.MostrarInfo(true);         // Muestra nombre y nota
    }
}
