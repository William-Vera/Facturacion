using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Facturacion
{
    public partial class frmProductos : Form
    {
        csProductos objpro = new csProductos();
        string Nombre, Precio, proveedor;
        int id_pro;
        public frmProductos()
        {
            InitializeComponent();
        }

        private void frm_AgregarCleinte_Load(object sender, EventArgs e)
        {
            //dgvAggProductos = objpro.listar_productos(dgvAggProductos);
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            txtNombreProducto.Text = string.Empty;
            txtPrecioProducto.Text = string.Empty;
            txtBuscarProducto.Text = string.Empty;
            txtPrecioEdit.Text = string.Empty;
            txtNombreProEdi.Text = string.Empty;
            txtBuscarEditar.Text = string.Empty;
            txtPrecioeliminar.Text = string.Empty;
            txtNombreEliminar.Text = string.Empty;
            txtBuscarEliminar.Text = string.Empty;
            btnEditar.Enabled = false;
            btnEliminar.Enabled = false;
            comboBox4.Text = string.Empty;
            comboBox5.Text = string.Empty;
            comboBox6.Text = string.Empty;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
            if ((sender as TextBox).Text.IndexOf('.') == -1 && (sender as TextBox).Text.Length >= 10 && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if ((sender as TextBox).Text.IndexOf('.') > -1 && (sender as TextBox).Text.Substring((sender as TextBox).Text.IndexOf('.') + 1).Length >= 2 && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarProducto.Text.Trim();

            // Filtrar los datos del DataGridView
            (dgvAggProductos.DataSource as DataTable).DefaultView.RowFilter = string.Format("NOMBRE LIKE '%{0}%'", busqueda);
        }

        private void dgvAggProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            borrarrows(dgvAggProductos);
        }

        private void btnAggProductos_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreProducto.Text) || string.IsNullOrWhiteSpace(txtPrecioProducto.Text))
                {
                    MessageBox.Show("Asegurate de llenar todos los campos");
                }
                else
                {
                    int proveedor = int.Parse(comboBox4.SelectedValue.ToString());
                    objpro.ingresar_producto(txtNombreProducto.Text, decimal.Parse(txtPrecioProducto.Text, CultureInfo.InvariantCulture), proveedor); ;
                    //dgvAggProductos = objpro.listar_productos(dgvAggProductos);
                    MessageBox.Show("Se ha agregado con exito el producto: " + txtNombreProducto.Text);
                    limpiar();
                    borrarrows(dgvAggProductos);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            //dgvEditar = objpro.listar_productos(dgvEditar);
            //dgvEliminar = objpro.listar_productos(dgvEliminar);
            limpiar();
            borrarrows(dgvEditar);
            borrarrows(dgvAggProductos);
            borrarrows(dgvEliminar);
            id_pro = 0;
        }

        public void borrarrows(DataGridView dgv)
        {
            try
            {
                dgv.DataSource = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar las filas del DataGridView: " + ex.Message);
            }
        }

        private void txtBuscarEditar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarEditar.Text.Trim();

            // Filtrar los datos del DataGridView
            (dgvEditar.DataSource as DataTable).DefaultView.RowFilter = string.Format("NOMBRE LIKE '%{0}%'", busqueda);
        }

        private void dgvEditar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombreProEdi_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpiarEditar_Click(object sender, EventArgs e)
        {
            limpiar();
            borrarrows(dgvEditar);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                objpro.editar_productor(txtNombreProEdi.Text, decimal.Parse(txtPrecioEdit.Text, CultureInfo.InvariantCulture), id_pro, int.Parse(comboBox5.SelectedValue.ToString()));
                //dgvEditar = objpro.listar_productos(dgvEditar);
                limpiar();
                borrarrows(dgvEditar);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
            }
        }

        private void dgvEditar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                csProveedores objprovee = new csProveedores();
                objprovee.lista_proveedores(comboBox5);

                if (e.RowIndex >= 0)
                {

                    Nombre = dgvEditar.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                    decimal precioDecimal = Convert.ToDecimal(dgvEditar.Rows[e.RowIndex].Cells["PRECIO_UNITARIO"].Value);

                    string precio = precioDecimal.ToString(CultureInfo.InvariantCulture);

                    string idcell = dgvEditar.Rows[e.RowIndex].Cells["IDPRODUCTO"].Value.ToString();

                    comboBox5.DisplayMember = "Proveedor";
                    comboBox5.ValueMember = "proveedor_id";

                    txtNombreProEdi.Text = Nombre;
                    txtPrecioEdit.Text = precio;
                    id_pro = int.Parse(idcell);
                    btnEditar.Enabled = true;
                }
            }
            catch (Exception ex) { }
        }

        private void dgvEliminar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    Nombre = dgvEliminar.Rows[e.RowIndex].Cells["NOMBRE"].Value.ToString();
                    Precio = dgvEliminar.Rows[e.RowIndex].Cells["PRECIO_UNITARIO"].Value.ToString();
                    string idcell = dgvEliminar.Rows[e.RowIndex].Cells["IDPRODUCTO"].Value.ToString();
                    proveedor = dgvEliminar.Rows[e.RowIndex].Cells["PROVEEDOR"].Value.ToString();
                    txtNombreEliminar.Text = Nombre;
                    txtPrecioeliminar.Text = Precio;
                    comboBox6.Text = proveedor;
                    id_pro = int.Parse(idcell);
                    btnEliminar.Enabled = true;
                }
            }
            catch (Exception ex) { }
        }

        private void txtBuscarEliminar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscarEliminar.Text.Trim();

            // Filtrar los datos del DataGridView
            (dgvEliminar.DataSource as DataTable).DefaultView.RowFilter = string.Format("NOMBRE LIKE '%{0}%'", busqueda);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objpro.eliminar_producto(id_pro);
                //dgvEliminar = objpro.listar_productos(dgvEliminar);
                limpiar();
                borrarrows(dgvEliminar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            BuscarEnBaseDatos(dgvAggProductos, txtBuscarProducto, comboBox1);
        }

        private void BuscarEnBaseDatos(DataGridView dgv, TextBox txt, ComboBox cbx)
        {
            string campo = cbx.SelectedItem.ToString();
            string valor = txt.Text;

            objpro.buscar_producto(campo, valor, dgv);
        }

        private void txtBuscarProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarEnBaseDatos(dgvAggProductos, txtBuscarProducto, comboBox1);
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

        private void btnBuscarEliminar_Click(object sender, EventArgs e)
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

        private void btnLimpiarEliminar_Click(object sender, EventArgs e)
        {
            limpiar();
            borrarrows(dgvEliminar);
        }

        private void comboBox4_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    objpro.cargarvalorescombo(comboBox4.Text, comboBox4);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox4_Leave(object sender, EventArgs e)
        {
            try
            {
                bool isValidItem = false;
                foreach (var item in comboBox4.Items)
                {
                    if (comboBox4.Text == ((DataRowView)item)["Nombre"].ToString())
                    {
                        isValidItem = true;
                        break;
                    }
                }

                if (!isValidItem)
                {
                    comboBox4.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox4_DropDown(object sender, EventArgs e)
        {
            comboBox4.SelectedIndex = -1;
        }
    }
}
