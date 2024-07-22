using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Facturacion.csVentas;

namespace Facturacion
{
    public partial class frmVentas : Form
    {
        csVentas objvent = new csVentas();
        List<DetalleVenta> detallesVenta = new List<DetalleVenta>();

        public frmVentas()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LlenarComboBox(string sp)
        {
            CsPrincipal conexionDB = new CsPrincipal();

            try
            {
                conexionDB.abrirconexcion();
                using (SqlCommand cmd = new SqlCommand(sp, conexionDB.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBox1.DisplayMember = "NOMBRES";
                    comboBox1.ValueMember = "IDCLIENTE";
                    comboBox1.DataSource = dt;

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionDB.cerrarconexion();
            }
        }

        private void LlenarComboBox1(string sp)
        {
            CsPrincipal conexionDB = new CsPrincipal();

            try
            {
                conexionDB.abrirconexcion();
                using (SqlCommand cmd = new SqlCommand(sp, conexionDB.con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    SqlDataReader reader = cmd.ExecuteReader();

                    DataTable dt = new DataTable();
                    dt.Load(reader);

                    comboBox2.DisplayMember = "NOMBRE";
                    comboBox2.ValueMember = "IDPRODUCTO";
                    comboBox2.DataSource = dt;

                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conexionDB.cerrarconexion();
            }
        }

        private void frmVentas_Load(object sender, EventArgs e)
        {
            LlenarComboBox("spListarClientes");
            LlenarComboBox1("spListarProductos");
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Cliente", "CLIENTE");
            dataGridView1.Columns.Add("Producto", "PRODUCTO");
            dataGridView1.Columns.Add("Cantidad", "CANTIDAD");
            dataGridView1.Columns.Add("Precio", "PRECIO");
            dataGridView1.Columns.Add("Subtotal", "SUBTOTAL");
            dataGridView1.Columns.Add("IVA", "IVA");
            dataGridView1.Columns.Add("Total", "TOTAL");

            // Añadir columna para IdProducto, pero hacerla invisible
            var column = new DataGridViewTextBoxColumn();
            column.Name = "IdProducto";
            column.Visible = false;
            dataGridView1.Columns.Add(column);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != null && textBox1.Text != "" && comboBox1.Text != "" && comboBox2.Text != "")
            {
                double valor_iva = 0.15;
                int cantidad = int.Parse(textBox1.Text);
                int idprod = int.Parse(comboBox2.SelectedValue.ToString());
                double precio = double.Parse(objvent.retornar_precio(idprod, "spretornaprecio"));
                double subtotal = precio * cantidad;
                double iva = subtotal * valor_iva;
                double total = subtotal + subtotal * valor_iva;

                // Buscar el producto en la lista
                var detalleExistente = detallesVenta.FirstOrDefault(d => d.IdProducto == idprod);

                if (detalleExistente != null)
                {
                    // Actualizar los valores si el producto ya existe
                    detalleExistente.Cantidad += cantidad;
                    detalleExistente.Subtotal = detalleExistente.PrecioUnitario * detalleExistente.Cantidad;
                    detalleExistente.IVA = detalleExistente.Subtotal * (decimal)valor_iva;
                    detalleExistente.Total = detalleExistente.Subtotal + detalleExistente.IVA;

                    // Actualizar el DataGridView
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        if ((int)row.Cells["IdProducto"].Value == idprod)
                        {
                            row.Cells["Cantidad"].Value = detalleExistente.Cantidad;
                            row.Cells["Subtotal"].Value = detalleExistente.Subtotal;
                            row.Cells["IVA"].Value = detalleExistente.IVA;
                            row.Cells["Total"].Value = detalleExistente.Total;
                            break;
                        }
                    }
                }
                else
                {
                    // Agregar el producto si no existe
                    detallesVenta.Add(new DetalleVenta
                    {
                        NombreProducto = comboBox2.Text,
                        IdProducto = idprod,
                        Cantidad = cantidad,
                        PrecioUnitario = (decimal)precio,
                        Subtotal = (decimal)subtotal,
                        IVA = (decimal)iva,
                        Total = (decimal)total
                    });

                    dataGridView1.Rows.Add(comboBox1.Text, comboBox2.Text, cantidad, (decimal)precio, (decimal)subtotal, (decimal)iva, (decimal)total, idprod);
                }

                comboBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
            }
            else
            {
                MessageBox.Show("Recuerde que debe llenar los campos necesarios para poder añadir al carrito");
            }
        }

        private void InsertarDetalleVentaEnBD(int idCliente, DateTime fecha)
        {
            decimal totalFactura = 0;

            foreach (var detalle in detallesVenta)
            {
                totalFactura += detalle.Total;
            }

            // Llamar al procedimiento almacenado para insertar la factura y sus detalles
            InsertarVenta(idCliente, fecha, totalFactura);
        }

        private void InsertarVenta(int idCliente, DateTime fecha, decimal totalFactura)
        {
            CsPrincipal conexionDB = new CsPrincipal();

            try
            {
                conexionDB.abrirconexcion();

                // Insertar la factura
                SqlCommand cmd = new SqlCommand("spInsertarFacturaYDetalles", conexionDB.con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@IDCLIENTE", idCliente);
                cmd.Parameters.AddWithValue("@EMPLEADOID", int.Parse(CsSesionActiva.EmpleadoID));
                cmd.Parameters.AddWithValue("@FECHA", fecha);
                cmd.Parameters.AddWithValue("@TOTAL_FACTURA", totalFactura);

                // Tabla para almacenar los detalles de la venta
                DataTable dtDetalles = new DataTable();
                dtDetalles.Columns.Add("IDPRODUCTO", typeof(int));
                dtDetalles.Columns.Add("PRECIO_UNIT", typeof(decimal));
                dtDetalles.Columns.Add("CANTIDAD", typeof(int));
                dtDetalles.Columns.Add("SUBTOTAL", typeof(decimal));
                dtDetalles.Columns.Add("IVA", typeof(decimal));
                dtDetalles.Columns.Add("TOTAL_DETALLE", typeof(decimal));

                foreach (var detalle in detallesVenta)
                {
                    dtDetalles.Rows.Add(detalle.IdProducto, detalle.PrecioUnitario, detalle.Cantidad, detalle.Subtotal, detalle.IVA, detalle.Total);
                }

                cmd.Parameters.AddWithValue("@DETALLES", dtDetalles);

                cmd.ExecuteNonQuery();

                MessageBox.Show("Venta realizada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la venta: " + ex.Message);
            }
            finally
            {
                conexionDB.cerrarconexion();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 && textBox1.Text != null)
            {
                comboBox1.Enabled = true;
                dateTimePicker1.Enabled = true;
                DateTime fecha = DateTime.Now;
                InsertarDetalleVentaEnBD(int.Parse(comboBox1.SelectedValue.ToString()), fecha);
                imprimirfact();
                limpiar();
                borrarrows();
            }
            else
                MessageBox.Show("Debe agregar almenos un 1 producto al carrito");
        }


        private void prtdocventas_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int maxid = int.Parse(objvent.devolveridfactura("[spDevolveridmax]"));
            DateTime hoy = DateTime.Today;
            Font fuenteTitulo = new Font("Arial", 20, FontStyle.Bold);
            Font fuenteSubtitulo = new Font("Arial", 10, FontStyle.Bold);
            Font fuenteContenido = new Font("Arial", 10);
            float yPos = 20;

            // Dibujar imágenes de alta calidad
            //e.Graphics.DrawImage(imageList1.Images[0], 50, yPos, imageList1.Images[0].Width, imageList1.Images[0].Height); // Imagen izquierda
            //e.Graphics.DrawImage(imageList1.Images[0], 650, yPos, imageList1.Images[0].Width, imageList1.Images[0].Height); // Imagen derecha

            // Encabezado
            yPos += Math.Max(imageList1.Images[0].Height, imageList1.Images[0].Height) + 20;
            e.Graphics.DrawString("GCS FACTURA", fuenteTitulo, Brushes.Black, new RectangleF(300, yPos, 300, 40));
            yPos += 40;
            e.Graphics.DrawString("FECHA: " + hoy.ToString("dd/MM/yyyy"), fuenteSubtitulo, Brushes.Black, new RectangleF(50, yPos, 300, 20));
            e.Graphics.DrawString("ID VENTA: " + maxid, fuenteSubtitulo, Brushes.Black, new RectangleF(600, yPos, 300, 20));
            yPos += 30;

            // Información del Cliente
            e.Graphics.DrawString("CLIENTE: " + comboBox1.Text, fuenteContenido, Brushes.Black, new RectangleF(50, yPos, 300, 20));
            yPos += 20;

            e.Graphics.DrawString("VENDEDOR: " + CsSesionActiva.NombreVendedor, fuenteContenido, Brushes.Black, new RectangleF(50, yPos, 300, 20));
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
            foreach (var detalle in detallesVenta)
            {
                e.Graphics.DrawString(detalle.NombreProducto, fuenteContenido, Brushes.Black, new RectangleF(50, yPos, 200, 20));
                e.Graphics.DrawString(detalle.Cantidad.ToString(), fuenteContenido, Brushes.Black, new RectangleF(250, yPos, 100, 20));
                e.Graphics.DrawString(detalle.PrecioUnitario.ToString("C"), fuenteContenido, Brushes.Black, new RectangleF(350, yPos, 100, 20));
                e.Graphics.DrawString(detalle.Subtotal.ToString("C"), fuenteContenido, Brushes.Black, new RectangleF(450, yPos, 100, 20));
                e.Graphics.DrawString(detalle.IVA.ToString("C"), fuenteContenido, Brushes.Black, new RectangleF(550, yPos, 100, 20));
                e.Graphics.DrawString(detalle.Total.ToString("C"), fuenteContenido, Brushes.Black, new RectangleF(650, yPos, 100, 20));
                yPos += 20;
            }

            // Línea separadora
            e.Graphics.DrawLine(Pens.Black, 50, yPos, 750, yPos);
            yPos += 10;

            // Total general
            e.Graphics.DrawString("Total", fuenteSubtitulo, Brushes.Black, new RectangleF(550, yPos, 100, 20));
            e.Graphics.DrawString(detallesVenta.Sum(d => d.Total).ToString("C"), fuenteSubtitulo, Brushes.Black, new RectangleF(650, yPos, 100, 20));
        }

        private void imprimirfact()
        {
            printDocument1 = new PrintDocument();
            PrintPreviewDialog visu = new PrintPreviewDialog();
            PrinterSettings ps = new PrinterSettings();
            printDocument1.PrinterSettings = ps;
            printDocument1.PrintPage += prtdocventas_PrintPage;
            visu.Document = printDocument1;
            visu.ShowDialog();
        }

        public void limpiar()
        {
            comboBox1.Text = string.Empty;
            comboBox2.Text = string.Empty;
            textBox1.Text = string.Empty;
            dateTimePicker1.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                borrarrows();  // Elimina las filas del DataGridView
                detallesVenta.Clear();  // Vacía la lista de detalles de la venta
                limpiar();  // Limpia los controles del formulario
                MessageBox.Show("Venta cancelada y datos limpiados correctamente.");
                comboBox1.Enabled = true;
                dateTimePicker1.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cancelar la venta: " + ex.Message);
            }
        }

        public void borrarrows()
        {
            try
            {
                dataGridView1.Rows.Clear();  // Elimina todas las filas del DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar las filas del DataGridView: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
