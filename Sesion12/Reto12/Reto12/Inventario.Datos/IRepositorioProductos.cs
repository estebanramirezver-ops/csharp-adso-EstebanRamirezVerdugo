using Inventario.Modelos;
using Microsoft.EntityFrameworkCore;
using Reto12.Inventario.Modelos;

namespace Inventario.Datos;


public class RepositorioEf : IRepositorioProductos
{
    private readonly InventarioContext _db = new();

    public RepositorioEf()
    {
        _db.Database.EnsureCreated();
        if (!_db.Categorias.Any())
        {
            _db.Categorias.AddRange(
                new Categoria { Nombre = "Papelería" },
                new Categoria { Nombre = "Tecnología" },
                new Categoria { Nombre = "Aseo" });
            _db.SaveChanges();
        }
    }

    public List<Producto> ObtenerTodos() =>
        _db.Productos.Include(p => p.Categoria).ToList();

    public Producto? BuscarPorCodigo(string codigo)
    {
        string clave = codigo.Trim().ToUpper();
        return _db.Productos.Include(p => p.Categoria).FirstOrDefault(p => p.Codigo == clave);
    }

    public void Agregar(Producto producto) { _db.Productos.Add(producto); _db.SaveChanges(); }

    public void Actualizar(Producto producto) { _db.Productos.Update(producto); _db.SaveChanges(); }

    public void Eliminar(string codigo)
    {
        var producto = BuscarPorCodigo(codigo);
        if (producto is null) return;
        _db.Productos.Remove(producto);
        _db.SaveChanges();
    }

    public List<Categoria> ObtenerCategorias() => _db.Categorias.OrderBy(c => c.Nombre).ToList();
}

public interface IRepositorioProductos
{
    List<Producto> ObtenerTodos();
    Producto? BuscarPorCodigo(string codigo);
    void Agregar(Producto producto);
    void Actualizar(Producto producto);
    void Eliminar(string codigo);
    List<Categoria> ObtenerCategorias();
}