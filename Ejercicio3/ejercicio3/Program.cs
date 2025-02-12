using System;

class ConsumoAgua
{
    public static double CalcularConsumoLitros(double metrosCubicos)
    {
        // Validación de entrada
        if (metrosCubicos < 0)
        {
            throw new ArgumentException("El consumo de agua no puede ser negativo.");
        }

        // Conversión de metros cúbicos a litros
        // 1 metro cúbico = 1000 litros
        const double FACTOR_CONVERSION = 1000;
        double litros = metrosCubicos * FACTOR_CONVERSION;

        return litros;
    }

    static void Main()
    {
        try
        {
            Console.WriteLine("Calculadora de Consumo de Agua");
            Console.WriteLine("------------------------------");
            Console.Write("Ingrese el consumo de agua en metros cúbicos: ");
            
            // Lectura y validación de la entrada del usuario
            if (!double.TryParse(Console.ReadLine(), out double consumoMetrosCubicos))
            {
                Console.WriteLine("Error: Debe ingresar un número válido.");
                return;
            }

            // Cálculo del consumo en litros
            double consumoLitros = CalcularConsumoLitros(consumoMetrosCubicos);

            // Mostrar resultados
            Console.WriteLine("\nResultados del consumo mensual:");
            Console.WriteLine($"Metros cúbicos: {consumoMetrosCubicos:N2} m³");
            Console.WriteLine($"Litros: {consumoLitros:N2} L");
            Console.WriteLine($"Promedio diario en litros: {(consumoLitros / 30):N2} L/día");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("Error: Ocurrió un error inesperado.");
        }
    }
}