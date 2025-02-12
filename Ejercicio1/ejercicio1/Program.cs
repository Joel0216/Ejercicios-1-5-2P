using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Por favor ingrese sus nombres:");
        string nombres = Console.ReadLine();
        
        Console.WriteLine("Por favor ingrese sus apellidos:");
        string apellidos = Console.ReadLine();

        // Limpieza de espacios extras
        nombres = nombres.Trim();
        apellidos = apellidos.Trim();

        // Mostrar nombre en ambos formatos
        MostrarNombreNormal(nombres, apellidos);
        MostrarNombreInvertido(nombres, apellidos);
    }

    static void MostrarNombreNormal(string nombres, string apellidos)
    {
        Console.WriteLine("\nNombre en formato normal:");
        Console.WriteLine($"{nombres} {apellidos}");
    }

    static void MostrarNombreInvertido(string nombres, string apellidos)
    {
        Console.WriteLine("\nNombre en formato invertido:");
        Console.WriteLine($"{apellidos} {nombres}");
    }
}