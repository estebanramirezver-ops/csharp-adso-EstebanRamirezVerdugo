namespace practica01
{
    public partial class lblPregunta : Form
    {
        public lblPregunta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lblSaludo.Text = $"Hola. {txtNombre.Text}: Bienvenido a mi programa";
        }
    }
}
