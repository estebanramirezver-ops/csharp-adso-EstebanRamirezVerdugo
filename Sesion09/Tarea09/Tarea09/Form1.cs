using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tarea09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] monedas = ["COP", "USD", "EUR"];
            comboBox1.Items.AddRange(monedas);
            comboBox2.Items.AddRange(monedas);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertirAutomatico();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConvertirAutomatico();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            ConvertirAutomatico();
        }

        private void lblCop_Click(object sender, EventArgs e)
        {
            if (txtBox2.Text == "")
            {
                MessageBox.Show("Todavía no hay un resultado para copiar.");
                return;
            }

            Clipboard.SetText(txtBox2.Text);
            MessageBox.Show("Resultado copiado al portapapeles.");
        }

        private void label1_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            txtBox1.Clear();
            txtBox2.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 1;
            txtBox1.Focus();
        }

        private void ConvertirAutomatico()
        {
            if (txtBox1.Text.Trim() == "" ||
                comboBox1.SelectedItem == null ||
                comboBox2.SelectedItem == null)
            {
                errorProvider1.Clear();
                txtBox2.Clear();
                return;
            }

            Convertir();
        }

        private void Convertir()
        {
            errorProvider1.Clear();
            txtBox2.Clear();

            bool valido = true;

            if (!double.TryParse(txtBox1.Text, out double valor))
            {
                errorProvider1.SetError(txtBox1, "Escribe un número válido.");
                valido = false;
            }
            else if (valor < 0)
            {
                errorProvider1.SetError(txtBox1, "El valor no puede ser negativo.");
                valido = false;
            }

            if (comboBox1.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox1, "Elige la moneda de origen.");
                valido = false;
            }

            if (comboBox2.SelectedItem == null)
            {
                errorProvider1.SetError(comboBox2, "Elige la moneda de destino.");
                valido = false;
            }

            if (!valido) return;

            string origen = comboBox1.SelectedItem!.ToString()!;
            string destino = comboBox2.SelectedItem!.ToString()!;

            double resultado = ConversorMoneda.Convertir(valor, origen, destino);
            txtBox2.Text = $"{resultado:N2} {destino}";
        }
    }
}