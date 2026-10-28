using System;

// ===== PRUEBAS =====
var ana = new CuentaBancaria("Ana", "001", 100000m);
var luis = new CuentaBancaria("Luis", "002");   // saldoInicial = 0 por defecto

Console.WriteLine("=== Estado inicial ===");
Console.WriteLine(ana);
Console.WriteLine(luis);

// 1. Depósito
bool deposito = ana.Depositar(50000m);
Console.WriteLine($"\nDepositar 50.000 en Ana → {(deposito ? "OK" : "RECHAZADO")}");
Console.WriteLine(ana);

// 2. Retiro rechazado (más que el saldo)
bool retiro = ana.Retirar(999999m);
Console.WriteLine($"\nRetirar 999.999 de Ana → {(retiro ? "OK" : "RECHAZADO")}");
Console.WriteLine(ana);

// 3. Transferencia
bool transferencia = ana.Transferir(luis, 30000m);
Console.WriteLine($"\nTransferir 30.000 de Ana a Luis → {(transferencia ? "OK" : "RECHAZADO")}");

Console.WriteLine("\n=== Estado final ===");
Console.WriteLine(ana);
Console.WriteLine(luis);

// ===== CLASE (debe ir después de las instrucciones) =====
public class CuentaBancaria
{
    public string Titular { get; private set; }
    public string Numero { get; private set; }
    public decimal Saldo { get; private set; }

    public CuentaBancaria(string titular, string numero, decimal saldoInicial = 0)
    {
        if (string.IsNullOrWhiteSpace(titular))
            throw new ArgumentException("El titular no puede estar vacío.");
        if (string.IsNullOrWhiteSpace(numero))
            throw new ArgumentException("El número de cuenta no puede estar vacío.");
        if (saldoInicial < 0)
            throw new ArgumentException("El saldo inicial no puede ser negativo.");

        Titular = titular.Trim();
        Numero = numero.Trim();
        Saldo = saldoInicial;
    }

    public bool Depositar(decimal monto)
    {
        if (monto <= 0) return false;
        Saldo += monto;
        return true;
    }

    public bool Retirar(decimal monto)
    {
        if (monto <= 0 || monto > Saldo) return false;
        Saldo -= monto;
        return true;
    }

    public bool Transferir(CuentaBancaria destino, decimal monto)
    {
        if (destino == null || destino == this) return false;
        if (!Retirar(monto)) return false;
        destino.Depositar(monto);
        return true;
    }

    public override string ToString() =>
        $"{Titular} ({Numero}) · Saldo: {Saldo:N0}";
}