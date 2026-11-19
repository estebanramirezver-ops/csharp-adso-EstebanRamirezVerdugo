using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

var servicio = new ServicioInventario(new RepositorioJson("inventario.json"));

bool salir = false;
while (!salir)
{
    Console.WriteLine("\n=== INVENTARIO ===");
    Console.WriteLine("1. Registrar producto");
    Console.WriteLine("2. Agregar stock");
    Console.WriteLine("3. Vender");
    Console.WriteLine("4. Ver inventario");
    Console.WriteLine("5. Stock bajo");
    Console.WriteLine("6. Buscar producto");
    Console.WriteLine("7. Eliminar producto");
    Console.WriteLine("8. Salir");
    Console.Write("Opción: ");
    string opcion = Console.ReadLine() ?? "";

    try
    {
        switch (opcion)
        {
            case "1":
                Console.Write("Código: ");
                string codigo = Console.ReadLine() ?? "";
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine() ?? "";
                decimal precio = PedirDecimal("Precio: ");
                int stock = PedirEntero("Stock inicial: ");
                servicio.Agregar(new Producto(codigo, nombre, precio, stock));
                Console.WriteLine("Producto registrado.");
                break;

            case "2":
                Console.Write("Código: ");
                string codStock = Console.ReadLine() ?? "";
                int cantStock = PedirEntero("Cantidad a agregar: ");
                servicio.AgregarStock(codStock, cantStock);
                Console.WriteLine("Stock actualizado.");
                break;

            case "3":
                Console.Write("Código: ");
                string codVenta = Console.ReadLine() ?? "";
                int cantVenta = PedirEntero("Cantidad a vender: ");
                servicio.Vender(codVenta, cantVenta);
                Console.WriteLine("Venta realizada.");
                break;

            case "4":
                Mostrar(servicio.Listar());
                break;

            case "5":
                Mostrar(servicio.StockBajo());
                break;

            case "6":
                Console.Write("Texto a buscar (nombre o código): ");
                string texto = Console.ReadLine() ?? "";
                var resultados = servicio.BuscarPorTexto(texto);
                if (resultados.Count == 0)
                    Console.WriteLine("No se encontraron productos.");
                else
                    Mostrar(resultados);
                break;

            case "7":
                Console.Write("Código del producto a eliminar: ");
                string codEliminar = Console.ReadLine() ?? "";
                Console.Write($"¿Seguro que quieres eliminar {codEliminar}? (s/n): ");
                string respuesta = (Console.ReadLine() ?? "").Trim().ToLower();
                if (respuesta == "s")
                {
                    servicio.Eliminar(codEliminar);
                    Console.WriteLine("Producto eliminado.");
                }
                else
                {
                    Console.WriteLine("Eliminación cancelada.");
                }
                break;

            case "8":
                salir = true;
                Console.WriteLine("Hasta luego.");
                break;

            default:
                Console.WriteLine("Opción no válida.");
                break;
        }
    }
    catch (StockInsuficienteException ex)
    {
        Console.WriteLine($"Error de inventario: {ex.Message}");
    }
    catch (ArgumentException ex)
    {
        Console.WriteLine($"Dato inválido: {ex.Message}");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Error inesperado: {ex.Message}");
    }
}

static int PedirEntero(string mensaje)
{
    int valor;
    Console.Write(mensaje);
    while (!int.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Escribe un número entero: ");
    }
    return valor;
}

static decimal PedirDecimal(string mensaje)
{
    decimal valor;
    Console.Write(mensaje);
    while (!decimal.TryParse(Console.ReadLine(), out valor))
    {
        Console.Write("Escribe un número válido: ");
    }
    return valor;
}

static void Mostrar(List<Producto> lista)
{
    if (lista.Count == 0)
    {
        Console.WriteLine("No hay productos.");
        return;
    }
    foreach (var p in lista)
    {
        Console.WriteLine($"{p.Codigo} | {p.Nombre} | ${p.Precio} | Stock: {p.Stock}");
    }
}