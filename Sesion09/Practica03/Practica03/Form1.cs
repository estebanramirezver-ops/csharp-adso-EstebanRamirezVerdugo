namespace Practica03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool LeerNumeros(out int a, out int b)
        {
            a = b = 0;
            if (!int.TryParse(txtNumero1.Text, out a) || !int.TryParse(txtNumero2.Text, out b))
            {
                MessageBox.Show("Escribe dos números enteros válidos.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnNum1_Click_1(object sender, EventArgs e)
        {
            if (LeerNumeros(out int a, out int b))
                txtResultado.Text = (a + b).ToString();
        }

        private void btnNum2_Click_1(object sender, EventArgs e)
        {
            if (LeerNumeros(out int a, out int b))
                txtResultado.Text = (a - b).ToString();
        }

        private void btnNum3_Click_1(object sender, EventArgs e)
        {
            if (LeerNumeros(out int a, out int b))
                txtResultado.Text = (a * b).ToString();
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            if (!LeerNumeros(out int a, out int b)) return;

            if (b == 0)
            {
                MessageBox.Show("No se puede dividir entre cero.", "Dato inválido",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            txtResultado.Text = ((double)a / b).ToString();
        }
    }
}
