namespace Tarea09
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
            lblCop = new Label();
            txtBox1 = new TextBox();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            lblOrigen = new Label();
            lblDestino = new Label();
            lblConversion = new Label();
            txtBox2 = new TextBox();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblCop
            // 
            lblCop.AutoSize = true;
            lblCop.Location = new Point(30, 67);
            lblCop.Name = "lblCop";
            lblCop.Size = new Size(61, 25);
            lblCop.TabIndex = 0;
            lblCop.Text = "Valor: ";
            lblCop.Click += lblCop_Click;
            // 
            // txtBox1
            // 
            txtBox1.Location = new Point(111, 61);
            txtBox1.Name = "txtBox1";
            txtBox1.Size = new Size(150, 31);
            txtBox1.TabIndex = 2;
            txtBox1.TextChanged += textBox1_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(188, 118);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 8;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(188, 169);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(182, 33);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // lblOrigen
            // 
            lblOrigen.AutoSize = true;
            lblOrigen.Location = new Point(12, 121);
            lblOrigen.Name = "lblOrigen";
            lblOrigen.Size = new Size(168, 25);
            lblOrigen.TabIndex = 11;
            lblOrigen.Text = "Moneda de origen: ";
            // 
            // lblDestino
            // 
            lblDestino.AutoSize = true;
            lblDestino.Location = new Point(4, 177);
            lblDestino.Name = "lblDestino";
            lblDestino.Size = new Size(176, 25);
            lblDestino.TabIndex = 12;
            lblDestino.Text = "Moneda de destino: ";
            lblDestino.Click += label1_Click;
            // 
            // lblConversion
            // 
            lblConversion.AutoSize = true;
            lblConversion.Location = new Point(4, 235);
            lblConversion.Name = "lblConversion";
            lblConversion.Size = new Size(110, 25);
            lblConversion.TabIndex = 13;
            lblConversion.Text = "Conversión: ";
            // 
            // txtBox2
            // 
            txtBox2.Location = new Point(111, 235);
            txtBox2.Name = "txtBox2";
            txtBox2.Size = new Size(150, 31);
            txtBox2.TabIndex = 14;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtBox2);
            Controls.Add(lblConversion);
            Controls.Add(lblDestino);
            Controls.Add(lblOrigen);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(txtBox1);
            Controls.Add(lblCop);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCop;
        private TextBox txtBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private Label lblOrigen;
        private Label lblDestino;
        private Label lblConversion;
        private TextBox txtBox2;
        private ErrorProvider errorProvider1;
    }
}
