using System.Text.Json;
using Inventario.Modelos;

namespace Inventario.Datos;

public class RepositorioJson : IRepositorioProductos
{
    private readonly string _ruta;
    public RepositorioJson(string ruta) => _ruta = ruta;

    public List<Producto> ObtenerTodos()
    {
        if (!File.Exists(_ruta)) return [];
        try
        {
            return JsonSerializer.Deserialize<List<Producto>>(File.ReadAllText(_ruta)) ?? [];
        }
        catch (Exception ex) when (ex is JsonException || ex is ArgumentException)
        {
            // JsonException: el JSON está mal escrito.
            // ArgumentException: el JSON está bien, pero tiene datos que Producto rechaza.
            File.Copy(_ruta, _ruta + ".danado", overwrite: true);
            return [];
        }
    }

    private void Guardar(List<Producto> lista) =>
        File.WriteAllText(_ruta, JsonSerializer.Serialize(lista, new JsonSerializerOptions { WriteIndented = true }));

    public Producto? BuscarPorCodigo(string codigo)
    {
        var lista = ObtenerTodos();
        return lista.FirstOrDefault(p => p.Codigo == codigo.Trim().ToUpper());
    }

    public void Agregar(Producto producto)
    {
        var lista = ObtenerTodos();
        lista.Add(producto);
        Guardar(lista);
    }

    public void Actualizar(Producto producto)
    {
        var lista = ObtenerTodos();
        int i = lista.FindIndex(p => p.Codigo == producto.Codigo);
        if (i >= 0) { lista[i] = producto; Guardar(lista); }
    }

    public void Eliminar(string codigo)
    {
        var lista = ObtenerTodos();
        lista.RemoveAll(p => p.Codigo == codigo.Trim().ToUpper());
        Guardar(lista);
    }
}