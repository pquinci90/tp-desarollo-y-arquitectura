using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Venta_Entradas
{
    public partial class UcMisEntradas : UserControl
    {
        TicketBusiness ticketBusiness = new TicketBusiness();
        FacturaBusiness facturaBusiness = new FacturaBusiness();
        public UcMisEntradas()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int idSeleccionado = (int)comboBox1.SelectedValue;
                string usernameDestino = textBox1.Text;
                ticketBusiness.EnviarTicket(SesionManageUtil.UsuarioActual, idSeleccionado, usernameDestino);
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void refresh()
        {

            string username = SesionManageUtil.UsuarioActual.Usuario;
            var tickets = ticketBusiness.ListarTicketsByUsername(username);
            var facturas = facturaBusiness.ListarFacturasByUsername(username);
            var listaParaGrilla = tickets
             .Select(t => new
             {
                 Usuario = t.Usuario.Usuario, // username
                 Id = t.Id,               // id del ticket
                 Evento = t.Evento.Nombre     // nombre del evento
             })
             .ToList();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaParaGrilla;

            dataGridView2.DataSource = null;
            dataGridView2.DataSource = facturas;
            dataGridView2.Columns["Id"].Visible = false;
            dataGridView2.Columns["Aprobado"].Visible = false;
            dataGridView2.Columns["Usuario"].Visible = false;

            var datosCombo = tickets
                .Select(t => new
                {
                    Id = t.Id,
                    Texto = t.Evento.Nombre
                })
                .ToList();

            comboBox1.DataSource = datosCombo;
            comboBox1.DisplayMember = "Id";
            comboBox1.ValueMember = "Id";


        }

        private void button2_Click(object sender, EventArgs e)
        {
            refresh();
        }



        //private void Refresh()
        //{
        //    var eventos = eventoBusiness.ListarEventos();

        //    dataGridView1.DataSource = null;
        //    dataGridView1.DataSource = eventos;
        //    dataGridView1.Columns["Id"].Visible = false;


        //    comboBox1.DataSource = eventos;
        //    comboBox1.DisplayMember = "Nombre";
        //    //comboBox1.ValueMember = "Id";
        //    listBox1.DataSource = null;
        //    listBox1.DataSource = SesionManageUtil.Carrito;
        //    listBox1.DisplayMember = "Nombre";

        //}
    }
}
