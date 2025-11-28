namespace Venta_Entradas
{
    partial class UcRecitales
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
            listBox1 = new ListBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            label2 = new Label();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 43);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(479, 244);
            dataGridView1.TabIndex = 0;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(527, 43);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(158, 244);
            listBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(705, 72);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(186, 23);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(705, 101);
            button1.Name = "button1";
            button1.Size = new Size(186, 23);
            button1.TabIndex = 3;
            button1.Text = "Agregar al carrito";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(705, 181);
            button2.Name = "button2";
            button2.Size = new Size(186, 23);
            button2.TabIndex = 4;
            button2.Text = "Eliminar del carrito";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 25);
            label1.Name = "label1";
            label1.Size = new Size(112, 15);
            label1.TabIndex = 5;
            label1.Text = "Eventos Disponibles";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(527, 25);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Carrito";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(705, 152);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(186, 23);
            comboBox2.TabIndex = 7;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(705, 227);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(186, 23);
            comboBox3.TabIndex = 9;
            // 
            // button3
            // 
            button3.Location = new Point(705, 256);
            button3.Name = "button3";
            button3.Size = new Size(186, 23);
            button3.TabIndex = 8;
            button3.Text = "Comprar";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // UcRecitales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(comboBox3);
            Controls.Add(button3);
            Controls.Add(comboBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(listBox1);
            Controls.Add(dataGridView1);
            Name = "UcRecitales";
            Size = new Size(997, 374);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private ListBox listBox1;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private Button button3;
    }
}
