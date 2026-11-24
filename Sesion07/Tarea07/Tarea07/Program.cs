using Tarea07;

Console.OutputEncoding = System.Text.Encoding.UTF8;

var ana = new CuentaBancaria("Ana Gómez", "001", 100000m);
var luis = new CuentaBancaria("Luis Pérez", "002");

Escribir("=== Estado inicial ===");
Escribir(ana.ToString());
Escribir(luis.ToString());

Escribir("");
Escribir("=== Depositar ===");
Probar("Depositar 50.000 (válido)", ana.Depositar(50000m));
Probar("Depositar 0", ana.Depositar(0));
Probar("Depositar -1.000", ana.Depositar(-1000m));
Escribir(ana.ToString());

Escribir("");
Escribir("=== Retirar ===");
Probar("Retirar 30.000 (válido)", ana.Retirar(30000m));
Probar("Retirar 0", ana.Retirar(0));
Probar("Retirar -500", ana.Retirar(-500m));
Probar("Retirar más del saldo", ana.Retirar(999999m));
Escribir(ana.ToString());
Probar("Retirar todo el saldo", ana.Retirar(ana.Saldo));
Escribir(ana.ToString());
ana.Depositar(120000m);

Escribir("");
Escribir("=== Transferir ===");
Probar("Transferir 20.000 de Ana a Luis", ana.Transferir(luis, 20000m));
Probar("Transferir 0", ana.Transferir(luis, 0));
Probar("Transferir -100", ana.Transferir(luis, -100m));
Probar("Transferir más del saldo", ana.Transferir(luis, 999999m));
Probar("Transferir a la misma cuenta", ana.Transferir(ana, 1000m));
Probar("Transferir a una cuenta nula", ana.Transferir(null!, 1000m));

Escribir("");
Escribir("=== Estado final ===");
Escribir(ana.ToString());
Escribir(luis.ToString());

static void Escribir(string texto) => Console.WriteLine(texto);

static void Probar(string descripcion, bool resultado) =>
    Escribir($"{descripcion}: {(resultado ? "ACEPTADO" : "RECHAZADO")}");
