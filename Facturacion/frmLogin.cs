using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            csFactura emple = new csFactura();
            csVentas log = new csVentas();
            string usuario = textBox1.Text;
            string contrasena = textBox2.Text;

            // Encriptar la contraseña
            byte[] hashContrasena = emple.EncriptarContrasena(contrasena);

            // Validar el usuario
            bool esValido = log.ValidarUsuario(usuario, hashContrasena);

            if (esValido)
            {
                MessageBox.Show("Inicio de sesión exitoso.");
                //Form1 frmPrincipal = new Form1();
                //frmPrincipal.desactivaremp();
                //frmPrincipal.Refresh();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, Puede que su usuario se encuentre desabilitado.");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
