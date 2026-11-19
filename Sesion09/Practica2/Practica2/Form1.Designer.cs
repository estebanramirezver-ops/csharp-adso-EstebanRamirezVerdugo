namespace Practica2
{
    partial class txtNombre
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
            lblPregunta = new Label();
            textBox1 = new TextBox();
            btnSaludar = new Button();
            lblSaludar = new Label();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Vivaldi", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(215, 57);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(175, 33);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "Como te llamas?";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(215, 105);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 1;
            // 
            // btnSaludar
            // 
            btnSaludar.Location = new Point(398, 102);
            btnSaludar.Name = "btnSaludar";
            btnSaludar.Size = new Size(173, 34);
            btnSaludar.TabIndex = 2;
            btnSaludar.Text = "Ola Ola, Pasa Pasa";
            btnSaludar.UseVisualStyleBackColor = true;
            btnSaludar.Click += btnSaludar_Click;
            // 
            // lblSaludar
            // 
            lblSaludar.AutoSize = true;
            lblSaludar.Location = new Point(215, 158);
            lblSaludar.Name = "lblSaludar";
            lblSaludar.Size = new Size(0, 25);
            lblSaludar.TabIndex = 3;
            // 
            // txtNombre
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblSaludar);
            Controls.Add(btnSaludar);
            Controls.Add(textBox1);
            Controls.Add(lblPregunta);
            Name = "txtNombre";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPregunta;
        private TextBox textBox1;
        private Button btnSaludar;
        private Label lblSaludar;
    }
}
