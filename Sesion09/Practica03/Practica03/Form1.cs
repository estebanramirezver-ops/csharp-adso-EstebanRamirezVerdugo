namespace Practica03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNum1_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) + Convert.ToInt32(txtNumero2.Text));
        }

        private void btnNum2_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) - Convert.ToInt32(txtNumero2.Text));
        }

        private void btnNum3_Click_1(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) * Convert.ToInt32(txtNumero2.Text));
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            txtResultado.Text = Convert.ToString(Convert.ToInt32(txtNumero1.Text) / Convert.ToInt32(txtNumero2.Text));
        }
    }
}
