namespace Venta_Entradas
{
    partial class UcMisEntradas
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
            dataGridView1 = new DataGridView();
            textBox1 = new TextBox();
            button1 = new Button();
            comboBox1 = new ComboBox();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            groupBox1 = new GroupBox();
            dataGridView2 = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(95, 52);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(320, 255);
            dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 47);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(149, 23);
            textBox1.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(6, 161);
            button1.Name = "button1";
            button1.Size = new Size(149, 34);
            button1.TabIndex = 2;
            button1.Text = "Enviar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(6, 103);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(149, 23);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(14, 52);
            button2.Name = "button2";
            button2.Size = new Size(75, 255);
            button2.TabIndex = 4;
            button2.Text = "Cargar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 29);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 5;
            label1.Text = "Destinatario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 85);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 6;
            label2.Text = "Id del ticket";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(421, 52);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(166, 255);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Enviar ticket a otro usuario";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(593, 52);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(386, 255);
            dataGridView2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 34);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 9;
            label3.Text = "Mis Tickets";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(593, 34);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 10;
            label4.Text = "Mis Facturas";
            // 
            // UcMisEntradas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dataGridView2);
            Controls.Add(groupBox1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Name = "UcMisEntradas";
            Size = new Size(997, 374);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textBox1;
        private Button button1;
        private ComboBox comboBox1;
        private Button button2;
        private Label label1;
        private Label label2;
        private GroupBox groupBox1;
        private DataGridView dataGridView2;
        private Label label3;
        private Label label4;
    }
}
