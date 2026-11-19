using System.Globalization;

CultureInfo.CurrentCulture = new CultureInfo("es-CO");

ProcesadorPagos procesador = new ProcesadorPagos();

List<IMetodoPago> metodos =
[
    new PagoEfectivo(),
    new PagoTarjeta("4111111111111111"),
    new PagoBilletera(),
    new PagoTarjeta("1234")
];

Console.WriteLine("=== COBROS DE $500.000 ===");
foreach (IMetodoPago metodo in metodos)
{
    procesador.Cobrar(metodo, 500_000m);
}

Console.WriteLine("\n=== COBRO QUE SUPERA EL LÍMITE DE LA BILLETERA ===");
procesador.Cobrar(new PagoBilletera(), 2_500_000m);

Console.WriteLine("\n=== DEVOLUCIONES ===");
procesador.Devolver(new PagoEfectivo(), 500_000m);
procesador.Devolver(new PagoTarjeta("4111111111111111"), 500_000m);
procesador.Devolver(new PagoBilletera(), 500_000m);


public interface IMetodoPago
{
    string Nombre { get; }
    decimal CalcularComision(decimal monto);
    bool Validar(decimal monto);
}

public interface IReembolsable
{
    void Reembolsar(decimal monto);
}

public class PagoEfectivo : IMetodoPago
{
    public string Nombre => "Efectivo";

    public decimal CalcularComision(decimal monto) => 0m;

    public bool Validar(decimal monto) => monto > 0;
}

public class PagoTarjeta : IMetodoPago, IReembolsable
{
    public string Nombre => "Tarjeta";
    public string NumeroTarjeta { get; }

    public PagoTarjeta(string numeroTarjeta)
    {
        NumeroTarjeta = numeroTarjeta;
    }

    public decimal CalcularComision(decimal monto) => monto * 0.03m;

    public bool Validar(decimal monto)
    {
        if (monto <= 0)
            return false;

        if (NumeroTarjeta.Length != 16)
            return false;

        foreach (char c in NumeroTarjeta)
        {
            if (!char.IsDigit(c))
                return false;
        }

        return true;
    }

    public void Reembolsar(decimal monto)
    {
        string ultimos4 = NumeroTarjeta.Substring(NumeroTarjeta.Length - 4);
        Console.WriteLine($"[Tarjeta] Reembolso de ${monto:N0} enviado a la tarjeta terminada en {ultimos4}.");
    }
}

public class PagoBilletera : IMetodoPago, IReembolsable
{
    private const decimal LimiteMaximo = 2_000_000m;

    public string Nombre => "Billetera";

    public decimal CalcularComision(decimal monto) => monto * 0.01m;

    public bool Validar(decimal monto) => monto > 0 && monto <= LimiteMaximo;

    public void Reembolsar(decimal monto)
    {
        Console.WriteLine($"[Billetera] Reembolso de ${monto:N0} devuelto al saldo de la billetera.");
    }
}
public class ProcesadorPagos
{
    public bool Cobrar(IMetodoPago metodo, decimal monto)
    {
        if (!metodo.Validar(monto))
        {
            Console.WriteLine($"[{metodo.Nombre}] Pago rechazado: datos inválidos para ${monto:N0}.");
            return false;
        }

        decimal comision = metodo.CalcularComision(monto);
        decimal total = monto + comision;
        Console.WriteLine($"[{metodo.Nombre}] Cobrado ${monto:N0} + comisión ${comision:N0} = total ${total:N0}");
        return true;
    }

    public bool Devolver(IMetodoPago metodo, decimal monto)
    {
        if (metodo is IReembolsable reembolsable)
        {
            reembolsable.Reembolsar(monto);
            return true;
        }

        Console.WriteLine($"[{metodo.Nombre}] Este método no admite reembolsos.");
        return false;
    }
}