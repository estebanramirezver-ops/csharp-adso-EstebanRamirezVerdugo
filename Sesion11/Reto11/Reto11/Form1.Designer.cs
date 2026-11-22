namespace Reto11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            lblCorreo = new Label();
            lblTelefono = new Label();
            dataGridView1 = new DataGridView();
            errorProvider1 = new ErrorProvider(components);
            txtName = new TextBox();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            lblTotal = new Label();
            btnEliminar = new Button();
            btnAgregar = new Button();
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(33, 21);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(33, 63);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(75, 25);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Correo: ";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(33, 104);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(83, 25);
            lblTelefono.TabIndex = 2;
            lblTelefono.Text = "Teléfono:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(385, 170);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(403, 268);
            dataGridView1.TabIndex = 3;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // txtName
            // 
            txtName.Location = new Point(114, 15);
            txtName.Name = "txtName";
            txtName.Size = new Size(410, 31);
            txtName.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(114, 57);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(410, 31);
            txtEmail.TabIndex = 5;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(114, 98);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(219, 31);
            txtPhone.TabIndex = 6;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(584, 18);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(12, 25);
            lblTotal.TabIndex = 8;
            lblTotal.Text = "\r\n";
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(67, 197);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 9;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(185, 197);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(112, 34);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(39, 146);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(72, 25);
            lblBuscar.TabIndex = 11;
            lblBuscar.Text = "Buscar: ";
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(114, 140);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(183, 31);
            txtBuscar.TabIndex = 12;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Controls.Add(btnAgregar);
            Controls.Add(btnEliminar);
            Controls.Add(lblTotal);
            Controls.Add(txtPhone);
            Controls.Add(txtEmail);
            Controls.Add(txtName);
            Controls.Add(dataGridView1);
            Controls.Add(lblTelefono);
            Controls.Add(lblCorreo);
            Controls.Add(lblNombre);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblCorreo;
        private Label lblTelefono;
        private DataGridView dataGridView1;
        private ErrorProvider errorProvider1;
        private TextBox txtName;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private Label lblTotal;
        private Button btnAgregar;
        private Button btnEliminar;
        private TextBox txtBuscar;
        private Label lblBuscar;
    }
}
