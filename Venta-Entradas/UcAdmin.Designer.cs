namespace Venta_Entradas
{
    partial class UcAdmin
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            groupBox1 = new GroupBox();
            numericUpDown5 = new NumericUpDown();
            numericUpDown2 = new NumericUpDown();
            numericUpDown1 = new NumericUpDown();
            groupBox2 = new GroupBox();
            numericUpDown4 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label6 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            textBox5 = new TextBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 260);
            button1.Name = "button1";
            button1.Size = new Size(139, 35);
            button1.TabIndex = 0;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(6, 7);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(568, 357);
            dataGridView1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(27, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(139, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(27, 99);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 125);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 7;
            label1.Text = "Id (No actualizable)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 37);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 8;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 169);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 9;
            label3.Text = "Precio";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 213);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 10;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 81);
            label5.Name = "label5";
            label5.Size = new Size(69, 15);
            label5.TabIndex = 11;
            label5.Text = "Descripcion";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numericUpDown5);
            groupBox1.Controls.Add(numericUpDown2);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Location = new Point(580, 7);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(196, 327);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Actualizar";
            // 
            // numericUpDown5
            // 
            numericUpDown5.Location = new Point(27, 144);
            numericUpDown5.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown5.Name = "numericUpDown5";
            numericUpDown5.Size = new Size(139, 23);
            numericUpDown5.TabIndex = 14;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown2.Location = new Point(27, 231);
            numericUpDown2.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(139, 23);
            numericUpDown2.TabIndex = 13;
            // 
            // numericUpDown1
            // 
            numericUpDown1.DecimalPlaces = 2;
            numericUpDown1.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown1.Location = new Point(27, 187);
            numericUpDown1.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(139, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(numericUpDown4);
            groupBox2.Controls.Add(numericUpDown3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(button2);
            groupBox2.Location = new Point(798, 44);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(196, 244);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Crear";
            // 
            // numericUpDown4
            // 
            numericUpDown4.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown4.Location = new Point(27, 170);
            numericUpDown4.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown4.Name = "numericUpDown4";
            numericUpDown4.Size = new Size(139, 23);
            numericUpDown4.TabIndex = 15;
            // 
            // numericUpDown3
            // 
            numericUpDown3.DecimalPlaces = 2;
            numericUpDown3.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            numericUpDown3.Location = new Point(27, 126);
            numericUpDown3.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(139, 23);
            numericUpDown3.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 64);
            label6.Name = "label6";
            label6.Size = new Size(69, 15);
            label6.TabIndex = 11;
            label6.Text = "Descripcion";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(27, 38);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 23);
            textBox4.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 152);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 10;
            label7.Text = "Cantidad";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(27, 108);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 9;
            label8.Text = "Precio";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(27, 20);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 8;
            label9.Text = "Nombre";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(27, 82);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 23);
            textBox5.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(27, 199);
            button2.Name = "button2";
            button2.Size = new Size(139, 35);
            button2.TabIndex = 0;
            button2.Text = "Crear";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // UcAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(dataGridView1);
            Name = "UcAdmin";
            Size = new Size(997, 374);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown5).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown4).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button button2;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown1;
        private NumericUpDown numericUpDown4;
        private NumericUpDown numericUpDown3;
        private NumericUpDown numericUpDown5;
    }
}
