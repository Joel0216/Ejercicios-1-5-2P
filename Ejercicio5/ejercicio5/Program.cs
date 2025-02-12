using System;

class CalculadoraAguinaldo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Calculadora de Aguinaldo");
        Console.WriteLine("------------------------");
        
        // Solicitar el salario diario al usuario
        Console.Write("Ingrese el salario diario del trabajador: $");
        double salarioDiario;
        
        // Validar que el input sea un número válido
        while (!double.TryParse(Console.ReadLine(), out salarioDiario) || salarioDiario <= 0)
        {
            Console.WriteLine("Por favor, ingrese un monto válido mayor a 0");
            Console.Write("Ingrese el salario diario del trabajador: $");
        }

        // Calcular el aguinaldo
        double aguinaldo = CalcularAguinaldo(salarioDiario);

        // Mostrar el resultado
        Console.WriteLine("\nResultados del cálculo:");
        Console.WriteLine($"Salario diario: ${salarioDiario:F2}");
        Console.WriteLine($"Días de aguinaldo: 15");
        Console.WriteLine($"Monto total de aguinaldo: ${aguinaldo:F2}");
        
        Console.WriteLine("\nPresione cualquier tecla para salir...");
        Console.ReadKey();
    }

    static double CalcularAguinaldo(double salarioDiario)
    {
        const int DIAS_AGUINALDO = 15;
        return salarioDiario * DIAS_AGUINALDO;
    }
}