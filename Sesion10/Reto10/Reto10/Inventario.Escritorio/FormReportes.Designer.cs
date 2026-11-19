namespace Reto10
{
    partial class FormReportes
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
            contextMenuStrip1 = new ContextMenuStrip(components);
            dgvProductovalioso = new DataGridView();
            lblValiosos = new Label();
            textBox1 = new TextBox();
            lblStock = new Label();
            lblProductosValiosos = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            button4 = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvProductovalioso).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // dgvProductovalioso
            // 
            dgvProductovalioso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductovalioso.Location = new Point(22, 156);
            dgvProductovalioso.Name = "dgvProductovalioso";
            dgvProductovalioso.RowHeadersWidth = 62;
            dgvProductovalioso.Size = new Size(342, 282);
            dgvProductovalioso.TabIndex = 3;
            // 
            // lblValiosos
            // 
            lblValiosos.AutoSize = true;
            lblValiosos.Location = new Point(12, 34);
            lblValiosos.Name = "lblValiosos";
            lblValiosos.Size = new Size(80, 25);
            lblValiosos.TabIndex = 0;
            lblValiosos.Text = "Código: ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(89, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 2;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(12, 79);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(104, 25);
            lblStock.TabIndex = 8;
            lblStock.Text = "Stock bajo: ";
            lblStock.Click += lblStock_Click;
            // 
            // lblProductosValiosos
            // 
            lblProductosValiosos.AutoSize = true;
            lblProductosValiosos.Location = new Point(12, 119);
            lblProductosValiosos.Name = "lblProductosValiosos";
            lblProductosValiosos.Size = new Size(172, 25);
            lblProductosValiosos.TabIndex = 9;
            lblProductosValiosos.Text = "Productos Valiosos: ";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 76);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(243, 31);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(190, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(243, 31);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button4
            // 
            button4.Location = new Point(260, 25);
            button4.Name = "button4";
            button4.Size = new Size(112, 34);
            button4.TabIndex = 15;
            button4.Text = "Buscar";
            button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(407, 156);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(360, 282);
            dataGridView1.TabIndex = 16;
            // 
            // FormReportes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(button4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(lblProductosValiosos);
            Controls.Add(lblStock);
            Controls.Add(dgvProductovalioso);
            Controls.Add(textBox1);
            Controls.Add(lblValiosos);
            Name = "FormReportes";
            Text = "FormReportes";
            Load += FormReportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductovalioso).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private DataGridView dgvProductovalioso;
        private Label lblValiosos;
        private TextBox textBox1;
        private Label lblStock;
        private Label lblProductosValiosos;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button button4;
        private DataGridView dataGridView1;
    }
}