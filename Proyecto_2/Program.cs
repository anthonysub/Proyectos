using System;
using Microsoft.Data.Sqlite;

class Program
{
    static void Main()
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("\n--- Menú ---");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Mostrar productos");
            Console.WriteLine("3. Actualizar precio o stock");
            Console.WriteLine("4. Eliminar producto");
            Console.WriteLine("5. Estadísticas");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");

            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarProducto();
                    break;
                case "2":
                    MostrarProductos();
                    break;
                case "3":
                    ActualizarProducto();
                    break;
                case "4":
                    EliminarProducto();
                    break;

                case "5":
                    Estadisticas();
                    break;

                case "6":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void RegistrarProducto()
    {
        using (var connection = new SqliteConnection("Data Source=productos.db"))
        {
            connection.Open();
            CrearTablaSiNoExiste(connection);

            Producto nuevo = new Producto();
            Console.Write("Nombre: ");
            nuevo.Nombre = Console.ReadLine();
            Console.Write("Descripción: ");
            nuevo.Descripcion = Console.ReadLine();
            Console.Write("Categoría: ");
            nuevo.Categoria = Console.ReadLine();
            Console.Write("Precio: ");
            nuevo.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Cantidad en stock: ");
            nuevo.CantidadEnStock = Convert.ToInt32(Console.ReadLine());

            var insertCmd = connection.CreateCommand();
            insertCmd.CommandText =
            @"INSERT INTO Productos (Nombre, Descripcion, Categoria, Precio, CantidadEnStock)
              VALUES ($nombre, $descripcion, $categoria, $precio, $stock)";
            insertCmd.Parameters.AddWithValue("$nombre", nuevo.Nombre);
            insertCmd.Parameters.AddWithValue("$descripcion", nuevo.Descripcion);
            insertCmd.Parameters.AddWithValue("$categoria", nuevo.Categoria);
            insertCmd.Parameters.AddWithValue("$precio", nuevo.Precio);
            insertCmd.Parameters.AddWithValue("$stock", nuevo.CantidadEnStock);
            insertCmd.ExecuteNonQuery();

            Console.WriteLine("✅ Producto registrado con éxito.");
        }
    }

    static void MostrarProductos()
    {
        using (var connection = new SqliteConnection("Data Source=productos.db"))
        {
            connection.Open();

            var selectCmd = connection.CreateCommand();
            selectCmd.CommandText = "SELECT * FROM Productos";

            using (var reader = selectCmd.ExecuteReader())
            {
                Console.WriteLine("\n--- Lista de productos ---");
                while (reader.Read())
                {
                    Producto p = new Producto
                    {
                        IdProducto = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Descripcion = reader.GetString(2),
                        Categoria = reader.GetString(3),
                        Precio = Convert.ToDecimal(reader.GetDouble(4)),
                        CantidadEnStock = reader.GetInt32(5)
                    };
                    Console.WriteLine($"ID: {p.IdProducto}, Nombre: {p.Nombre}, Precio: {p.Precio}, Stock: {p.CantidadEnStock}");
                }
            }
        }
    }

    static void ActualizarProducto()
    {
        using (var connection = new SqliteConnection("Data Source=productos.db"))
        {
            connection.Open();
            MostrarProductos();

            Console.Write("Ingrese el ID del producto a actualizar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Console.Write("Nuevo precio: ");
            decimal nuevoPrecio = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Nueva cantidad en stock: ");
            int nuevoStock = Convert.ToInt32(Console.ReadLine());

            var updateCmd = connection.CreateCommand();
            updateCmd.CommandText =
            @"UPDATE Productos 
              SET Precio = $precio, CantidadEnStock = $stock 
              WHERE IdProducto = $id";
            updateCmd.Parameters.AddWithValue("$precio", nuevoPrecio);
            updateCmd.Parameters.AddWithValue("$stock", nuevoStock);
            updateCmd.Parameters.AddWithValue("$id", id);
            int rows = updateCmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("✅ Producto actualizado correctamente.");
            else
                Console.WriteLine("❌ No se encontró un producto con ese ID.");
        }
    }

    static void EliminarProducto()
    {
        using (var connection = new SqliteConnection("Data Source=productos.db"))
        {
            connection.Open();
            MostrarProductos();

            Console.Write("Ingrese el ID del producto a eliminar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var deleteCmd = connection.CreateCommand();
            deleteCmd.CommandText = "DELETE FROM Productos WHERE IdProducto = $id";
            deleteCmd.Parameters.AddWithValue("$id", id);
            int rows = deleteCmd.ExecuteNonQuery();

            if (rows > 0)
                Console.WriteLine("✅ Producto eliminado correctamente.");
            else
                Console.WriteLine("❌ No se encontró un producto con ese ID.");
        }
    }

    // Método auxiliar para crear tabla si no existe
    static void CrearTablaSiNoExiste(SqliteConnection connection)
    {
        var createCmd = connection.CreateCommand();
        createCmd.CommandText =
        @"CREATE TABLE IF NOT EXISTS Productos (
            IdProducto INTEGER PRIMARY KEY AUTOINCREMENT,
            Nombre TEXT NOT NULL,
            Descripcion TEXT,
            Categoria TEXT,
            Precio REAL NOT NULL,
            CantidadEnStock INTEGER NOT NULL
          );";
        createCmd.ExecuteNonQuery();
    }
    static void Estadisticas()
    {
        using (var connection = new SqliteConnection("Data Source=productos.db"))
        {
            connection.Open();

            var countCmd = connection.CreateCommand();
            countCmd.CommandText = "SELECT COUNT(*) FROM Productos";

            long total = (long)countCmd.ExecuteScalar(); // Devuelve un valor único

            Console.WriteLine($"\n📦 Actualmente tienes {total} producto(s) registrados.");
        }
    }

    // Clase Producto
    public class Producto
    {
        public int IdProducto { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string Categoria { get; set; }
        public decimal Precio { get; set; }
        public int CantidadEnStock { get; set; }
    }
}
