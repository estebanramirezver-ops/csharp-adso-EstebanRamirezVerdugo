namespace Inventario.Modelos;

public class Producto
{
    public string Codigo { get; private set; }
    public string Nombre { get; private set; }
    public decimal Precio { get; private set; }
    public int Stock { get; private set; }

    public Producto(string codigo, string nombre, decimal precio, int stock)
    {
        if (string.IsNullOrWhiteSpace(codigo))
            throw new ArgumentException("El código es obligatorio.");
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("El nombre no puede estar vacío.");
        if (precio <= 0)
            throw new ArgumentException("El precio debe ser mayor que 0.");
        if (stock < 0)
            throw new ArgumentException("El stock no puede ser negativo.");

        Codigo = codigo.Trim().ToUpper();
        Nombre = nombre.Trim();
        Precio = precio;
        Stock = stock;
    }

    public void AgregarStock(int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentException("La cantidad debe ser mayor que 0.");
        Stock += cantidad;
    }

    public void Vender(int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentException("La cantidad debe ser mayor que 0.");
        if (cantidad > Stock)
            throw new StockInsuficienteException(Nombre, Stock);
        Stock -= cantidad;
    }
}