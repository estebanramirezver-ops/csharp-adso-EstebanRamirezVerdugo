try
{
    int[] numeros = [10, 20, 30];
    Console.WriteLine("Posición (0 a 2): ");
    int pos = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine("Dividir entre: ");
    int divisor = int.Parse(Console.ReadLine() ?? "");
    Console.WriteLine($"Resultado: {numeros[pos] / divisor}");
}
catch (FormatException)
{
    Console.WriteLine("Debes escribir números");
}
catch (DivideByZeroException)
{
    Console.WriteLine("No se puede dividir entre cero");
}
catch (IndexOutOfRangeException)
{
    Console.WriteLine("Esa posición es desconocida o no existe");
}
catch (Exception ex)
{
    Console.WriteLine($"Error inesperado: {ex.Message}");
}
finally
{
    Console.WriteLine("Operación terminada");
}

Practica3.Ejecutar();

public class StockInsuficienteException : Exception
{
    public StockInsuficienteException(string producto, int disponible)
        : base($"No hay suficiente {producto}. Disponible: {disponible}.") { }
}
