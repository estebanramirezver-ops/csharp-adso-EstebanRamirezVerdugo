using Inventario.Modelos;
using Inventario.Servicios;
using System.Globalization;

namespace Reto10
{
    public partial class FormReportes : Form
    {
        private record FilaValiosa(string Nombre, string Codigo, decimal Precio);

        private readonly ServicioInventario? _servicio;

        private TextBox TxtValiosos => textBox1;
        private TextBox TxtStockBajo => textBox2;

        public FormReportes()
        {
            InitializeComponent();


            dgvProductovalioso.DataBindingComplete += FormatearTabla;

        }

        public FormReportes(ServicioInventario servicio) : this()
        {
            _servicio = servicio;
            CargarValiosos();
            MostrarMasCaro();
            MostrarStockBajo();
            CargarStockBajo();
        }

        private static IEnumerable<Control> Todos(Control raiz)
        {
            foreach (Control c in raiz.Controls)
            {
                yield return c;
                foreach (Control hijo in Todos(c)) yield return hijo;
            }
        }

        private void MostrarMasCaro()
        {
            Producto? masCaro = _servicio!.Listar().MaxBy(p => p.Precio);

            textBox3.ReadOnly = true;
            textBox3.Text = masCaro is null
                ? "No hay productos"
                : $"{masCaro.Nombre} - {masCaro.Precio:C0}";
        }

        private static bool Coincide(Producto p, string texto) =>
            texto == ""
            || p.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase)
            || p.Codigo.Contains(texto, StringComparison.OrdinalIgnoreCase);

        private static bool TryRangoPrecio(string texto, out decimal min, out decimal max)
        {
            min = max = 0;
            var cultura = new CultureInfo("es-CO");
            string[] partes = texto.Split('-', StringSplitOptions.TrimEntries | StringSplitOptions.RemoveEmptyEntries);

            if (partes.Length == 2
                && decimal.TryParse(partes[0], NumberStyles.Currency, cultura, out min)
                && decimal.TryParse(partes[1], NumberStyles.Currency, cultura, out max))
            {
                if (min > max) (min, max) = (max, min);
                return true;
            }

            if (partes.Length == 1
                && decimal.TryParse(partes[0], NumberStyles.Currency, cultura, out decimal precio))
            {
                min = precio * 0.8m;
                max = precio * 1.2m;
                return true;
            }

            return false;
        }

        private List<FilaValiosa> CargarValiosos()
        {
            string texto = TxtValiosos.Text.Trim();
            string textoPrecio = textBox3.Text.Trim();

            IEnumerable<Producto> productos = _servicio!.Listar().Where(p => Coincide(p, texto));

            bool filtraPorPrecio = textoPrecio != "";
            if (filtraPorPrecio)
            {
                if (!TryRangoPrecio(textoPrecio, out decimal min, out decimal max))
                {
                    MessageBox.Show("Escribe un precio (5000) o un rango (3000-8000).", "Precio no válido",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return [];
                }
                productos = productos.Where(p => p.Precio >= min && p.Precio <= max);
            }

            var ordenados = productos.OrderByDescending(p => p.Precio * p.Stock);

            var lista = (filtraPorPrecio ? ordenados : ordenados.Take(5))
                .Select(p => new FilaValiosa(p.Nombre, p.Codigo, p.Precio))
                .ToList();

            dgvProductovalioso.DataSource = lista;
            return lista;
        }

        private void MostrarStockBajo()
        {
            List<Producto> bajos = _servicio!.StockBajo();

            textBox2.ReadOnly = true;

            if (bajos.Count < 0)
            {
                textBox2.Text = "Ningún producto con stock bajo";
                return;
            }

            Producto menor = bajos[0];
            textBox2.Text = $"{menor.Nombre} ({menor.Codigo}) - Stock: {menor.Stock}"
                          + (bajos.Count > 1 ? $"  (+{bajos.Count - 1} más)" : "");

            new ToolTip().SetToolTip(textBox2,
                string.Join("\n", bajos.Select(p => $"{p.Nombre} ({p.Codigo}): {p.Stock}")));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (_servicio is null) return;
            if (CargarValiosos().Count == 0)
                MessageBox.Show("No se encontraron productos valiosos con ese texto.", "Sin resultados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_servicio is null) return;
            MostrarStockBajo();
        }

        private void FormatearTabla(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (sender is not DataGridView tabla) return;

            foreach (string nombre in new[] { "Precio", "Valor" })
            {
                if (tabla.Columns[nombre] is DataGridViewColumn columna)
                {
                    columna.DefaultCellStyle.Format = "C0";
                    columna.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }
        }

        private void dgvStockbajo_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void dgvStockBajo_CellContentClick_1(object sender, DataGridViewCellEventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void FormReportes_Load(object sender, EventArgs e) { }
        private void btnGuardar_Click(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void CargarStockBajo()
        {
            List<Producto> filas = _servicio!.StockBajo()
                .Select(p => new Producto(p.Codigo, p.Nombre, p.Precio, p.Stock))
                .ToList();

            dataGridView1.DataSource = filas;

            lblStock.Text = filas.Count == 0
                ? "Stock bajo: ningún producto"
                : $"Stock bajo ({filas.Count})";
        }

        private void lblStock_Click(object sender, EventArgs e)
        {

        }
    }
}