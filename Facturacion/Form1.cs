namespace Facturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //if(int.Parse(CsSesionActiva.Rol)==1)
            //    btnEmpleados.Enabled = false;
            //else
            //    btnEmpleados.Enabled = true;
            //desactivarbotones();
            //frmLogin frmLog = new frmLogin();
            //frmLog.MdiParent = this;
            //abrifrm(frmLog);
            desactivarbotones();
            panel2.BackColor = Color.FromArgb(100, 0, 0, 0);
            textBox3.Focus();
        }
        public void desactivaremp()
        {
            btnEmpleados.Enabled = false;
        }

        public void habilitarbotones()
        {
            btnEmpleados.Enabled = true;
            btn_clientes.Enabled = true;
            btn_productos.Enabled = true;
            btn_ventas.Enabled = true;
            btm_facturas.Enabled = true;

        }

        public void desactivarbotones()
        {
            btnEmpleados.Enabled = false;
            btn_clientes.Enabled = false;
            btn_productos.Enabled = false;
            btn_ventas.Enabled = false;
            btm_facturas.Enabled = false;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_cli_agregar_Click(object sender, EventArgs e)
        {
            frmProductos frmaggcli = new frmProductos();
            frmaggcli.MdiParent = this;
            abrifrm(frmaggcli);
            ocultar();
        }

        private Form frmactivo = null;

        private void abrifrm(Form frmprinci)
        {
            if (frmactivo != null) frmactivo.Close();
            frmactivo = frmprinci;
            panel_central.Controls.Add(frmprinci);
            panel_central.Tag = frmprinci;
            frmprinci.BringToFront();
            frmprinci.Dock = DockStyle.Fill;
            frmprinci.Show();
        }

        private void btn_clientes_Click(object sender, EventArgs e)
        {
            //panel_op_clientes.Visible = true;
            //panel_op_facturas.Visible = false;
            //panel_op_productos.Visible = false;
            //if (panel_op_clientes.Visible == false)
            //{
            //    panel_op_clientes.Visible = true;
            //}
            //else
            //    panel_op_clientes.Visible = false;

            frmAgregarClientes frmelicli = new frmAgregarClientes();
            frmelicli.MdiParent = this;
            abrifrm(frmelicli);
            ocultar();
        }

        private void btn_productos_Click(object sender, EventArgs e)
        {
            //panel_op_facturas.Visible = false;
            //panel_op_clientes.Visible = false;
            //if (panel_op_productos.Visible == false)
            //{
            //    panel_op_productos.Visible = true;
            //}
            //else
            //    panel_op_productos.Visible = false;
            frmProductos frmpro = new frmProductos();
            frmpro.MdiParent = this;
            abrifrm(frmpro);
            ocultar();
        }

        private void btm_facturas_Click(object sender, EventArgs e)
        {
            //panel_op_clientes.Visible = false;
            //panel_op_productos.Visible = false;
            //if (panel_op_facturas.Visible == false)
            //{
            //    panel_op_facturas.Visible = true;
            //}
            //else
            //    panel_op_facturas.Visible = false;
            frmFacturas frmfac = new frmFacturas();
            frmfac.MdiParent = this;
            abrifrm(frmfac);
            ocultar();
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            frmVentas frmvent = new frmVentas();
            frmvent.MdiParent = this;
            abrifrm(frmvent);
            ocultar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_cli_eliminar_Click(object sender, EventArgs e)
        {
            frmAgregarClientes frmelicli = new frmAgregarClientes();
            frmelicli.MdiParent = this;
            abrifrm(frmelicli);
            ocultar();
        }
        private void ocultar()
        {
            //panel_op_clientes.Visible = false;
            //panel_op_facturas.Visible = false;
            //panel_op_productos.Visible = false;
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            frmEmpleados frmemp = new frmEmpleados();
            frmemp.MdiParent = this;
            abrifrm(frmemp);
            ocultar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verificarusuario();
        }

        private void verificarusuario()
        {
            csFactura emple = new csFactura();
            csVentas log = new csVentas();
            string usuario = textBox3.Text;
            string contrasena = textBox4.Text;

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
                //this.Hide();
                habilitarbotones();
                panel2.Visible = false;
                panel_central.BackgroundImage = null;
                if (int.Parse(CsSesionActiva.Rol) == 1)
                    btnEmpleados.Visible = true;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos, Puede que su usuario se encuentre desabilitado.");
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                textBox4.Focus();
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                verificarusuario();
            }
        }
    }
}
