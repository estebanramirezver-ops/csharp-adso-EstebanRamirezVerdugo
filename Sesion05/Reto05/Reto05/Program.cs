using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        List<Producto> inventario =
        [
            new Producto("p001", "Cuaderno", 4500m, 20),
            new Producto("p002", "Lápiz", 1200m, 50),
            new Producto("p003", "Borrador", 800m, 30)
        ];

        List<LineaVenta> carrito = new List<LineaVenta>();

        bool salir = false;
        while (!salir)
        {
            Console.WriteLine("\n===== TIENDA =====");
            Console.WriteLine("1. Registrar producto");
            Console.WriteLine("2. Agregar stock");
            Console.WriteLine("3. Vender (al carrito)");
            Console.WriteLine("4. Ver carrito con total");
            Console.WriteLine("5. Ver inventario");
            Console.WriteLine("6. Salir");
            Console.Write("Opción: ");
            string opcion = Console.ReadLine() ?? "";

            switch (opcion)
            {
                case "1":
                    RegistrarProducto(inventario);
                    break;
                case "2":
                    AgregarStock(inventario);
                    break;
                case "3":
                    Vender(inventario, carrito);
                    break;
                case "4":
                    VerCarrito(carrito);
                    break;
                case "5":
                    VerInventario(inventario);
                    break;
                case "6":
                    salir = true;
                    Console.WriteLine("¡Hasta luego!");
                    break;
                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }
        }
    }

    static void RegistrarProducto(List<Producto> inventario)
    {
        try
        {
            Console.Write("Código: ");
            string codigo = Console.ReadLine() ?? "";

            if (inventario.Any(p => p.Codigo == codigo.Trim().ToUpper()))
                throw new ArgumentException("Ya existe un producto con ese código.");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine() ?? "";

            Console.Write("Precio: ");
            if (!decimal.TryParse(Console.ReadLine(), out decimal precio))
                throw new ArgumentException("El precio debe ser un número.");

            Console.Write("Stock inicial: ");
            if (!int.TryParse(Console.ReadLine(), out int stock))
                throw new ArgumentException("El stock debe ser un número entero.");

            inventario.Add(new Producto(codigo, nombre, precio, stock));
            Console.WriteLine("Producto registrado correctamente.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"No se pudo registrar: {ex.Message}");
        }
    }

    static void AgregarStock(List<Producto> inventario)
    {
        Console.Write("Código del producto: ");
        string codigo = (Console.ReadLine() ?? "").Trim().ToUpper();

        Producto? producto = inventario.FirstOrDefault(p => p.Codigo == codigo);
        if (producto == null)
        {
            Console.WriteLine("Ese producto no existe.");
            return;
        }

        Console.Write("Cantidad a agregar: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad))
        {
            Console.WriteLine("La cantidad debe ser un número entero.");
            return;
        }

        try
        {
            producto.AgregarStock(cantidad);
            Console.WriteLine($"Stock actualizado: {producto.Nombre} ahora tiene {producto.Stock} unidades.");
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine($"No se pudo agregar: {ex.Message}");
        }
    }

    static void Vender(List<Producto> inventario, List<LineaVenta> carrito)
    {
        Console.Write("Código del producto: ");
        string codigo = (Console.ReadLine() ?? "").Trim().ToUpper();

        Producto? producto = inventario.FirstOrDefault(p => p.Codigo == codigo);
        if (producto == null)
        {
            Console.WriteLine("Ese producto no existe.");
            return;
        }

        Console.Write("Cantidad a vender: ");
        if (!int.TryParse(Console.ReadLine(), out int cantidad))
        {
            Console.WriteLine("La cantidad debe ser un número entero.");
            return;
        }

        if (producto.Vender(cantidad))
        {
            decimal subtotal = producto.Precio * cantidad;
            carrito.Add(new LineaVenta(producto.Codigo, producto.Nombre, cantidad, subtotal));
            Console.WriteLine($"Agregado al carrito: {cantidad} x {producto.Nombre} = {subtotal:N0}");
        }
        else
        {
            Console.WriteLine($"No se pudo vender. Cantidad inválida o stock insuficiente (hay {producto.Stock}).");
        }
    }

    static void VerCarrito(List<LineaVenta> carrito)
    {
        if (carrito.Count == 0)
        {
            Console.WriteLine("El carrito está vacío.");
            return;
        }

        Console.WriteLine("\n--- CARRITO ---");
        foreach (LineaVenta linea in carrito)
            Console.WriteLine($"{linea.Codigo} | {linea.Nombre} | x{linea.Cantidad} | {linea.Subtotal:N0}");

        decimal total = carrito.Sum(l => l.Subtotal);
        Console.WriteLine($"TOTAL: {total:N0}");
    }

    static void VerInventario(List<Producto> inventario)
    {
        Console.WriteLine("\n--- INVENTARIO ---");
        foreach (Producto p in inventario)
            Console.WriteLine(p);
    }
}

public class Producto
{
    private string _nombre = "";
    private decimal _precio;

    public string Codigo { get; private set; }

    public string Nombre
    {
        get => _nombre;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("El nombre no puede estar vacío.");
            _nombre = value.Trim();
        }
    }

    public decimal Precio
    {
        get => _precio;
        set
        {
            if (value <= 0)
                throw new ArgumentException("El precio debe ser mayor que cero.");
            _precio = value;
        }
    }

    public int Stock { get; private set; }

    public Producto(string codigo, string nombre, decimal precio, int stock)
    {
        if (string.IsNullOrWhiteSpace(codigo))
            throw new ArgumentException("El código es obligatorio.");
        if (stock < 0)
            throw new ArgumentException("El stock no puede ser negativo.");

        Codigo = codigo.Trim().ToUpper();
        Nombre = nombre; 
        Precio = precio;
        Stock = stock;
    }

    public void AgregarStock(int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentException("La cantidad a agregar debe ser mayor que cero.");
        Stock += cantidad;
    }

    public bool Vender(int cantidad)
    {
        if (cantidad <= 0 || cantidad > Stock) return false;
        Stock -= cantidad;
        return true;
    }

    public override string ToString() =>
        $"{Codigo} | {Nombre} | Precio: {Precio:N0} | Stock: {Stock}";
}

public record LineaVenta(string Codigo, string Nombre, int Cantidad, decimal Subtotal);