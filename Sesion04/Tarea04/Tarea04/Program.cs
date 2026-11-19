List<Venta> ventas =
[
    new("Portátil", "Medellín", 2, 2_800_000m),
    new("Mouse", "Bogotá", 10, 45_000m),
    new("Teclado", "Cali", 5, 120_000m),
    new("Monitor", "Medellín", 3, 750_000m),
    new("Mouse", "Medellín", 8, 45_000m),
    new("Portátil", "Bogotá", 1, 2_800_000m),
    new("Diadema", "Cali", 6, 180_000m),
    new("Monitor", "Bogotá", 2, 750_000m),
    new("Teclado", "Medellín", 4, 120_000m),
    new("Diadema", "Bogotá", 3, 180_000m),
    new("Portátil", "Cali", 2, 2_800_000m),
    new("Mouse", "Cali", 12, 45_000m)
];

Console.WriteLine("=========REPORTE DE VENTAS=========");

decimal total = ventas.Sum(v => v.Cantidad * v.PrecioUnitario);
Console.WriteLine($"\nTotal vendido: ${total:N0}");

if (total == 21_800_000m)
{
    Console.WriteLine("✅ El total coincide con $21.800.000");
}
else
{
    Console.WriteLine("❌ El total no coincide, revisa los datos");
}

decimal promedio = ventas.Average(v => v.Cantidad * v.PrecioUnitario);
Console.WriteLine($"Promedio por venta: ${promedio:N0}");

Console.WriteLine("\nVentas por ciudad (de mayor a menor):");

var porCiudad = ventas
    .GroupBy(v => v.Ciudad)
    .Select(g => new { Ciudad = g.Key, Total = g.Sum(v => v.Cantidad * v.PrecioUnitario) })
    .OrderByDescending(x => x.Total);

foreach (var ciudad in porCiudad)
{
    Console.WriteLine($"{ciudad.Ciudad,-10} ${ciudad.Total:N0}");
}

Console.WriteLine("\nTop 3 de productos por ingresos:");

var top3 = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new { Producto = g.Key, Ingresos = g.Sum(v => v.Cantidad * v.PrecioUnitario) })
    .OrderByDescending(x => x.Ingresos)
    .Take(3);

int puesto = 1;
foreach (var producto in top3)
{
    Console.WriteLine($"{puesto}. {producto.Producto,-10} ${producto.Ingresos:N0}");
    puesto++;
}

var masVendido = ventas
    .GroupBy(v => v.Producto)
    .Select(g => new { Producto = g.Key, Unidades = g.Sum(v => v.Cantidad) })
    .OrderByDescending(x => x.Unidades)
    .First();

Console.WriteLine($"\nProducto más vendido: {masVendido.Producto} ({masVendido.Unidades} unidades)");

record Venta(string Producto, string Ciudad, int Cantidad, decimal PrecioUnitario);