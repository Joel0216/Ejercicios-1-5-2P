using System;
using System.Collections.Generic;

class CalculadoraCambio
{
    private static readonly decimal[] DENOMINACIONES = new decimal[]
    {
        1000.00m, 500.00m, 200.00m, 100.00m, 50.00m, 20.00m,  // Billetes
        10.00m, 5.00m, 2.00m, 1.00m, 0.50m, 0.20m, 0.10m      // Monedas
    };

    public static void Main()
    {
        try
        {
            Console.WriteLine("=== Calculadora de Cambio OXXO ===\n");
            
            // Obtener el total de la compra
            Console.Write("Ingrese el total de la compra: $");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            decimal totalCompra = decimal.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

            // Validar que el total sea positivo
            if (totalCompra <= 0)
            {
                throw new ArgumentException("El total de la compra debe ser mayor a cero.");
            }

            // Obtener el pago del cliente
            Console.Write("Ingrese la cantidad con la que paga el cliente: $");
#pragma warning disable CS8604 // Posible argumento de referencia nulo
            decimal cantidadPagada = decimal.Parse(Console.ReadLine());
#pragma warning restore CS8604 // Posible argumento de referencia nulo

            // Validar que el pago sea suficiente
            if (cantidadPagada < totalCompra)
            {
                throw new ArgumentException("La cantidad pagada es insuficiente.");
            }

            // Calcular el cambio
            decimal cambioTotal = cantidadPagada - totalCompra;
            
            if (cambioTotal == 0)
            {
                Console.WriteLine("\nNo hay cambio que devolver - Cantidad exacta.");
                return;
            }

            // Calcular las denominaciones a devolver
            Console.WriteLine($"\nCambio a devolver: ${cambioTotal:F2}");
            Console.WriteLine("\nDesglose del cambio:");
            
            decimal cambioRestante = cambioTotal;
            foreach (decimal denominacion in DENOMINACIONES)
            {
                if (cambioRestante >= denominacion)
                {
                    int cantidad = (int)(cambioRestante / denominacion);
                    cambioRestante %= denominacion;

                    string tipo = denominacion >= 20 ? "billete(s)" : "moneda(s)";
                    Console.WriteLine($"${denominacion:F2} x {cantidad} {tipo}");
                }
            }
        }
        catch (FormatException)
        {
            Console.WriteLine("\nError: Por favor ingrese cantidades válidas.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"\nError: {ex.Message}");
        }
        catch (Exception)
        {
            Console.WriteLine("\nError: Ocurrió un error inesperado.");
        }
    }
}