using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class frmFacturas : Form
    {
        csFactura objfac = new csFactura();
        String idcli;
        int idfac;
        DateTime fecha;
        decimal total;
        DataTable dtFactura;
        public frmFacturas()
        {
            InitializeComponent();
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {
            //dataGridView1 = objfac.listar_facturas(dataGridView1);
            comboBox1.SelectedIndex = 0;
            txtcliente.Enabled = false;
            txtfactura.Enabled = false;
            txtfecha.Enabled = false;
            txttotal.Enabled = false;
        }

        private void limpiar()
        {
            dataGridView1.DataSource = null;
            txtcliente.Text = string.Empty;
            txtfactura.Text = string.Empty;
            txtfecha.Text = string.Empty;
            txttotal.Text = string.Empty;
            txtBuscar.Text = string.Empty;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    idcli = Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells["CLIENTE"].Value);
                    idfac = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IDFACTURA"].Value);
                    fecha = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex].Cells["FECHA"].Value);
                    total = Convert.ToDecimal(dataGridView1.Rows[e.RowIndex].Cells["TOTAL"].Value);

                    txtcliente.Text = idcli.ToString();
                    txtfactura.Text = idfac.ToString();
                    txttotal.Text = total.ToString();
                    txtfecha.Text = fecha.ToShortDateString();

                }
            }
            catch (Exception ex) { }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            {
                // Verificar si hay una factura seleccionada
                if (idfac != 0)
                {
                    MostrarVistaPreviaFactura(idfac);
                }
                else
                {
                    MessageBox.Show("Por favor, seleccione una factura para imprimir.");
                }
            }
        }

        private void MostrarVistaPreviaFactura(int idFactura)
        {
            try
            {
                objfac.abrirconexcion();
                SqlCommand cmd = new SqlCommand("spDetalleFactura", objfac.con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", idFactura);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                dtFactura = new DataTable();
                adapter.Fill(dtFactura);

                objfac.cerrarconexion();

                // Configurar y mostrar la vista previa de impresión
                PrintDocument printDocument1 = new PrintDocument();
                PrintPreviewDialog printPreviewDialog1 = new PrintPreviewDialog();

                printDocument1.PrintPage += new PrintPageEventHandler(prtdocventas_PrintPage);
                printPreviewDialog1.Document = printDocument1;
                printPreviewDialog1.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al obtener la factura: " + ex.Message);
            }
        }

        private void prtdocventas_PrintPage(object sender, PrintPageEventArgs e)
        {
            DateTime hoy = DateTime.Today;
            Font fuenteTitulo = new Font("Arial", 20, FontStyle.Bold);
            Font fuenteSubtitulo = new Font("Arial", 10, FontStyle.Bold);
            Font fuenteContenido = new Font("Arial", 10);
            float yPos = 20;

            // Encabezado
            e.Graphics.DrawString("GCS FACTURA", fuenteTitulo, Brushes.Black, new RectangleF(300, yPos, 300, 40));
            yPos += 40;
            e.Graphics.DrawString("FECHA: " + hoy.ToString("dd/MM/yyyy"), fuenteSubtitulo, Brushes.Black, new RectangleF(50, yPos, 300, 20));
            e.Graphics.DrawString("ID FACTURA: " + idfac, fuenteSubtitulo, Brushes.Black, new RectangleF(600, yPos, 300, 20));
            yPos += 30;

            // Información del Cliente
            e.Graphics.DrawString("CLIENTE: " + dtFactura.Rows[0]["CLIENTE"].ToString(), fuenteContenido, Brushes.Black, new RectangleF(50, yPos, 300, 20));
            yPos += 20;
            e.Graphics.DrawString("VENDEDOR: " + dtFactura.Rows[0]["Empleado"].ToString(), fuenteContenido, Brushes.Black, new RectangleF(50, yPos, 300, 20));
            yPos += 20;

            // Margen entre encabezado y detalle de la factura
            yPos += 10;

            // Línea separadora
            e.Graphics.DrawLine(Pens.Black, 50, yPos, 750, yPos);
            yPos += 10;

            // Encabezados de columnas
            e.Graphics.DrawString("Producto", fuenteSubtitulo, Brushes.Black, new RectangleF(50, yPos, 200, 20));
            e.Graphics.DrawString("Cantidad", fuenteSubtitulo, Brushes.Black, new RectangleF(250, yPos, 100, 20));
            e.Graphics.DrawString("Precio", fuenteSubtitulo, Brushes.Black, new RectangleF(350, yPos, 100, 20));
            e.Graphics.DrawString("Subtotal", fuenteSubtitulo, Brushes.Black, new RectangleF(450, yPos, 100, 20));
            e.Graphics.DrawString("IVA", fuenteSubtitulo, Brushes.Black, new RectangleF(550, yPos, 100, 20));
            e.Graphics.DrawString("Total", fuenteSubtitulo, Brushes.Black, new RectangleF(650, yPos, 100, 20));
            yPos += 20;

            // Línea separadora
            e.Graphics.DrawLine(Pens.Black, 50, yPos, 750, yPos);
            yPos += 10;

            // Detalles de la factura
            foreach (DataRow row in dtFactura.Rows)
            {
                e.Graphics.DrawString(row["PRODUCTO"].ToString(), fuenteContenido, Brushes.Black, new RectangleF(50, yPos, 200, 20));
                e.Graphics.DrawString(row["CANTIDAD"].ToString(), fuenteContenido, Brushes.Black, new RectangleF(250, yPos, 100, 20));
                e.Graphics.DrawString(Convert.ToDecimal(row["PRECIO_UNIT"]).ToString("C"), fuenteContenido, Brushes.Black, new RectangleF(350, yPos, 100, 20));
                e.Graphics.DrawString(Convert.ToDecimal(row["SUBTOTAL"]).ToString("C"), fuenteContenido, Brushes.Black, new RectangleF(450, yPos, 100, 20));
                e.Graphics.DrawString((Convert.ToDecimal(row["IVA"])).ToString("C"), fuenteContenido, Brushes.Black, new RectangleF(550, yPos, 100, 20));
                e.Graphics.DrawString(Convert.ToDecimal(row["TOTAL"]).ToString("C"), fuenteContenido, Brushes.Black, new RectangleF(650, yPos, 100, 20));
                yPos += 20;
            }

            // Línea separadora
            e.Graphics.DrawLine(Pens.Black, 50, yPos, 750, yPos);
            yPos += 10;

            // Total general
            e.Graphics.DrawString("Total", fuenteSubtitulo, Brushes.Black, new RectangleF(550, yPos, 100, 20));
            e.Graphics.DrawString(dtFactura.AsEnumerable().Sum(row => row.Field<decimal>("TOTAL")).ToString("C"), fuenteSubtitulo, Brushes.Black, new RectangleF(650, yPos, 100, 20));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnBuscarFactura_Click(object sender, EventArgs e)
        {
            BuscarEnBaseDatos(dataGridView1, txtBuscar, comboBox1);
        }

        private void BuscarEnBaseDatos(DataGridView dgv, TextBox txt, ComboBox cbx)
        {
            string campo = cbx.SelectedItem.ToString();
            string valor = txt.Text;

            objfac.buscar_factura(campo, valor, dgv);
        }

        private void txtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;
                BuscarEnBaseDatos(dataGridView1, txtBuscar, comboBox1);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
