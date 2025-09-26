using System;

namespace Ejercicio9_Herencia
{
    // --------- Vehículos ----------
    // Clase base
    public class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }

        public Vehiculo(string marca, string modelo)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Marca: {Marca}, Modelo: {Modelo}");
        }
    }

    // Clase derivada Motocicleta
    public class Motocicleta : Vehiculo
    {
        public int Cilindraje { get; set; }

        public Motocicleta(string marca, string modelo, int cilindraje)
            : base(marca, modelo)
        {
            Cilindraje = cilindraje;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Motocicleta - Marca: {Marca}, Modelo: {Modelo}, Cilindraje: {Cilindraje}cc");
        }
    }

    // Clase derivada Camion
    public class Camion : Vehiculo
    {
        public double CapacidadDeCarga { get; set; }

        public Camion(string marca, string modelo, double capacidadDeCarga)
            : base(marca, modelo)
        {
            CapacidadDeCarga = capacidadDeCarga;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Camión - Marca: {Marca}, Modelo: {Modelo}, Capacidad de Carga: {CapacidadDeCarga} toneladas");
        }
    }

    // --------- Empleados ----------
    // Clase base
    public class Empleado
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Certificaciones { get; set; }

        public Empleado(string nombre, string puesto, string certificaciones)
        {
            Nombre = nombre;
            Puesto = puesto;
            Certificaciones = certificaciones;
        }

        public virtual void MostrarInfo()
        {
            Console.WriteLine($"Nombre: {Nombre}, Puesto: {Puesto}, Certificaciones: {Certificaciones}");
        }
    }

    // Clase derivada Gerente
    public class Gerente : Empleado
    {
        public int NumeroDeEmpleadosACargo { get; set; }

        public Gerente(string nombre, string puesto, string certificaciones, int numeroDeEmpleadosACargo)
            : base(nombre, puesto, certificaciones)
        {
            NumeroDeEmpleadosACargo = numeroDeEmpleadosACargo;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Gerente - Nombre: {Nombre}, Puesto: {Puesto}, Certificaciones: {Certificaciones}, Empleados a Cargo: {NumeroDeEmpleadosACargo}");
        }
    }

    // Clase derivada Programador
    public class Programador : Empleado
    {
        public string LenguajePrincipal { get; set; }

        public Programador(string nombre, string puesto, string certificaciones, string lenguajePrincipal)
            : base(nombre, puesto, certificaciones)
        {
            LenguajePrincipal = lenguajePrincipal;
        }

        public override void MostrarInfo()
        {
            Console.WriteLine($"Programador - Nombre: {Nombre}, Puesto: {Puesto}, Certificaciones: {Certificaciones}, Lenguaje Principal: {LenguajePrincipal}");
        }
    }

    // --------- Programa Principal ----------
    public class Program
    {
        public static void Main(string[] args)
        {
            // Vehículos
            Motocicleta moto = new Motocicleta("Yamaha", "R3", 321);
            Camion camion = new Camion("Volvo", "FH16", 25);

            moto.MostrarInfo();
            camion.MostrarInfo();

            Console.WriteLine();

            // Empleados
            Gerente gerente = new Gerente("Ana Pérez", "Gerente General", "MBA, PMP", 10);
            Programador programador = new Programador("Luis Gómez", "Desarrollador", "Scrum Master, AWS Certified", "C#");

            gerente.MostrarInfo();
            programador.MostrarInfo();

            Console.ReadKey();
        }
    }
}
