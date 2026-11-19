namespace Practica03
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            txtResultado = new TextBox();
            btnNum1 = new Button();
            btnNum2 = new Button();
            btnNum3 = new Button();
            btnNum4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(97, 50);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 99);
            label2.Name = "label2";
            label2.Size = new Size(59, 25);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 155);
            label3.Name = "label3";
            label3.Size = new Size(59, 25);
            label3.TabIndex = 2;
            label3.Text = "label3";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(192, 44);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(150, 31);
            txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(192, 99);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(150, 31);
            txtNumero2.TabIndex = 4;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(192, 149);
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(150, 31);
            txtResultado.TabIndex = 5;
            // 
            // btnNum1
            // 
            btnNum1.Location = new Point(424, 50);
            btnNum1.Name = "btnNum1";
            btnNum1.Size = new Size(112, 34);
            btnNum1.TabIndex = 6;
            btnNum1.Text = "Sumar";
            btnNum1.UseVisualStyleBackColor = true;
            // 
            // btnNum2
            // 
            btnNum2.Location = new Point(557, 50);
            btnNum2.Name = "btnNum2";
            btnNum2.Size = new Size(112, 33);
            btnNum2.TabIndex = 7;
            btnNum2.Text = "Restar";
            btnNum2.UseVisualStyleBackColor = true;
            btnNum2.Click += btnNum2_Click_1;
            // 
            // btnNum3
            // 
            btnNum3.Location = new Point(424, 94);
            btnNum3.Name = "btnNum3";
            btnNum3.Size = new Size(112, 34);
            btnNum3.TabIndex = 8;
            btnNum3.Text = "Multiplicar";
            btnNum3.UseVisualStyleBackColor = true;
            btnNum3.Click += btnNum3_Click_1;
            // 
            // btnNum4
            // 
            btnNum4.Location = new Point(557, 96);
            btnNum4.Name = "btnNum4";
            btnNum4.Size = new Size(112, 34);
            btnNum4.TabIndex = 9;
            btnNum4.Text = "Dividir";
            btnNum4.UseVisualStyleBackColor = true;
            btnNum4.Click += btnNum4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnNum4);
            Controls.Add(btnNum3);
            Controls.Add(btnNum2);
            Controls.Add(btnNum1);
            Controls.Add(txtResultado);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private TextBox txtResultado;
        private Button btnNum1;
        private Button btnNum2;
        private Button btnNum3;
        private Button btnNum4;
        private readonly EventHandler txtNumero1_TextChanged;
    }
}
