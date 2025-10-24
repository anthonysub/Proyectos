using System;

// Interfaz para autenticación
public interface IAutenticable
{
    bool Autenticar();
}

// Clase UsuarioWeb
public class UsuarioWeb : IAutenticable
{
    private string _usuario;
    private string _contrasena;

    public UsuarioWeb(string usuario, string contrasena)
    {
        _usuario = usuario;
        _contrasena = contrasena;
    }

    public bool Autenticar()
    {
        // Simula verificación con base de datos
        Console.WriteLine($"Autenticando usuario web: {_usuario}");
        return !string.IsNullOrEmpty(_usuario) && !string.IsNullOrEmpty(_contrasena);
    }
}

// Clase Administrador
public class Administrador : IAutenticable
{
    private string _idAdmin;
    private string _claveSecreta;

    public Administrador(string idAdmin, string claveSecreta)
    {
        _idAdmin = idAdmin;
        _claveSecreta = claveSecreta;
    }

    public bool Autenticar()
    {
        // Simula autenticación con credenciales de admin
        Console.WriteLine($"Autenticando administrador: {_idAdmin}");
        return _idAdmin.StartsWith("ADM_") && _claveSecreta.Length >= 8;
    }
}

// Clase Invitado
public class Invitado : IAutenticable
{
    public bool Autenticar()
    {
        // Autenticación automática para invitados
        Console.WriteLine("Autenticando como invitado...");
        return true;
    }
}