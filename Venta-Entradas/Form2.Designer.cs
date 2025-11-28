namespace Venta_Entradas
{
    partial class Form2
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
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            panelContenido = new Panel();
            SuspendLayout();
            // 
            // button2
            // 
            button2.Location = new Point(12, 53);
            button2.Name = "button2";
            button2.Size = new Size(190, 69);
            button2.TabIndex = 2;
            button2.Text = "Ver Recitales";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(12, 128);
            button3.Name = "button3";
            button3.Size = new Size(190, 69);
            button3.TabIndex = 3;
            button3.Text = "Mis Entradas";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(12, 203);
            button4.Name = "button4";
            button4.Size = new Size(190, 69);
            button4.TabIndex = 4;
            button4.Text = "Administrador";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(12, 278);
            button5.Name = "button5";
            button5.Size = new Size(190, 69);
            button5.TabIndex = 6;
            button5.Text = "Cerrar Sesion";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // panelContenido
            // 
            panelContenido.Dock = DockStyle.Right;
            panelContenido.Location = new Point(208, 0);
            panelContenido.Name = "panelContenido";
            panelContenido.Size = new Size(1020, 367);
            panelContenido.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1228, 367);
            Controls.Add(panelContenido);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
        }

        #endregion
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Panel panelContenido;
    }
}