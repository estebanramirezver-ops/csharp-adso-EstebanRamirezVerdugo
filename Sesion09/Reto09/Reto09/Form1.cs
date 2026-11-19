using Tarea05;

namespace Reto09
{
    public partial class Form1 : Form
    {
        private readonly CuentaBancaria _cuenta = new CuentaBancaria("Ana Gómez", "001", 100000m);

        public Form1()
        {
            InitializeComponent();
            ActualizarPantalla();
            numericUpDown1.Maximum = 1000000000;
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.ThousandsSeparator = true;
        }

        private void ActualizarPantalla()
        {
            textBox1.Text = _cuenta.Titular;
            textBox2.Text = _cuenta.Saldo.ToString("C");
        }

        private void RegistrarMovimiento(string tipo, decimal monto)
        {
            string linea = $"{DateTime.Now:HH:mm:ss} | {tipo} {monto:C} | Saldo: {_cuenta.Saldo:C}";
            listBox1.Items.Insert(0, linea);
        }

        private void btnDepositar_Click(object sender, EventArgs e)
        {
            decimal monto = numericUpDown1.Value;

            if (_cuenta.Depositar(monto))
            {
                RegistrarMovimiento("Depósito", monto);
                ActualizarPantalla();
                numericUpDown1.Value = 0;
            }
            else
            {
                MessageBox.Show(
                    "No se pudo realizar el depósito.\nEl monto debe ser mayor que 0.",
                    "Depósito rechazado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            numericUpDown1.Focus();
        }

        private void btnRetirar_Click(object sender, EventArgs e)
        {
            decimal monto = numericUpDown1.Value;

            if (_cuenta.Retirar(monto))
            {
                RegistrarMovimiento("Retiro", monto);
                ActualizarPantalla();
                numericUpDown1.Value = 0;
            }
            else
            {
                MessageBox.Show(
                    "No se pudo realizar el retiro.\nEl monto debe ser mayor que 0 y no puede superar el saldo disponible.",
                    "Retiro rechazado",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }

            numericUpDown1.Focus();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < 0) return;

            MessageBox.Show(
                listBox1.SelectedItem!.ToString(),
                "Detalle del movimiento",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void lblMonto_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = 0;
            numericUpDown1.Focus();
        }

        private void lblNum2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox2.Text);
            MessageBox.Show("Saldo copiado al portapapeles.", "Saldo");
        }

        private void lblNum1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                $"Titular: {_cuenta.Titular}\nNúmero de cuenta: {_cuenta.Numero}",
                "Datos de la cuenta",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = $"Cuenta de {textBox1.Text}";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.ForeColor = _cuenta.Saldo == 0 ? Color.Red : SystemColors.WindowText;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblMovimientos_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count == 0) return;

            DialogResult respuesta = MessageBox.Show(
                "¿Quieres limpiar la lista de movimientos?\nEl saldo no cambia.",
                "Limpiar movimientos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                listBox1.Items.Clear();
        }
    }
}