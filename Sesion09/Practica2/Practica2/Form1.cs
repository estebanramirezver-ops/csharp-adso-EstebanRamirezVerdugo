namespace Practica2
{
    public partial class txtNombre : Form
    {
        public txtNombre()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            lblSaludar.Text = $"Hola, {textBox1.Text}: Bienvenido a mis bosques";
        }

        private void lblPregunta_Click(object sender, EventArgs e)
        {

        }
    }
}
