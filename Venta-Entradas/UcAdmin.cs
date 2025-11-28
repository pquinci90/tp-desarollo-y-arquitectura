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
using Entity;

namespace Venta_Entradas
{
    public partial class UcAdmin : UserControl
    {
        EventoBusiness eventoBusiness = new EventoBusiness();

        public UcAdmin()
        {
            InitializeComponent();
            refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var evento = new EventoEntity
                {
                    Nombre = textBox1.Text,
                    Descripcion = textBox2.Text,
                    Id = int.Parse(numericUpDown5.Text),
                    Precio = (double)numericUpDown1.Value,
                    Cantidad = int.Parse(numericUpDown2.Text)
                };
                bool exito = eventoBusiness.ActualizarEvento(evento);
                if (exito) MessageBox.Show("Actualizado con exito");
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void refresh()
        {
            var eventos = eventoBusiness.ListarEventos();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = eventos;

            //comboBox1.DataSource = null;
            //comboBox1.DataSource = eventos;
            //comboBox1.DisplayMember = "Id";
            //comboBox1.ValueMember = "Id";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var evento = new EventoEntity
                {
                    Nombre = textBox4.Text,
                    Descripcion = textBox5.Text,
                    Precio = (double)numericUpDown3.Value,
                    Cantidad = int.Parse(numericUpDown4.Text)
                };
                bool exito = eventoBusiness.CrearEvento(evento);
                if (exito) MessageBox.Show("Creado con exito");
                refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //private void button3_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        int idSeleccionado = (int)comboBox1.SelectedValue;
        //        bool exito = eventoBusiness.DeleteById(idSeleccionado);
        //        if (exito) MessageBox.Show("Creado con exito");
        //        refresh();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}
    }
}
