namespace Reto10
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
            lblBuscar = new Label();
            txtBuscar = new TextBox();
            btnAgregar = new Button();
            lblValor = new Label();
            btnVender = new Button();
            btnAgregarStock = new Button();
            btnEliminar = new Button();
            nudCantidad = new NumericUpDown();
            dataGridView1 = new DataGridView();
            btnReportes = new Button();
            nudPrecio = new NumericUpDown();
            lblStock = new Label();
            ((System.ComponentModel.ISupportInitialize)nudCantidad).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).BeginInit();
            SuspendLayout();
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(20, 21);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(72, 25);
            lblBuscar.TabIndex = 0;
            lblBuscar.Text = "Buscar: ";
            lblBuscar.Click += lblBuscar_Click;
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(111, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(150, 31);
            txtBuscar.TabIndex = 1;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(531, 60);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(167, 34);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar producto";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(13, 60);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(92, 25);
            lblValor.TabIndex = 4;
            lblValor.Text = "Cantidad: ";
            // 
            // btnVender
            // 
            btnVender.Location = new Point(398, 16);
            btnVender.Name = "btnVender";
            btnVender.Size = new Size(112, 34);
            btnVender.TabIndex = 5;
            btnVender.Text = "Vender";
            btnVender.UseVisualStyleBackColor = true;
            btnVender.Click += btnVender_Click;
            // 
            // btnAgregarStock
            // 
            btnAgregarStock.Location = new Point(531, 13);
            btnAgregarStock.Name = "btnAgregarStock";
            btnAgregarStock.Size = new Size(156, 34);
            btnAgregarStock.TabIndex = 6;
            btnAgregarStock.Text = "Agregar Stock";
            btnAgregarStock.UseVisualStyleBackColor = true;
            btnAgregarStock.Click += btnAgregarStock_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(398, 60);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(112, 34);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // nudCantidad
            // 
            nudCantidad.AllowDrop = true;
            nudCantidad.Location = new Point(111, 58);
            nudCantidad.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudCantidad.Name = "nudCantidad";
            nudCantidad.Size = new Size(180, 31);
            nudCantidad.TabIndex = 8;
            nudCantidad.ThousandsSeparator = true;
            nudCantidad.ValueChanged += nudCantidad_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 164);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(601, 279);
            dataGridView1.TabIndex = 9;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(460, 102);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(153, 34);
            btnReportes.TabIndex = 10;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            btnReportes.Click += btnReportes_Click_1;
            // 
            // nudPrecio
            // 
            nudPrecio.DecimalPlaces = 2;
            nudPrecio.Location = new Point(111, 105);
            nudPrecio.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            nudPrecio.Name = "nudPrecio";
            nudPrecio.Size = new Size(180, 31);
            nudPrecio.TabIndex = 11;
            nudPrecio.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(23, 107);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(69, 25);
            lblStock.TabIndex = 12;
            lblStock.Text = "Precio: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblStock);
            Controls.Add(nudPrecio);
            Controls.Add(btnReportes);
            Controls.Add(dataGridView1);
            Controls.Add(nudCantidad);
            Controls.Add(btnEliminar);
            Controls.Add(btnAgregarStock);
            Controls.Add(btnVender);
            Controls.Add(lblValor);
            Controls.Add(btnAgregar);
            Controls.Add(txtBuscar);
            Controls.Add(lblBuscar);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudCantidad).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBuscar;
        private TextBox txtBuscar;
        private Button btnAgregar;
        private Label lblValor;
        private Button btnVender;
        private Button btnAgregarStock;
        private Button btnEliminar;
        private NumericUpDown nudCantidad;
        private DataGridView dataGridView1;
        private Button btnReportes;
        private NumericUpDown nudPrecio;
        private Label lblStock;
    }
}
