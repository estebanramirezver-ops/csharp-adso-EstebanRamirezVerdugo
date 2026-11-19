using Inventario.Modelos;

namespace Inventario.Datos;

public class RepositorioMemoria : IRepositorioProductos
{
    private readonly List<Producto> _lista = new();

    public List<Producto> ObtenerTodos() => _lista.ToList();

    public Producto? BuscarPorCodigo(string codigo) =>
        _lista.FirstOrDefault(p => p.Codigo == codigo.Trim().ToUpper());

    public void Agregar(Producto producto) => _lista.Add(producto);

    public void Actualizar(Producto producto)
    {
        int i = _lista.FindIndex(p => p.Codigo == producto.Codigo);
        if (i >= 0) _lista[i] = producto;
    }

    public void Eliminar(string codigo) =>
        _lista.RemoveAll(p => p.Codigo == codigo.Trim().ToUpper());
}