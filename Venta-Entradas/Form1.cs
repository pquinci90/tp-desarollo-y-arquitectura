using BLL;
using Entity;
using Utils;

namespace Venta_Entradas
{
    public partial class Form1 : Form
    {
        Form2 f2 = new Form2();
        private UsuarioBusiness UsuarioBusiness = new();

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var user = textBox1.Text;
                var pass = textBox2.Text;
                var userLogin = UsuarioBusiness.Login(user, pass);

                if (userLogin != null)
                {
                    SesionManageUtil.IniciarSesion(userLogin);
                    CleanTextboxs();
                    MessageBox.Show("Sesion iniciada Correctamente");
                    f2.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var usuario = new UsuarioEntity
                {
                    Nombre = textBox3.Text,
                    Apellido = textBox4.Text,
                    Dni = int.Parse(textBox5.Text),
                    Usuario = textBox6.Text,
                    Contraseña = textBox7.Text,
                    Admin = false
                };
                UsuarioBusiness.CrearUsuario(usuario);
                MessageBox.Show("Usuario creado con exito");
                CleanTextboxs();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CleanTextboxs()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
        }
    }
}
