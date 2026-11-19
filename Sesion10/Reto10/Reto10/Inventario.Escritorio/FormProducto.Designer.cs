namespace Reto10
{
    partial class FormProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblNombre = new Label();
            lblCodigo = new Label();
            txtBox1 = new TextBox();
            txtBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            errorProvider1 = new ErrorProvider(components);
            lblPrecio = new Label();
            numericUpDown2 = new NumericUpDown();
            lblStock = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            SuspendLayout();
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(59, 22);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(87, 25);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre: ";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(59, 62);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(80, 25);
            lblCodigo.TabIndex = 1;
            lblCodigo.Text = "Código: ";
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(156, 16);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(150, 31);
            txtBox1.TabIndex = 2;
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(156, 62);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(150, 31);
            txtBox2.TabIndex = 3;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Location = new Point(156, 114);
            numericUpDown1.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ThousandsSeparator = true;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(63, 120);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(69, 25);
            lblPrecio.TabIndex = 5;
            lblPrecio.Text = "Precio: ";
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(156, 173);
            numericUpDown2.Maximum = new decimal(new int[] { 100000000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(180, 31);
            numericUpDown2.TabIndex = 6;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(59, 179);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(64, 25);
            lblStock.TabIndex = 7;
            lblStock.Text = "Stock: ";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(63, 246);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(112, 34);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(194, 246);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(112, 34);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // FormProducto
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(lblStock);
            Controls.Add(numericUpDown2);
            Controls.Add(lblPrecio);
            Controls.Add(numericUpDown1);
            Controls.Add(txtBox2);
            Controls.Add(txtBox1);
            Controls.Add(lblCodigo);
            Controls.Add(lblNombre);
            Name = "FormProducto";
            Text = "FormProducto";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombre;
        private Label lblCodigo;
        private TextBox txtBox1;
        private TextBox txtBox2;
        private NumericUpDown numericUpDown1;
        private ErrorProvider errorProvider1;
        private Button btnCancelar;
        private Button btnGuardar;
        private Label lblStock;
        private NumericUpDown numericUpDown2;
        private Label lblPrecio;
    }
}