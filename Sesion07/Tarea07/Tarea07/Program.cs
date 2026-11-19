namespace Tarea05
{
    public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
    }

    private void btnProbar_Click(object sender, EventArgs e)
    {
        txtResultados.Clear();

        var ana = new CuentaBancaria("Ana Gómez", "001", 100000m);
        var luis = new CuentaBancaria("Luis Pérez", "002");   // saldo inicial = 0

        Escribir("=== Estado inicial ===");
        Escribir(ana.ToString());
        Escribir(luis.ToString());

        Escribir("");
        Escribir("=== Depositar ===");
        Probar("Depositar 50.000 (válido)", ana.Depositar(50000m));      // aceptado
        Probar("Depositar 0", ana.Depositar(0));                         // rechazado
        Probar("Depositar -1.000", ana.Depositar(-1000m));               // rechazado
        Escribir(ana.ToString());                                        // 150.000

        Escribir("");
        Escribir("=== Retirar ===");
        Probar("Retirar 30.000 (válido)", ana.Retirar(30000m));          // aceptado
        Probar("Retirar 0", ana.Retirar(0));                             // rechazado
        Probar("Retirar -500", ana.Retirar(-500m));                      // rechazado
        Probar("Retirar más del saldo", ana.Retirar(999999m));           // rechazado
        Escribir(ana.ToString());                                        // 120.000
        Probar("Retirar todo el saldo", ana.Retirar(ana.Saldo));         // aceptado
        Escribir(ana.ToString());                                        // 0
        ana.Depositar(120000m);                                          // la dejo como estaba

        Escribir("");
        Escribir("=== Transferir ===");
        Probar("Transferir 20.000 de Ana a Luis", ana.Transferir(luis, 20000m));   // aceptado
        Probar("Transferir 0", ana.Transferir(luis, 0));                           // rechazado
        Probar("Transferir -100", ana.Transferir(luis, -100m));                    // rechazado
        Probar("Transferir más del saldo", ana.Transferir(luis, 999999m));         // rechazado
        Probar("Transferir a la misma cuenta", ana.Transferir(ana, 1000m));        // rechazado
        Probar("Transferir a una cuenta nula", ana.Transferir(null!, 1000m));      // rechazado

        Escribir("");
        Escribir("=== Estado final ===");
        Escribir(ana.ToString());    // 100.000
        Escribir(luis.ToString());   // 20.000
    }

    private void Escribir(string texto)
    {
        txtResultados.AppendText(texto + Environment.NewLine);
    }

    private void Probar(string descripcion, bool resultado)
    {
        Escribir($"{descripcion}: {(resultado ? "ACEPTADO" : "RECHAZADO")}");
    }
}
}