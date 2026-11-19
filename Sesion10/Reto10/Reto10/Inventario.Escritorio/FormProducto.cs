using Inventario.Modelos;

namespace Reto10
{
    public partial class FormProducto : Form
    {
        public Producto? ProductoCreado { get; private set; }

        public FormProducto()
        {
            InitializeComponent();
        }

        public FormProducto(Producto producto) : this()
        {
            Text = "Editar producto";
            txtBox2.Text = producto.Codigo;
            txtBox2.Enabled = false;
            txtBox1.Text = producto.Nombre; 
            numericUpDown1.Value = producto.Precio;
            numericUpDown2.Value = producto.Stock;
            numericUpDown2.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            try
            {
                ProductoCreado = new Producto(txtBox2.Text, txtBox1.Text, numericUpDown1.Value, (int)numericUpDown2.Value);
                DialogResult = DialogResult.OK;
            }
            catch (ArgumentException ex)
            {
                errorProvider1.SetError(btnGuardar, ex.Message);
            }
        }
    }
}