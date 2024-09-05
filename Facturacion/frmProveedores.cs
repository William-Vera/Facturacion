using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Facturacion
{
    public partial class frmProveedores : Form
    {
        csProveedores objprove = new csProveedores();
        string nombre, direccion, telefono, correo;
        int id_proveedor;
        public frmProveedores()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder3D(e.Graphics, tableLayoutPanel1.ClientRectangle, Border3DStyle.Sunken);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder3D(e.Graphics, tableLayoutPanel2.ClientRectangle, Border3DStyle.Sunken);
        }

        private void tableLayoutPanel5_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder3D(e.Graphics, tableLayoutPanel5.ClientRectangle, Border3DStyle.Sunken);
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder3D(e.Graphics, tableLayoutPanel6.ClientRectangle, Border3DStyle.Sunken);
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder3D(e.Graphics, tableLayoutPanel3.ClientRectangle, Border3DStyle.Sunken);
        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder3D(e.Graphics, tableLayoutPanel4.ClientRectangle, Border3DStyle.Sunken);
        }

        private void txtBuscarEliminar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                objprove.buscar_proveedor(cbxEliminar.SelectedItem.ToString(), txtBuscarEliminar.Text, dgvEliminar);
            }
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                objprove.buscar_proveedor(comboBox1.SelectedItem.ToString(), txtBuscarProducto.Text, dgvAgregarProve);
            }
        }

        private void btnBuscarAgg_Click(object sender, EventArgs e)
        {
            objprove.buscar_proveedor(comboBox1.SelectedItem.ToString(), txtBuscarProducto.Text, dgvAgregarProve);
        }

        private void txtBuscarEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                objprove.buscar_proveedor(cbxEditar.SelectedItem.ToString(), txtBuscarEditar.Text, dgvEditar);
            }
        }

        private void btnBuscarEditar_Click(object sender, EventArgs e)
        {
            objprove.buscar_proveedor(cbxEditar.SelectedItem.ToString(), txtBuscarEditar.Text, dgvEditar);
        }

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
        {
            objprove.buscar_proveedor(cbxEliminar.SelectedItem.ToString(), txtBuscarEliminar.Text, dgvEliminar);
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            borrarrows(dgvEliminar);
            borrarrows(dgvEditar);
            borrarrows(dgvAgregarProve);
            limpiar_txt();
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

        private void btnLimpiarAgg_Click(object sender, EventArgs e)
        {
            limpiar_txt();
            borrarrows(dgvAgregarProve);
        }

        public void limpiar_txt()
        {
            txtBuscarEditar.Text = string.Empty;
            txtBuscarEliminar.Text = string.Empty;
            txtBuscarProducto.Text = string.Empty;
            txtCorreoAgg.Text = string.Empty;
            txtCorreoEditar.Text = string.Empty;
            txtCorreoEliminar.Text = string.Empty;
            txtDirAgg.Text = string.Empty;
            txtDirEditar.Text = string.Empty;
            txtDirEliminar.Text = string.Empty;
            txtNomProAgg.Text = string.Empty;
            txtNombreEditar.Text = string.Empty;
            txtNombreEliminar.Text = string.Empty;
            txtTelefinoAgg.Text = string.Empty;
            txtTelEditar.Text = string.Empty;
            txtTelEliminar.Text = string.Empty;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            id_proveedor = 0;
        }

        private void btnLimpiarEditar_Click(object sender, EventArgs e)
        {
            limpiar_txt();
            borrarrows(dgvEditar);
        }

        private void btnLimpiarEliminar_Click(object sender, EventArgs e)
        {
            limpiar_txt();
            borrarrows(dgvEliminar);
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            cbxEditar.SelectedIndex = 0;
            cbxEliminar.SelectedIndex = 0;
        }

        private void txtNomProAgg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtDirAgg.Focus();
            }
        }

        private void txtDirAgg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtTelefinoAgg.Focus();
            }
        }

        private void txtTelefinoAgg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                txtCorreoAgg.Focus();
            }
        }

        private void txtCorreoAgg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                btnAgregar.PerformClick();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNomProAgg.Text) ||
                string.IsNullOrEmpty(txtDirAgg.Text) || string.IsNullOrEmpty(txtTelefinoAgg.Text) || string.IsNullOrEmpty(txtCorreoAgg.Text))
                MessageBox.Show("Debe Completar todos los campos");
            else
            {
                try
                {
                    if (EsCorreoValido(txtCorreoAgg.Text))
                    {
                        objprove.ingresar_proveedores(txtNomProAgg.Text, txtDirAgg.Text, txtTelefinoAgg.Text, txtCorreoAgg.Text);
                        MessageBox.Show("Se Ha Agregado con Exito a:" + txtNomProAgg.Text);
                        limpiar_txt();
                        //dataGridView1 = objcli.listar_clientes(dataGridView1);
                        borrarrows(dgvAgregarProve);
                    }
                    else
                        MessageBox.Show("Correo no válido. Por favor, ingrese un correo electrónico correcto.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ya Existe un Proveedor registrado con ese Nombre" + ex);
                }
            }
        }

        public bool EsCorreoValido(string email)
        {
            string patronCorreo = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronCorreo);
        }

        private void dgvEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    nombre = dgvEditar.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                    direccion = dgvEditar.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString();
                    telefono = dgvEditar.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString();
                    correo = dgvEditar.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString();
                    id_proveedor = int.Parse(dgvEditar.Rows[e.RowIndex].Cells["PROVEDOR_ID"].Value.ToString());
                    txtNombreEditar.Text = nombre;
                    txtDirEditar.Text = direccion;
                    txtTelEditar.Text = telefono;
                    txtCorreoEditar.Text = correo;
                    btnEditar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (e.RowIndex >= 0)
                {
                    nombre = dgvEliminar.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                    direccion = dgvEliminar.Rows[e.RowIndex].Cells["DIRECCION"].Value.ToString();
                    telefono = dgvEliminar.Rows[e.RowIndex].Cells["TELEFONO"].Value.ToString();
                    correo = dgvEliminar.Rows[e.RowIndex].Cells["EMAIL"].Value.ToString();
                    txtNombreEliminar.Text = nombre;
                    txtDirEliminar.Text = direccion;
                    txtTelEliminar.Text = telefono;
                    id_proveedor = int.Parse(dgvEliminar.Rows[e.RowIndex].Cells["PROVEDOR_ID"].Value.ToString());
                    txtCorreoEliminar.Text = correo;
                    btnEliminar.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objprove.eliminar_proveedor(id_proveedor);
                MessageBox.Show("Se Ha Eliminado con Exito a: " + txtNombreEliminar.Text);
                //dgvEliminar = objcli.listar_clientes(dgvEliminar);
                limpiar_txt();
                borrarrows(dgvEliminar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNombreEditar.Text) || string.IsNullOrEmpty(txtDirEditar.Text) || string.IsNullOrEmpty(txtTelEditar.Text)
                || string.IsNullOrEmpty(txtCorreoEditar.Text))
                MessageBox.Show("Debe Completar todos los campos");
            else
            {
                try
                {
                    if (EsCorreoValido(txtCorreoEditar.Text))
                    {
                        objprove.editar_proveedor(id_proveedor, txtNombreEditar.Text, txtDirEditar.Text, txtTelEditar.Text, txtCorreoEditar.Text);
                        MessageBox.Show("Se Ha Editado con Exito a: " + txtNombreEditar.Text);
                        //dgvEditar = objcli.listar_clientes(dgvEditar);
                        limpiar_txt();
                        borrarrows(dgvEditar);
                    }
                    else
                        MessageBox.Show("Correo no válido. Por favor, ingrese un correo electrónico correcto.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex + "");
                }
            }
        }

        private void txtTelEditar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
