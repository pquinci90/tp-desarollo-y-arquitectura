using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;

namespace Venta_Entradas
{
    public partial class Form2 : Form
    {
        private readonly UcRecitales _ucRecitales = new UcRecitales();
        private readonly UcMisEntradas _ucMisEntradas = new UcMisEntradas();
        private readonly UcAdmin _ucAdmin = new UcAdmin();

        private bool _cerrandoPorLogout = false;

        public Form2()
        {
            InitializeComponent();
            this.FormClosed += Form2_FormClosed;   // manejador explícito
            MostrarControl(_ucRecitales);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!_cerrandoPorLogout)
            {
                // Si se cerró la ventana sin logout (X), cierro la app
                Application.Exit();
            }
        }

        private void MostrarControl(UserControl control)
        {
            panelContenido.Controls.Clear();
            control.Dock = DockStyle.Fill;
            panelContenido.Controls.Add(control);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MostrarControl(_ucRecitales);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MostrarControl(_ucMisEntradas);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!SesionManageUtil.EsAdmin())
            {
                MessageBox.Show("No tienes permisos para acceder a esta sección.");
                return;
            }
            MostrarControl(_ucAdmin);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Cerrar sesión
            SesionManageUtil.CerrarSesion();   // o el método que tengas
            SesionManageUtil.Carrito.Clear();   // o el método que tengas


            _cerrandoPorLogout = true;

            // Volver al Form1 (login)
            var formLogin = new Form1();
            formLogin.Show();

            // Cierro Form2
            this.Close();
        }
    }

}
