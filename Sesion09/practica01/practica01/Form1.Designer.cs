namespace practica01
{
    partial class lblPregunta
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
            button1 = new Button();
            txtNombre = new TextBox();
            lblSaludo = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(405, 154);
            button1.Margin = new Padding(2, 3, 2, 3);
            button1.Name = "button1";
            button1.Size = new Size(84, 50);
            button1.TabIndex = 2;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(236, 163);
            txtNombre.Margin = new Padding(2, 3, 2, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(138, 41);
            txtNombre.TabIndex = 3;
            // 
            // lblSaludo
            // 
            lblSaludo.AutoSize = true;
            lblSaludo.Location = new Point(236, 225);
            lblSaludo.Margin = new Padding(2, 0, 2, 0);
            lblSaludo.Name = "lblSaludo";
            lblSaludo.Size = new Size(0, 33);
            lblSaludo.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 119);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(151, 33);
            label1.TabIndex = 5;
            label1.Text = "Como te llamas?";
            // 
            // lblPregunta
            // 
            AutoScaleDimensions = new SizeF(10F, 33F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1336, 833);
            Controls.Add(label1);
            Controls.Add(lblSaludo);
            Controls.Add(txtNombre);
            Controls.Add(button1);
            Font = new Font("Agency FB", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.Green;
            Margin = new Padding(3, 4, 3, 4);
            Name = "lblPregunta";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private TextBox txtNombre;
        private Label lblSaludo;
        private Label label1;
    }
}
