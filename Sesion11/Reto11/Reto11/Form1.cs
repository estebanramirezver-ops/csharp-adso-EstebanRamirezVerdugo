using Microsoft.EntityFrameworkCore;

namespace Reto11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            using (var db = new AgendaContext()) db.Database.EnsureCreated();

            dataGridView1.ReadOnly = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            CargarContactos();
        }

        private void CargarContactos(string filtro = "")
        {
            using var db = new AgendaContext();
            dataGridView1.DataSource = db.Contacto
                .Where(c => EF.Functions.Like(c.Nombre, $"%{filtro}%"))
                .OrderBy(c => c.Nombre)
                .ToList();
            lblTotal.Text = $"{dataGridView1.Rows.Count} contactos";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();
            bool valido = true;

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                errorProvider1.SetError(txtName, "Escribe el nombre.");
                valido = false;
            }
            if (!txtEmail.Text.Contains('@'))
            {
                errorProvider1.SetError(txtEmail, "El correo debe tener @.");
                valido = false;
            }
            if (!valido) return;

            using var db = new AgendaContext();
            db.Contacto.Add(new Contactos
            {
                Nombre = txtName.Text.Trim(),
                Telefono = txtPhone.Text.Trim(),
                Correo = txtEmail.Text.Trim()
            });
            db.SaveChanges();

            txtName.Clear(); txtPhone.Clear(); txtEmail.Clear();
            CargarContactos(txtBuscar.Text);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow?.DataBoundItem is not Contactos contacto) return;
            if (MessageBox.Show($"¿Eliminar a {contacto.Nombre}?", "Confirmar",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes) return;

            using var db = new AgendaContext();
            db.Contacto.Remove(contacto);
            db.SaveChanges();
            CargarContactos(txtBuscar.Text);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
             => CargarContactos(txtBuscar.Text);
        
    }
}