namespace Reto09
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
            lblNum1 = new Label();
            lblNum2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            numericUpDown1 = new NumericUpDown();
            btnDepositar = new Button();
            btnRetirar = new Button();
            listBox1 = new ListBox();
            lblMonto = new Label();
            lblMovimientos = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // lblNum1
            // 
            lblNum1.AutoSize = true;
            lblNum1.Location = new Point(37, 45);
            lblNum1.Name = "lblNum1";
            lblNum1.Size = new Size(69, 25);
            lblNum1.TabIndex = 0;
            lblNum1.Text = "Titular: ";
            lblNum1.Click += lblNum1_Click;
            // 
            // lblNum2
            // 
            lblNum2.AutoSize = true;
            lblNum2.Location = new Point(37, 93);
            lblNum2.Name = "lblNum2";
            lblNum2.Size = new Size(66, 25);
            lblNum2.TabIndex = 1;
            lblNum2.Text = "Saldo: ";
            lblNum2.Click += lblNum2_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(122, 39);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 93);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 3;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(122, 150);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(180, 31);
            numericUpDown1.TabIndex = 4;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(352, 45);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(112, 34);
            btnDepositar.TabIndex = 5;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // btnRetirar
            // 
            btnRetirar.Location = new Point(352, 93);
            btnRetirar.Name = "btnRetirar";
            btnRetirar.Size = new Size(112, 34);
            btnRetirar.TabIndex = 6;
            btnRetirar.Text = "Retirar";
            btnRetirar.UseVisualStyleBackColor = true;
            btnRetirar.Click += btnRetirar_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(156, 212);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(180, 129);
            listBox1.TabIndex = 7;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(25, 150);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(75, 25);
            lblMonto.TabIndex = 8;
            lblMonto.Text = "Monto: ";
            lblMonto.Click += lblMonto_Click;
            // 
            // lblMovimientos
            // 
            lblMovimientos.AutoSize = true;
            lblMovimientos.Location = new Point(25, 228);
            lblMovimientos.Name = "lblMovimientos";
            lblMovimientos.Size = new Size(125, 25);
            lblMovimientos.TabIndex = 9;
            lblMovimientos.Text = "Movimientos: ";
            lblMovimientos.Click += lblMovimientos_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMovimientos);
            Controls.Add(lblMonto);
            Controls.Add(listBox1);
            Controls.Add(btnRetirar);
            Controls.Add(btnDepositar);
            Controls.Add(numericUpDown1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblNum2);
            Controls.Add(lblNum1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNum1;
        private Label lblNum2;
        private TextBox textBox1;
        private TextBox textBox2;
        private NumericUpDown numericUpDown1;
        private Button btnDepositar;
        private Button btnRetirar;
        private ListBox listBox1;
        private Label lblMonto;
        private Label lblMovimientos;
    }
}
