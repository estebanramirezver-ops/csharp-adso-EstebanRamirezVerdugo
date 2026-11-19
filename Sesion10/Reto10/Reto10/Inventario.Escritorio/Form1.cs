using Inventario.Datos;
using Inventario.Modelos;
using Inventario.Servicios;

namespace Reto10
{
    public partial class Form1 : Form
    {
        private readonly ServicioInventario _servicio = new(new RepositorioJson("inventario.json"));

        public Form1()
        {
            InitializeComponent();

            dataGridView1.DataBindingComplete += dgvProductos_DataBindingComplete;
            dataGridView1.CellDoubleClick += dgvProductos_CellDoubleClick;

            CargarProductos();
        }

        private void CargarProductos()
        {
            string? codigoSeleccionado = Seleccionado()?.Codigo;

            string texto = txtBuscar.Text.Trim();
            List<Producto> productos = texto == ""
                ? _servicio.Listar()
                : _servicio.BuscarPorTexto(texto);

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productos;

            if (codigoSeleccionado != null)
            {
                foreach (DataGridViewRow fila in dataGridView1.Rows)
                {
                    if (fila.DataBoundItem is Producto p && p.Codigo == codigoSeleccionado)
                    {
                        dataGridView1.CurrentCell = fila.Cells[0];
                        break;
                    }
                }
            }

            decimal total = _servicio.Listar().Sum(p => p.Precio * p.Stock);
        }

        private Producto? Seleccionado() => dataGridView1.CurrentRow?.DataBoundItem as Producto;

        private void dgvProductos_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            if (dataGridView1.Columns["Precio"] is DataGridViewColumn precio)
            {
                precio.DefaultCellStyle.Format = "C0";
                precio.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }

            HashSet<string> codigosBajos = _servicio.StockBajo().Select(p => p.Codigo).ToHashSet();

            foreach (DataGridViewRow fila in dataGridView1.Rows)
            {
                if (fila.DataBoundItem is Producto p && codigosBajos.Contains(p.Codigo))
                {
                    fila.DefaultCellStyle.BackColor = Color.MistyRose;
                    fila.DefaultCellStyle.ForeColor = Color.DarkRed;
                }
            }
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {
            txtBuscar.Focus();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            CargarProductos();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (Seleccionado() is not Producto producto)
            {
                MessageBox.Show("Selecciona un producto de la lista.", "Sin selección",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int cantidad = (int)nudCantidad.Value;

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor que 0.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (cantidad > producto.Stock)
            {
                MessageBox.Show($"No hay suficiente {producto.Nombre}. Disponible: {producto.Stock}.",
                    "Stock insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                _servicio.Vender(producto.Codigo, cantidad);

                MessageBox.Show(
                    $"Producto vendido: {producto.Nombre}\n" +
                    $"Cantidad: {cantidad}\n" +
                    $"Precio unitario: {producto.Precio:C0}\n" +
                    $"Total: {producto.Precio * cantidad:C0}\n" +
                    $"Stock restante: {producto.Stock - cantidad}",
                    "Venta realizada", MessageBoxButtons.OK, MessageBoxIcon.Information);

                nudCantidad.Value = 1;
                CargarProductos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo vender", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarStock_Click(object sender, EventArgs e)
        {
            if (Seleccionado() is not Producto producto)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }
            try
            {
                _servicio.AgregarStock(producto.Codigo, (int)nudCantidad.Value);
                CargarProductos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Dato inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Seleccionado() is not Producto producto)
            {
                MessageBox.Show("Selecciona un producto.");
                return;
            }

            var respuesta = MessageBox.Show($"¿Eliminar {producto.Nombre}?", "Confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                _servicio.Eliminar(producto.Codigo);
                CargarProductos();
            }
        }

        private void dgvProductos_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (dataGridView1.Rows[e.RowIndex].DataBoundItem is not Producto producto) return;

            using var form = new FormProducto(producto);
            if (form.ShowDialog() != DialogResult.OK || form.ProductoCreado is null) return;

            try
            {
                Producto editado = form.ProductoCreado;
                _servicio.Actualizar(editado.Codigo, editado.Nombre, editado.Precio);
                CargarProductos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo actualizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        private void btnReportes_Click(object sender, EventArgs e)
        {
            using var form = new FormReportes(_servicio);
            form.ShowDialog(this);
        }

        private void nudCantidad_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnReportes_Click_1(object sender, EventArgs e)
        {
            using var form = new FormReportes(_servicio);
            form.ShowDialog(this);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            using var form = new FormProducto();
            if (form.ShowDialog(this) != DialogResult.OK || form.ProductoCreado is null) return;

            try
            {
                _servicio.Agregar(form.ProductoCreado);
                CargarProductos();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "No se pudo agregar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}