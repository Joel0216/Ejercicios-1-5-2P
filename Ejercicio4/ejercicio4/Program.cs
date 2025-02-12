using System;

class CalculadoraAlimentoPerro
{
    private const double CONSUMO_DIARIO_GRAMOS = 750.0;
    private const double GRAMOS_POR_KILO = 1000.0;

    public static double CalcularAlimentoNecesario(int diasViaje)
    {
        if (diasViaje <= 0)
        {
            throw new ArgumentException("El número de días debe ser mayor que cero.");
        }

        // Calculamos el total de gramos necesarios
        double gramosNecesarios = CONSUMO_DIARIO_GRAMOS * diasViaje;
        
        // Convertimos a kilogramos
        double kilosNecesarios = gramosNecesarios / GRAMOS_POR_KILO;
        
        // Redondeamos a 2 decimales para mayor precisión
        return Math.Round(kilosNecesarios, 2);
    }

    static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("¿Cuántos días durará su viaje?");
            int diasViaje = Convert.ToInt32(Console.ReadLine());

            double kilosAlimento = CalcularAlimentoNecesario(diasViaje);

            Console.WriteLine($"\nPara {diasViaje} días de viaje, necesitará dejar {kilosAlimento} kilogramos de alimento.");
            Console.WriteLine($"(Basado en un consumo diario de {CONSUMO_DIARIO_GRAMOS} gramos)");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Por favor ingrese un número válido de días.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("Ocurrió un error inesperado.");
        }
    }
}