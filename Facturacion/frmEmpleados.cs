using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Facturacion
{
    public partial class frmEmpleados : Form
    {
        int id_empleado;
        string Nombres;
        string Apellidos;
        string Cedula, rol, usuario;
        bool estado;
        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private TabPage hiddenTabPage;
        private void HideTab(TabControl tabControl, TabPage tabPage)
        {
            if (tabControl.TabPages.Contains(tabPage))
            {
                hiddenTabPage = tabPage;
                tabControl.TabPages.Remove(tabPage);
            }
        }
        private void btnEditarPass_Click(object sender, EventArgs e)
        {
            if (dgvEditar.CurrentCell != null)
            {
                using (frmEditarContrasenia frmeditcontre = new frmEditarContrasenia())
                {
                    frmeditcontre.ShowDialog();

                }
            }
            else
                MessageBox.Show("Seleccione primero a un empleado");
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            csEmpleado empleado = new csEmpleado();
            empleado.CargarRolesEnComboBox(comboBox5, "spListarRoles");
            HideTab(tabControl1, tabPage3);
            comboBox1.SelectedIndex = 0;
            comboBox4.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            csEmpleado empleado = new csEmpleado();
            int estado = (comboBox4.Text == "Activado") ? 1 : 0;

            if (string.IsNullOrWhiteSpace(txtcedula.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtContrasenia.Text) || string.IsNullOrWhiteSpace(comboBox4.Text)
                || txtcedula.Text.Length<10)
            {
                MessageBox.Show("RELLENE TODOS LOS CAMPOS NECESARIOS POR FAVOR :(");
                return;
            }

            try
            {
                empleado.ingresar_empleado(txtNombres.Text, txtApellidos.Text, txtcedula.Text, (int)comboBox5.SelectedValue, txtUser.Text, txtContrasenia.Text, estado);
                MessageBox.Show("Se ha agregado con éxito a: " + txtNombres.Text + " " + txtApellidos.Text);
                limpiar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error inesperado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCargarDtg_Click(object sender, EventArgs e)
        {
            csEmpleado empleado = new csEmpleado();
            empleado.listar_dtg(dgvEditar, "spListarEmpleados");
        }

        private void dgvEditar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            csEmpleado objemp = new csEmpleado();
            objemp.CargarRolesEnComboBox(cbxRolEditar, "spListarRoles");
            try
            {
                cbxEstadoEditar.Items.Clear();
                if (e.RowIndex >= 0)
                {
                    rol = dgvEditar.Rows[e.RowIndex].Cells["ROL"].Value.ToString();
                    usuario = dgvEditar.Rows[e.RowIndex].Cells["USUARIO"].Value.ToString();
                    Nombres = dgvEditar.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                    Cedula = dgvEditar.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
                    Apellidos = dgvEditar.Rows[e.RowIndex].Cells["APELLIDO"].Value.ToString();
                    estado = bool.Parse(dgvEditar.Rows[e.RowIndex].Cells["ESTADO"].Value.ToString());
                    string idcell = dgvEditar.Rows[e.RowIndex].Cells["EMPLEADOID"].Value.ToString();

                    id_empleado = int.Parse(idcell);
                    CsSesionActiva.NombresEmpleadoEditarID = Nombres + " " + Apellidos;
                    CsSesionActiva.EmpleadoEditarID = id_empleado;
                    int rolID = 0;


                    if (dgvEditar.Columns["ROLID"] != null)
                    {
                        int.TryParse(dgvEditar.Rows[e.RowIndex].Cells["ROLID"].Value?.ToString(), out rolID);
                    }

                    txtNombreEditar.Text = Nombres;
                    txtCedulaEditar.Text = Cedula;
                    txtApellidoEditar.Text = Apellidos;
                    id_empleado = int.Parse(idcell);
                    txtUserEditar.Text = usuario;
                    //cbxRolEditar.Text = rol;
                    cbxRolEditar.SelectedValue = rolID;

                    cbxEstadoEditar.Items.Add("Activado");
                    cbxEstadoEditar.Items.Add("Desactivado");
                    if (estado)
                        cbxEstadoEditar.Text = "Activado";
                    else
                        cbxEstadoEditar.Text = "Desactivado";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            csEmpleado empleado = new csEmpleado();
            int estado = cbxEstadoEditar.Text == "Activado" ? 1 : 0;

            if (!string.IsNullOrWhiteSpace(txtCedulaEditar.Text) &&
                !string.IsNullOrWhiteSpace(txtNombreEditar.Text) &&
                !string.IsNullOrWhiteSpace(txtApellidoEditar.Text) &&
                !string.IsNullOrWhiteSpace(txtUserEditar.Text) &&
                !string.IsNullOrWhiteSpace(cbxEstadoEditar.Text)
                && txtCedulaEditar.Text.Length == 10)
            {
                try
                {
                    empleado.editar_empleado(id_empleado,
                                             txtNombreEditar.Text,
                                             txtApellidoEditar.Text,
                                             txtCedulaEditar.Text,
                                             (int)cbxRolEditar.SelectedValue,
                                             txtUserEditar.Text,
                                             estado);
                    MessageBox.Show("Se ha editado con éxito a: " + txtNombreEditar.Text + " " + txtApellidoEditar.Text);
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al editar empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("RELLENE TODOS LOS CAMPOS NECESARIOS POR FAVOR :(");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarEnBaseDatos(dgvAgregar, textBox1, comboBox1);
        }

        private void BuscarEnBaseDatos(DataGridView dgv, System.Windows.Forms.TextBox txt, System.Windows.Forms.ComboBox cbx)
        {
            csEmpleado objemple = new csEmpleado();
            string campo = cbx.SelectedItem.ToString();
            string valor = txt.Text;
            objemple.buscar_empleado(cbx.Text, txt.Text, dgv);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarEnBaseDatos(dgvAgregar, textBox1, comboBox1);
            }
        }

        private void btnBuscarEditar_Click(object sender, EventArgs e)
        {
            BuscarEnBaseDatos(dgvEditar, txtBuscarEditar, comboBox2);
        }

        private void txtBuscarEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarEnBaseDatos(dgvEditar, txtBuscarEditar, comboBox2);
            }
        }

        private void dgvEditar_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        public void limpiar()
        {
            txtApellidos.Text = string.Empty;
            txtNombres.Text = string.Empty;
            txtcedula.Text = string.Empty;
            txtContrasenia.Text = string.Empty;
            txtUser.Text = string.Empty;
            textBox1.Text = string.Empty;
            comboBox4.Text = string.Empty;
            comboBox5.Text = string.Empty;
            dgvAgregar.DataSource = null;
            txtNombreEditar.Text = string.Empty;
            txtApellidoEditar.Text = string.Empty;
            txtCedulaEditar.Text = string.Empty;
            txtUserEditar.Text = string.Empty;
            txtBuscarEditar.Text = string.Empty;
            cbxRolEditar.Text = string.Empty;
            cbxEstadoEditar.Text = string.Empty;
            dgvEditar.DataSource = null;
            dgvEliminar.DataSource = null;
        }

        private void btnLimpiarEditar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtcedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCedulaEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
