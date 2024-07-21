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

namespace Facturacion
{
    public partial class frmAgregarClientes : Form
    {
        int id_cliente;
        string Nombres;
        string Apellidos;
        string Cedula;
        csClientes objcli = new csClientes();
        public frmAgregarClientes()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Eliminar_Cliente_Load(object sender, EventArgs e)
        {
            //dsClientesTableAdapters.spListarClientesTableAdapter da = new dsClientesTableAdapters.spListarClientesTableAdapter();
            //dsClientes ds = new dsClientes();
            //da.Fill(ds.spListarClientes);
            //dataGridView1.DataSource = ds.spListarClientes;
            //dataGridView1 = objcli.listar_clientes(dataGridView1);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        public void limpiar_txt()
        {
            txtApellido.Text = string.Empty;
            txtCedula.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtBuscar.Text = string.Empty;
            txtNombresEditar.Text = string.Empty;
            txtBuscarEditar.Text = string.Empty;
            txtApellidosEditar.Text = string.Empty;
            txtCedulaEditar.Text = string.Empty;
            txtCedulaEliminar.Text = string.Empty;
            txtNombreEliminar.Text = string.Empty;
            txtApellidoEliminar.Text = string.Empty;
            txtBuscarEliminar.Text = string.Empty;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar_txt();
            borrarrows(dataGridView1);
        }
        public void borrarrows(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
                //while (dgv.Rows.Count > 0)
                //{
                //    dgv.Rows.RemoveAt(0);
                //}
                //dataGridView1.Rows.Clear();  // Elimina todas las filas del DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar las filas del DataGridView: " + ex.Message);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtCedula.Text) || string.IsNullOrEmpty(txtNombre.Text))
                MessageBox.Show("Debe Completar todos los campos");
            else
            {
                try
                {
                    objcli.ingresar_cliente(txtCedula.Text, txtNombre.Text, txtApellido.Text);
                    MessageBox.Show("Se Ha Agregado con Exito a:" + txtApellido.Text + " " + txtNombre.Text);
                    limpiar_txt();
                    //dataGridView1 = objcli.listar_clientes(dataGridView1);
                    borrarrows(dataGridView1);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ya Existe un Cliente registrado con ese Numero de Cedula" + ex);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.Trim();

            // Filtrar los datos del DataGridView
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombres LIKE '%{0}%' OR Apellidos LIKE '%{0}%' OR Cedula LIKE '%{0}%'", busqueda);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //dgvEditar = objcli.listar_clientes(dgvEditar);
            //dgvEliminar = objcli.listar_clientes(dgvEliminar);
            id_cliente = 0;
            borrarrows(dgvEliminar);
            borrarrows(dgvEditar);
            borrarrows(dataGridView1);
            limpiar_txt();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    Nombres = dgvEditar.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString();
                    Cedula = dgvEditar.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
                    Apellidos = dgvEditar.Rows[e.RowIndex].Cells["APELLIDOS"].Value.ToString();
                    string idcell = dgvEditar.Rows[e.RowIndex].Cells["IDCLIENTE"].Value.ToString();
                    txtNombresEditar.Text = Nombres;
                    txtCedulaEditar.Text = Cedula;
                    txtApellidosEditar.Text = Apellidos;
                    id_cliente = int.Parse(idcell);
                }
            }
            catch (Exception ex) { }
        }

        private void txtBuscarEditar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarEditar.Text.Trim();

            // Filtrar los datos del DataGridView
            (dgvEditar.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombres LIKE '%{0}%' OR Apellidos LIKE '%{0}%' OR Cedula LIKE '%{0}%'", busqueda);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                objcli.editar_cliente(txtCedulaEditar.Text, txtNombresEditar.Text, txtApellidosEditar.Text, id_cliente);
                MessageBox.Show("Se Ha Editado con Exito a:" + txtApellidosEditar.Text + " " + txtNombresEditar.Text);
                //dgvEditar = objcli.listar_clientes(dgvEditar);
                limpiar_txt();
                borrarrows(dgvEditar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnLimpiarEditar_Click(object sender, EventArgs e)
        {
            limpiar_txt();
            borrarrows(dgvEditar);
        }

        private void txtBuscarEliminar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarEliminar.Text.Trim();

            // Filtrar los datos del DataGridView
            (dgvEliminar.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nombres LIKE '%{0}%' OR Apellidos LIKE '%{0}%' OR Cedula LIKE '%{0}%'", busqueda);
        }

        private void dgvEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Nombres = dgvEliminar.Rows[e.RowIndex].Cells["NOMBRES"].Value.ToString();
                    Cedula = dgvEliminar.Rows[e.RowIndex].Cells["CEDULA"].Value.ToString();
                    Apellidos = dgvEliminar.Rows[e.RowIndex].Cells["APELLIDOS"].Value.ToString();
                    string idcell = dgvEliminar.Rows[e.RowIndex].Cells["IDCLIENTE"].Value.ToString();
                    txtNombreEliminar.Text = Nombres;
                    txtCedulaEliminar.Text = Cedula;
                    txtApellidoEliminar.Text = Apellidos;
                    id_cliente = int.Parse(idcell);
                }
            }
            catch (Exception ex) { }
        }

        private void btnLimpiarEliminar_Click(object sender, EventArgs e)
        {
            limpiar_txt();
            borrarrows(dgvEliminar);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objcli.eliminar_cliente(id_cliente);
                MessageBox.Show("Se Ha Eliminado con Exito a:" + txtApellidoEliminar.Text + " " + txtNombreEliminar.Text);
                //dgvEliminar = objcli.listar_clientes(dgvEliminar);
                limpiar_txt();
                borrarrows(dgvEliminar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void txtCedulaEditar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtBuscarEliminar_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void BuscarEnBaseDatos(DataGridView dgv, TextBox txt, ComboBox cbx)
        {
            string campo = cbx.SelectedItem.ToString();
            string valor = txt.Text;

            objcli.buscar_cliente(campo, valor, dgv);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarEnBaseDatos(dataGridView1, txtBuscar, comboBox1);
            }
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            BuscarEnBaseDatos(dataGridView1, txtBuscar, comboBox1);
        }

        private void bntBuscar_Click(object sender, EventArgs e)
        {
            BuscarEnBaseDatos(dgvEditar, txtBuscarEditar, comboBox2);
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBuscarEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarEnBaseDatos(dgvEditar, txtBuscarEditar, comboBox2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BuscarEnBaseDatos(dgvEliminar, txtBuscarEliminar, comboBox3);
        }

        private void txtBuscarEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarEnBaseDatos(dgvEliminar, txtBuscarEliminar, comboBox3);
            }
        }
    }
}
