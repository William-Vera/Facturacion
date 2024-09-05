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
            //LlenarComboBox("spListarClientes");
            //LlenarComboBox1("spListarProductos");
            dataGridView1.Columns.Clear();

            dataGridView1.Columns.Add("Cliente", "CLIENTE");
            dataGridView1.Columns.Add("Producto", "PRODUCTO");
            dataGridView1.Columns.Add("Cantidad", "CANTIDAD");
            dataGridView1.Columns.Add("Precio", "PRECIO");
            dataGridView1.Columns.Add("Subtotal", "SUBTOTAL");
            dataGridView1.Columns.Add("IVA", "IVA");
            dataGridView1.Columns.Add("Total", "TOTAL");

            var column = new DataGridViewTextBoxColumn();
            column.Name = "IdProducto";
            column.Visible = false;
            dataGridView1.Columns.Add(column);

            DataGridViewImageColumn imgColumn = new DataGridViewImageColumn();
            imgColumn.Name = "Eliminar";
            imgColumn.HeaderText = "Eliminar";
            imgColumn.Image = Properties.Resources.icono_eliminar;
            imgColumn.ImageLayout = DataGridViewImageCellLayout.Zoom;
            dataGridView1.Columns.Add(imgColumn);

            //DataGridViewButtonColumn btnColumn = new DataGridViewButtonColumn();
            //btnColumn.Name = "Eliminar";
            //btnColumn.HeaderText = "ELIMINAR";
            //btnColumn.Text = "X";
            //btnColumn.UseColumnTextForButtonValue = true;          
            //dataGridView1.Columns.Add(btnColumn);
            dataGridView1.Columns["Cantidad"].ReadOnly = false;
            dataGridView1.Columns["Precio"].ReadOnly = true;
            dataGridView1.Columns["Subtotal"].ReadOnly = true;
            dataGridView1.Columns["IVA"].ReadOnly = true;
            dataGridView1.Columns["Total"].ReadOnly = true;
            dataGridView1.Columns["Producto"].ReadOnly = true;
            dataGridView1.Columns["Cliente"].ReadOnly = true;
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
                decimal valor_iva = 0.15m;
                int cantidad = int.Parse(textBox1.Text);
                int idprod = int.Parse(comboBox2.SelectedValue.ToString());
                decimal precio = decimal.Parse(objvent.retornar_precio(idprod, "spretornaprecio"));
                decimal subtotal = precio * cantidad;
                decimal iva = subtotal * valor_iva;
                decimal total = subtotal + iva;

                // Verificar si el producto ya está en el carrito (DataGridView)
                bool productoExistente = false;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    if ((int)row.Cells["IdProducto"].Value == idprod)
                    {
                        // Actualizar la fila existente
                        int nuevaCantidad = (int)row.Cells["Cantidad"].Value + cantidad;
                        decimal nuevoSubtotal = precio * nuevaCantidad;
                        decimal nuevoIva = nuevoSubtotal * valor_iva;
                        decimal nuevoTotal = nuevoSubtotal + nuevoIva;

                        row.Cells["Cantidad"].Value = nuevaCantidad;
                        row.Cells["Subtotal"].Value = nuevoSubtotal;
                        row.Cells["IVA"].Value = nuevoIva;
                        row.Cells["Total"].Value = nuevoTotal;

                        productoExistente = true;
                        break;
                    }
                }

                if (!productoExistente)
                {
                    // Agregar nueva fila al DataGridView
                    dataGridView1.Rows.Add(comboBox1.Text, comboBox2.Text, cantidad, precio, subtotal, iva, total, idprod);
                }

                comboBox1.Enabled = false;
                dateTimePicker1.Enabled = false;
                textBox1.Text = string.Empty;
                comboBox2.SelectedIndex = -1;
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
            if (dataGridView1.Rows.Count > 0)
            {
                comboBox1.Enabled = true;
                dateTimePicker1.Enabled = true;

                // Limpiar la lista de detalles para evitar duplicados en ventas posteriores
                detallesVenta.Clear();

                // Recorrer el DataGridView y agregar cada fila a la lista de detallesVenta
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Asegúrate de que la fila no sea una fila nueva (puede no contener valores válidos)
                    if (row.IsNewRow) continue;

                    int idProducto;
                    int cantidad;
                    decimal precio;
                    decimal subtotal;
                    decimal iva;
                    decimal total;

                    bool idProductoValid = int.TryParse(row.Cells["IdProducto"].Value?.ToString(), out idProducto);
                    bool cantidadValid = int.TryParse(row.Cells["Cantidad"].Value?.ToString(), out cantidad);
                    bool precioValid = decimal.TryParse(row.Cells["Precio"].Value?.ToString(), out precio);
                    bool subtotalValid = decimal.TryParse(row.Cells["Subtotal"].Value?.ToString(), out subtotal);
                    bool ivaValid = decimal.TryParse(row.Cells["IVA"].Value?.ToString(), out iva);
                    bool totalValid = decimal.TryParse(row.Cells["Total"].Value?.ToString(), out total);

                    if (idProductoValid && cantidadValid && precioValid && subtotalValid && ivaValid && totalValid)
                    {
                        detallesVenta.Add(new DetalleVenta
                        {
                            NombreProducto = row.Cells["Producto"].Value?.ToString(),
                            IdProducto = idProducto,
                            Cantidad = cantidad,
                            PrecioUnitario = precio,
                            Subtotal = subtotal,
                            IVA = iva,
                            Total = total
                        });
                    }
                    else
                    {
                        // Opcional: Mostrar un mensaje de advertencia o manejar el caso en que la conversión falla
                        MessageBox.Show("Error en los datos de una o más filas. Verifica que todos los valores sean válidos.");
                    }
                }


                // Insertar la venta y sus detalles en la base de datos
                DateTime fecha = DateTime.Now;
                InsertarDetalleVentaEnBD(int.Parse(comboBox1.SelectedValue.ToString()), fecha);

                imprimirfact();
                limpiar();
                borrarrows();
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un producto al carrito.");
            }
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
            comboBox1.DataSource = null;
            comboBox2.DataSource = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                borrarrows();
                detallesVenta.Clear();
                limpiar();
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
                dataGridView1.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar las filas del DataGridView: " + ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridView1.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                int idProducto = (int)dataGridView1.Rows[e.RowIndex].Cells["IdProducto"].Value;
                var detalle = detallesVenta.FirstOrDefault(d => d.IdProducto == idProducto);
                if (detalle != null)
                {
                    detallesVenta.Remove(detalle);
                }
                dataGridView1.Rows.RemoveAt(e.RowIndex);
            }
        }

        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    objvent.cargarvalorescombo(comboBox1.Text, comboBox1);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            try
            {
                bool isValidItem = false;
                foreach (var item in comboBox1.Items)
                {
                    if (comboBox1.Text == ((DataRowView)item)["Nombres"].ToString())
                    {
                        isValidItem = true;
                        break;
                    }
                }

                if (!isValidItem)
                {
                    comboBox1.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox2_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    objvent.cargarproductos(comboBox2.Text, comboBox2);
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            try
            {
                bool isValidItem = false;
                foreach (var item in comboBox2.Items)
                {
                    if (comboBox2.Text == ((DataRowView)item)["Nombre"].ToString())
                    {
                        isValidItem = true;
                        break;
                    }
                }

                if (!isValidItem)
                {
                    comboBox2.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox1_DropDown(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
        }

        private void comboBox2_DropDown(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = -1;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Cantidad")
            {
                // Inicializar variables para almacenar los valores convertidos
                int cantidad;
                decimal precio;

                // Intentar convertir el valor de la celda "Cantidad" a entero
                bool cantidadConvertida = int.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Cantidad"].Value?.ToString(), out cantidad);
                // Intentar convertir el valor de la celda "Precio" a decimal
                bool precioConvertido = decimal.TryParse(dataGridView1.Rows[e.RowIndex].Cells["Precio"].Value?.ToString(), out precio);

                // Solo recalcular si ambas conversiones son exitosas
                if (cantidadConvertida && precioConvertido)
                {
                    // Recalcular Subtotal, IVA y Total
                    decimal subtotal = precio * cantidad;
                    decimal iva = subtotal * 0.15m;
                    decimal total = subtotal + iva;

                    // Actualizar las celdas correspondientes
                    dataGridView1.Rows[e.RowIndex].Cells["Subtotal"].Value = subtotal;
                    dataGridView1.Rows[e.RowIndex].Cells["IVA"].Value = iva;
                    dataGridView1.Rows[e.RowIndex].Cells["Total"].Value = total;
                }
                else
                {
                    // Manejar el caso en que la conversión falla (opcional)
                    // Puedes establecer valores predeterminados o mostrar un mensaje al usuario
                    MessageBox.Show("Error en la conversión de datos. Asegúrate de que la cantidad y el precio sean valores válidos.");
                }
            }
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == dataGridView1.Columns["Cantidad"].Index)
            {
                TextBox txt = e.Control as TextBox;
                if (txt != null)
                {
                    txt.KeyPress -= new KeyPressEventHandler(dataGridView1_KeyPress);
                    txt.KeyPress += new KeyPressEventHandler(dataGridView1_KeyPress);
                }
            }
        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }
    }
}
