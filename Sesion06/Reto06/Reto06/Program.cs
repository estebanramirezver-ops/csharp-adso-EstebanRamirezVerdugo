using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("es-CO");

List<Empleado> nomina =
[
    new EmpleadoPlanta("Ana Gómez", "1001", 3_200_000m, 6),
    new EmpleadoPlanta("Luis Pérez", "1002", 2_800_000m, 2),
    new EmpleadoPorHoras("Marta Ruiz", "1003", 170, 18_000m),
    new EmpleadoPorHoras("Jorge Díaz", "1004", 120, 18_000m),
    new Contratista("Sofía León", "1005", 4_000_000m)
];

Console.WriteLine("=== NÓMINA ===");
foreach (Empleado empleado in nomina)
{
    Console.WriteLine(empleado);
}

decimal total = nomina.Sum(e => e.CalcularSalario());
Console.WriteLine($"\nTotal de la nómina: ${total:N0}");

Empleado mayor = nomina.MaxBy(e => e.CalcularSalario())!;
Console.WriteLine($"Mayor pago: {mayor.Nombre} con ${mayor.CalcularSalario():N0}");

Console.WriteLine("\n=== TOTAL POR TIPO ===");
var porTipo = nomina
    .GroupBy(e => e.Tipo)
    .Select(g => new { Tipo = g.Key, Total = g.Sum(e => e.CalcularSalario()) });

foreach (var grupo in porTipo)
{
    Console.WriteLine($"{grupo.Tipo}: ${grupo.Total:N0}");
}

public abstract class Empleado
{
    public string Nombre { get; }
    public string Documento { get; }

    protected Empleado(string nombre, string documento)
    {
        Nombre = nombre;
        Documento = documento;
    }

    public virtual string Tipo => "Empleado";

    public abstract decimal CalcularSalario();

    public override string ToString() =>
        $"{Nombre} ({Documento}) - {Tipo}: ${CalcularSalario():N0}";
}

public class EmpleadoPlanta : Empleado
{
    public decimal SalarioMensual { get; }
    public int AniosAntiguedad { get; }

    public EmpleadoPlanta(string nombre, string documento, decimal salarioMensual, int aniosAntiguedad)
        : base(nombre, documento)
    {
        SalarioMensual = salarioMensual;
        AniosAntiguedad = aniosAntiguedad;
    }

    public override string Tipo => "Planta";

    public override decimal CalcularSalario()
    {
        if (AniosAntiguedad >= 5)
            return SalarioMensual * 1.05m;

        return SalarioMensual;
    }
}

public class EmpleadoPorHoras : Empleado
{
    private const int HorasNormales = 160;

    public int Horas { get; }
    public decimal ValorHora { get; }

    public EmpleadoPorHoras(string nombre, string documento, int horas, decimal valorHora)
        : base(nombre, documento)
    {
        Horas = horas;
        ValorHora = valorHora;
    }

    public override string Tipo => "Por horas";

    public override decimal CalcularSalario()
    {
        if (Horas <= HorasNormales)
            return Horas * ValorHora;

        int horasExtra = Horas - HorasNormales;
        return HorasNormales * ValorHora + horasExtra * ValorHora * 1.5m;
    }
}

public class Contratista : Empleado
{
    public decimal ValorContrato { get; }

    public Contratista(string nombre, string documento, decimal valorContrato)
        : base(nombre, documento)
    {
        ValorContrato = valorContrato;
    }

    public override string Tipo => "Contratista";

    public override decimal CalcularSalario() => ValorContrato * 0.90m;
}