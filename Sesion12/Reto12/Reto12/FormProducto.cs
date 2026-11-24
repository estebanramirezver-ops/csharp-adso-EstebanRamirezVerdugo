using Inventario.Modelos;
using Reto12.Inventario.Modelos;

namespace Reto10
{
    public partial class FormProducto : Form
    {

        public Producto? ProductoCreado { get; private set; }

        public FormProducto(List<Categoria> categorias)
        {
            InitializeComponent();
            cmbCategoria.DataSource = categorias;
            cmbCategoria.DisplayMember = "Nombre";
            cmbCategoria.ValueMember = "Id";
            Controls.Add(new Label
            {
                Text = "Categoría:",
                AutoSize = true,
                Location = new Point(59, cmbCategoria.Top + 6)
            });
        }

        public FormProducto(List<Categoria> categorias, Producto producto) : this(categorias)
        {
            Text = "Editar producto";
            txtBox2.Text = producto.Codigo;
            txtBox2.Enabled = false;
            txtBox1.Text = producto.Nombre;
            numericUpDown1.Value = producto.Precio;
            numericUpDown2.Value = producto.Stock;
            numericUpDown2.Enabled = false;
            if (producto.CategoriaId is int categoriaId) cmbCategoria.SelectedValue = categoriaId;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                ProductoCreado = new Producto(txtBox2.Text, txtBox1.Text, numericUpDown1.Value, (int)numericUpDown2.Value);
                ProductoCreado.CambiarCategoria(cmbCategoria.SelectedValue as int?);
                DialogResult = DialogResult.OK;
            }
            catch (ArgumentException ex)
            {
                errorProvider1.SetError(btnGuardar, ex.Message);
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}