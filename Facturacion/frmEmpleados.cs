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
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            csEmpleado empleado = new csEmpleado();
            int estado = (comboBox4.Text == "Activado") ? 1 : 0;

            if (string.IsNullOrWhiteSpace(txtcedula.Text) || string.IsNullOrWhiteSpace(txtNombres.Text) ||
                string.IsNullOrWhiteSpace(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtUser.Text) ||
                string.IsNullOrWhiteSpace(txtContrasenia.Text) || string.IsNullOrWhiteSpace(comboBox4.Text))
            {
                MessageBox.Show("RELLENE TODOS LOS CAMPOS NECESARIOS POR FAVOR :(");
                return;
            }

            try
            {
                empleado.ingresar_empleado(txtNombres.Text, txtApellidos.Text, txtcedula.Text, (int)comboBox5.SelectedValue, txtUser.Text, txtContrasenia.Text, estado);
                MessageBox.Show("Se ha agregado con éxito a: " + txtNombres.Text + " " + txtApellidos.Text);
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
            csEmpleado empleado = new csEmpleado();
            empleado.CargarRolesEnComboBox(cbxRolEditar, "spListarRoles");
            cbxEstadoEditar.Items.Clear();
            if (e.RowIndex < 0) return;

            try
            {
                string nombre = dgvEditar.Rows[e.RowIndex].Cells["NOMBRE"].Value?.ToString() ?? "";
                string apellido = dgvEditar.Rows[e.RowIndex].Cells["APELLIDO"].Value?.ToString() ?? "";
                string cedula = dgvEditar.Rows[e.RowIndex].Cells["CEDULA"].Value?.ToString() ?? "";
                string rol = dgvEditar.Rows[e.RowIndex].Cells["ROL"].Value?.ToString() ?? "";
                string usuario = dgvEditar.Rows[e.RowIndex].Cells["USUARIO"].Value?.ToString() ?? "";
                bool estado = Convert.ToBoolean(dgvEditar.Rows[e.RowIndex].Cells["ESTADO"].Value);

                int empleadoID = 0;
                int rolID = 0;

                if (dgvEditar.Columns["EMPLEADOID"] != null)
                {
                    int.TryParse(dgvEditar.Rows[e.RowIndex].Cells["EMPLEADOID"].Value?.ToString(), out empleadoID);
                }

                if (dgvEditar.Columns["ROLID"] != null)
                {
                    int.TryParse(dgvEditar.Rows[e.RowIndex].Cells["ROLID"].Value?.ToString(), out rolID);
                }

                txtNombreEditar.Text = nombre;
                txtApellidoEditar.Text = apellido;
                txtCedulaEditar.Text = cedula;
                txtUserEditar.Text = usuario;

                cbxRolEditar.SelectedValue = rolID;
                cbxEstadoEditar.Items.Add("Activado");
                cbxEstadoEditar.Items.Add("Desactivado");
                if (estado)
                    cbxEstadoEditar.Text = "Activado";
                else
                    cbxEstadoEditar.Text = "Desactivado";


                CsSesionActiva.EmpleadoEditarID = empleadoID;
                CsSesionActiva.NombresEmpleadoEditarID = nombre + " " + apellido;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                !string.IsNullOrWhiteSpace(cbxEstadoEditar.Text))
            {
                try
                {
                    empleado.editar_empleado(CsSesionActiva.EmpleadoEditarID,
                                             txtNombreEditar.Text,
                                             txtApellidoEditar.Text,
                                             txtCedulaEditar.Text,
                                             (int)cbxRolEditar.SelectedValue,
                                             txtUserEditar.Text,
                                             estado);
                    MessageBox.Show("Se ha editado con éxito a: " + txtNombreEditar.Text + " " + txtApellidoEditar.Text);
                    dgvEditar.DataSource = null;
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

        }
    }
}
