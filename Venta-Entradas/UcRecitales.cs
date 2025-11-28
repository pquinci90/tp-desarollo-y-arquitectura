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
using Entity;

namespace Venta_Entradas
{
    public partial class UcRecitales : UserControl
    {
        EventoBusiness eventoBusiness = new EventoBusiness();
        FacturaBusiness facturaBusiness = new FacturaBusiness();
        public List<string> formasPago = new List<string>
            {
                "Efectivo",
                "Tarjeta Débito",
                "Tarjeta Crédito en cuotas",
                "Transferencia"
            };
        public UcRecitales()
        {
            InitializeComponent();
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SesionManageUtil.Carrito.Add(comboBox1.SelectedValue as EventoEntity);
            Refresh();
        }
        private void Refresh()
        {
            
            var eventos = eventoBusiness.ListarEventos();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = eventos;
            dataGridView1.Columns["Id"].Visible = false;


            comboBox1.DataSource = eventos;
            comboBox1.DisplayMember = "Nombre";

            comboBox2.DataSource = null;
            comboBox2.DataSource = SesionManageUtil.Carrito;
            comboBox2.DisplayMember = "Nombre";

            //comboBox1.ValueMember = "Id";
            listBox1.DataSource = null;
            listBox1.DataSource = SesionManageUtil.Carrito;
            listBox1.DisplayMember = "Nombre";

            comboBox3.DataSource = null;
            comboBox3.DataSource = formasPago;


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var seleccionado = comboBox2.SelectedItem as EventoEntity;
                if (seleccionado == null) return;

                SesionManageUtil.Carrito.Remove(seleccionado);
                Refresh();
                //if (SesionManageUtil.Carrito.Count < 1) throw new Exception("Debes agregar items al carrito");
                //facturaBusiness.CrearFactura(SesionManageUtil.Carrito, SesionManageUtil.UsuarioActual, "Efectivo");
                //MessageBox.Show("a");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var formaPago = comboBox3.SelectedItem as string;
                if (SesionManageUtil.Carrito.Count < 1) throw new Exception("Debes agregar items al carrito");
                bool exito = facturaBusiness.CrearFactura(SesionManageUtil.Carrito, SesionManageUtil.UsuarioActual, formaPago);
                if (exito) MessageBox.Show("Compra realizada con exito");
                SesionManageUtil.Carrito.Clear();
                Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    
}
