using System;

namespace Ejercicio12
{
    // -----------------------------
    // 1️⃣ GESTIÓN DE FIGURAS GEOMÉTRICAS
    // -----------------------------
    class Figura
    {
        public virtual double CalcularArea()
        {
            return 0;
        }
    }

    class Triangulo : Figura
    {
        public double Base { get; set; }
        public double Altura { get; set; }

        public Triangulo(double b, double h)
        {
            Base = b;
            Altura = h;
        }

        public override double CalcularArea()
        {
            return (Base * Altura) / 2;
        }
    }

    class Rectangulo : Figura
    {
        public double Largo { get; set; }
        public double Ancho { get; set; }

        public Rectangulo(double l, double a)
        {
            Largo = l;
            Ancho = a;
        }

        public override double CalcularArea()
        {
            return Largo * Ancho;
        }
    }

    class Circulo : Figura
    {
        public double Radio { get; set; }

        public Circulo(double r)
        {
            Radio = r;
        }

        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }

    // -----------------------------
    // 2️⃣ CATÁLOGO DE PRODUCTOS
    // -----------------------------
    class Producto
    {
        public string Nombre { get; set; }

        public Producto(string nombre)
        {
            Nombre = nombre;
        }

        public virtual void MostrarDescripcion()
        {
            Console.WriteLine("Producto genérico sin descripción.");
        }
    }

    class Electronico : Producto
    {
        public Electronico(string nombre) : base(nombre) { }

        public override void MostrarDescripcion()
        {
            Console.WriteLine($"[Electrónico] {Nombre}: Dispositivo con tecnología avanzada y garantía de 1 año.");
        }
    }

    class Alimento : Producto
    {
        public Alimento(string nombre) : base(nombre) { }

        public override void MostrarDescripcion()
        {
            Console.WriteLine($"[Alimento] {Nombre}: Producto fresco y saludable con fecha de caducidad próxima.");
        }
    }

    class Ropa : Producto
    {
        public Ropa(string nombre) : base(nombre) { }

        public override void MostrarDescripcion()
        {
            Console.WriteLine($"[Ropa] {Nombre}: Prenda de vestir cómoda y moderna, disponible en varias tallas.");
        }
    }

    // -----------------------------
    // 3️⃣ SISTEMA DE PAGOS
    // -----------------------------
    class Pago
    {
        public double Monto { get; set; }

        public Pago(double monto)
        {
            Monto = monto;
        }

        public virtual void Procesar()
        {
            Console.WriteLine("Procesando pago genérico...");
        }
    }

    class PagoEfectivo : Pago
    {
        public PagoEfectivo(double monto) : base(monto) { }

        public override void Procesar()
        {
            Console.WriteLine($"Pago en efectivo recibido: Q{Monto}. Pago confirmado.");
        }
    }

    class PagoTarjeta : Pago
    {
        public string NumeroTarjeta { get; set; }

        public PagoTarjeta(double monto, string numeroTarjeta) : base(monto)
        {
            NumeroTarjeta = numeroTarjeta;
        }

        public override void Procesar()
        {
            Console.WriteLine($"Validando tarjeta {NumeroTarjeta}...");
            Console.WriteLine($"Pago con tarjeta por Q{Monto} aprobado.");
        }
    }

    class PagoTransferencia : Pago
    {
        public string Banco { get; set; }

        public PagoTransferencia(double monto, string banco) : base(monto)
        {
            Banco = banco;
        }

        public override void Procesar()
        {
            Console.WriteLine($"Transferencia desde {Banco} por Q{Monto}. Pago completado.");
        }
    }

    // -----------------------------
    // PROGRAMA PRINCIPAL
    // -----------------------------
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== FIGURAS GEOMÉTRICAS ===");
            Figura f1 = new Triangulo(10, 5);
            Figura f2 = new Rectangulo(8, 4);
            Figura f3 = new Circulo(3);

            Console.WriteLine($"Área del triángulo: {f1.CalcularArea()}");
            Console.WriteLine($"Área del rectángulo: {f2.CalcularArea()}");
            Console.WriteLine($"Área del círculo: {f3.CalcularArea():F2}");

            Console.WriteLine("\n=== CATÁLOGO DE PRODUCTOS ===");
            Producto p1 = new Electronico("Laptop");
            Producto p2 = new Alimento("Manzana");
            Producto p3 = new Ropa("Camisa");

            p1.MostrarDescripcion();
            p2.MostrarDescripcion();
            p3.MostrarDescripcion();

            Console.WriteLine("\n=== SISTEMA DE PAGOS ===");
            Pago pago1 = new PagoEfectivo(250);
            Pago pago2 = new PagoTarjeta(1200, "1234-5678-9876-5432");
            Pago pago3 = new PagoTransferencia(800, "Banco Industrial");

            pago1.Procesar();
            pago2.Procesar();
            pago3.Procesar();

            Console.WriteLine("\n--- Fin del programa ---");
        }
    }
}
