using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Data.Sql;
using System.Windows.Forms;
using System.Diagnostics.Contracts;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Facturacion
{
    internal class CsPrincipal
    {
        public SqlConnection con;
        public SqlCommand cmd;
        public string usuario = "sa";
        public string contra = "12345";
        public string bd = "gcsfactura", server = ".";
        public virtual void abrirconexcion()
        {
            con = new SqlConnection();
            con.ConnectionString = "Server=" + server + "; Database=" + bd + "; User id=" + usuario + ";Password=" + contra;
            con.Open();
        }
        public void cerrarconexion()
        {
            con.Close();
        }
    }

    class csClientes:CsPrincipal
    {
        public virtual void ingresar_cliente(string cedula, string nombres, string apellidos)
        {
            string sp = "spAgregarCliente";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Cedula", SqlDbType.NVarChar);
            cmd.Parameters["@Cedula"].Value = cedula;

            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmd.Parameters["@Nombre"].Value = nombres;

            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar);
            cmd.Parameters["@Apellido"].Value = apellidos;

            cmd.ExecuteNonQuery();
            cerrarconexion();
        }

        public virtual void editar_cliente (string cedula, string nombres, string apellidos, int id)
        {
            string sp = "spEditarCliente";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Cedula", SqlDbType.NVarChar);
            cmd.Parameters["@Cedula"].Value = cedula;

            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmd.Parameters["@Nombre"].Value = nombres;

            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar);
            cmd.Parameters["@Apellido"].Value = apellidos;

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = id;

            cmd.ExecuteNonQuery();
            cerrarconexion();
        }

        public virtual void eliminar_cliente(int id)
        {
            string sp = "spEliminarCliente";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = id;

            cmd.ExecuteNonQuery();
            cerrarconexion();
        }

        public DataGridView listar_clientes( DataGridView dgv)
        {
            string sp = "spListarClientes";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv.DataSource = dt;
            cerrarconexion();
            return dgv;
        }

        public DataGridView buscar_cliente(string campo, string valor, DataGridView dgv)
        {
            string sp = "BuscarEnTabla";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@campo", campo);
            cmd.Parameters.AddWithValue("@valor", valor);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv.DataSource = dt;
            cerrarconexion();
            return dgv;
        }
    }

    class csProductos : CsPrincipal
    {
        public DataGridView listar_productos(DataGridView dgv)
        {
            string sp = "spListarProductos";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv.DataSource = dt;
            cerrarconexion();
            return dgv;
        }

        public virtual void ingresar_producto(string nombre, decimal precio, int proveedor)
        {
            string sp = "spAgregarProducto";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmd.Parameters["@Nombre"].Value = nombre;

            cmd.Parameters.Add("@Precio", SqlDbType.Decimal);
            cmd.Parameters["@Precio"].Value = precio;

            cmd.Parameters.Add("@Proveedor", SqlDbType.Int);
            cmd.Parameters["@Proveedor"].Value = proveedor;

            cmd.ExecuteNonQuery();
            cerrarconexion();
        }

        public virtual void editar_productor(string nombres, decimal precio, int id, int proveedor)
        {
            string sp = "spEditarProducto";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmd.Parameters["@Nombre"].Value = nombres;

            cmd.Parameters.Add("@Precio", SqlDbType.Decimal);
            cmd.Parameters["@Precio"].Value = precio;

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = id;

            cmd.Parameters.Add("@Proveedor", SqlDbType.Int);
            cmd.Parameters["@Proveedor"].Value = proveedor;

            cmd.ExecuteNonQuery();
            cerrarconexion();
        }

        public virtual void eliminar_producto(int id)
        {
            string sp = "spEliminarProducto";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@id", SqlDbType.Int);
            cmd.Parameters["@id"].Value = id;

            cmd.ExecuteNonQuery();
            cerrarconexion();
        }

        public DataGridView buscar_producto(string campo, string valor, DataGridView dgv)
        {
            string sp = "spBuscarProducto";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@campo", campo);
            cmd.Parameters.AddWithValue("@valor", valor);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv.DataSource = dt;
            cerrarconexion();
            dgv.Columns["proveedor_id"].Visible = false;
            return dgv;
        }

        public void cargarvalorescombo(string searchText, System.Windows.Forms.ComboBox cbx)
        {
            string sp = "spObtenerProveedores";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SearchText", searchText));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbx.DisplayMember = "Nombre";
            cbx.ValueMember = "proveedor_id";
            cbx.DataSource = dt;

            cerrarconexion();
        }
    }

    class csVentas : CsPrincipal
    {
        //public virtual void llenar_combobox (ComboBox cb)
        //{
        //    string sp = "spListarClientes";
        //    abrirconexcion();

        //    cmd = new SqlCommand(sp, con);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    try
        //    {
        //        con.Open();
        //        SqlDataReader reader = cmd.ExecuteReader();

        //        DataTable dt = new DataTable();
        //        dt.Load(reader);

        //        cbx.DisplayMember = "NOMBRE";
        //        cbx.ValueMember = "IDPRODUCTO";
        //        cbx.DataSource = dt;

        //        reader.Close();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message);
        //    }


        //    cmd.ExecuteNonQuery();
        //    cerrarconexion();
        //}

        public string retornar_precio(int idpro, string sp)
        {
            try
            {
                string valor;
                abrirconexcion();
                cmd = new SqlCommand(sp, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@idpro", SqlDbType.Int);
                cmd.Parameters["@idpro"].Value = idpro;

                cmd.Parameters.Add("@prec", SqlDbType.Money);
                cmd.Parameters["@prec"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                valor = cmd.Parameters["@prec"].Value.ToString();
                con.Close();
                return valor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "0";
            }
        }

        public string retornar_idproducto(string nom, string sp)
        {
            try
            {
                string valor;
                abrirconexcion();
                cmd = new SqlCommand(sp, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@nom", SqlDbType.VarChar);
                cmd.Parameters["@nom"].Value = nom;

                cmd.Parameters.Add("@salid", SqlDbType.Int);
                cmd.Parameters["@salid"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                valor = cmd.Parameters["@salid"].Value.ToString();
                con.Close();
                return valor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "0";
            }
        }

        public void cargarvalorescombo(string searchText, System.Windows.Forms.ComboBox cbx)
        {
            string sp = "spObtenerClientes";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SearchText", searchText));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbx.DisplayMember = "Nombres";
            cbx.ValueMember = "IDCLIENTE";
            cbx.DataSource = dt;

            cerrarconexion();
        }

        public void cargarproductos(string searchText, System.Windows.Forms.ComboBox cbx)
        {
            string sp = "spObtenerProductos";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add(new SqlParameter("@SearchText", searchText));

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbx.DisplayMember = "Nombre";
            cbx.ValueMember = "IDPRODUCTO";
            cbx.DataSource = dt;

            cerrarconexion();

            cerrarconexion();
        }

        public class DetalleVenta
        {
            public string NombreProducto { get; set; }
            public int IdProducto { get; set; }
            public int Cantidad { get; set; }
            public decimal PrecioUnitario { get; set; }
            public decimal Subtotal { get; set; }
            public decimal IVA { get; set; }
            public decimal Total { get; set; }
        }

        public string devolveridfactura(string sp)
        {
            try
            {
                string valor;
                abrirconexcion();
                cmd = new SqlCommand(sp, con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.Add("@sal", SqlDbType.Int);
                cmd.Parameters["@sal"].Direction = ParameterDirection.Output;

                cmd.ExecuteNonQuery();
                valor = cmd.Parameters["@sal"].Value.ToString();
                con.Close();
                return valor;
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
                return "0";
            }
        }

        public bool ValidarUsuario(string usuario, byte[] hashContrasena)
        {
            try
            {
                abrirconexcion();

                using (SqlCommand cmd = new SqlCommand("spValidarUsuario", con))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add(new SqlParameter("@Usuario", usuario));
                    cmd.Parameters.Add(new SqlParameter("@Contrasena", hashContrasena));

                    SqlParameter outputParam = new SqlParameter("@Resultado", SqlDbType.Int)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputParam);

                    SqlParameter outputNombreVendedor = new SqlParameter("@Nombre", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputNombreVendedor);

                    SqlParameter outputRol = new SqlParameter("@Rol", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputRol);

                    SqlParameter outputID = new SqlParameter("@EmpleadoID", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputID);

                    SqlParameter outputApellido = new SqlParameter("@Apellido", SqlDbType.NVarChar, 50)
                    {
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outputApellido);

                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    cmd.ExecuteNonQuery();

                    int result = (int)outputParam.Value;
                    if (result == 1)
                    {
                        CsSesionActiva.NombreVendedor = outputNombreVendedor.Value.ToString();
                        CsSesionActiva.Rol = outputRol.Value.ToString();
                        CsSesionActiva.EmpleadoID = outputID.Value.ToString();
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
        }

    }
    class csFactura : CsPrincipal
    {
        public DataGridView listar_facturas(DataGridView dgv)
        {
            string sp = "spListarFacturas";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv.DataSource = dt;
            cerrarconexion();
            return dgv;
        }

        public byte[] EncriptarContrasena(string contrasena)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                return sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(contrasena));
            }
        }

        public DataGridView buscar_factura(string campo, string valor, DataGridView dgv)
        {
            string sp = "spBuscarFactura";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@campo", campo);
            cmd.Parameters.AddWithValue("@valor", valor);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv.DataSource = dt;
            cerrarconexion();
            return dgv;
        }
    }

    class csEmpleado : CsPrincipal
    {
        public void CargarRolesEnComboBox(System.Windows.Forms.ComboBox comboBox, string procedimiento)
        {
            //string sp = "spListarRoles";
            abrirconexcion();
            SqlCommand cmd = new SqlCommand(procedimiento, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            // Configurar el ComboBox
            comboBox.DataSource = dt;
            comboBox.DisplayMember = "NOMBRE";
            comboBox.ValueMember = "ROLID";

            cerrarconexion();
        }

        public void ingresar_empleado(string nombre, string apellido, string cedula, int rolId, string usuario, string contrasena, int estado)
        {
            csFactura csEmpleado = new csFactura();
            string sp = "spAgregarEmpleado";
            abrirconexcion();
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar).Value = nombre;
            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar).Value = apellido;
            cmd.Parameters.Add("@Cedula", SqlDbType.NVarChar).Value = cedula;
            cmd.Parameters.Add("@RolID", SqlDbType.Int).Value = rolId;
            cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar).Value = usuario;

            byte[] hashContrasena = csEmpleado.EncriptarContrasena(contrasena);
            cmd.Parameters.Add("@Contrasena", SqlDbType.VarBinary).Value = hashContrasena;

            cmd.Parameters.Add("@Estado", SqlDbType.Bit).Value = estado;

            cmd.ExecuteNonQuery();
            cerrarconexion();
        }

        public DataGridView listar_dtg(DataGridView dgv, string procedimiento)
        {
            abrirconexcion();
            cmd = new SqlCommand(procedimiento, con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv.DataSource = dt;
            cerrarconexion();

            if (dgv.Columns["EMPLEADOID"] != null && dgv.Columns["ROLID"] != null)
            {
                dgv.Columns["EMPLEADOID"].Visible = false;
                dgv.Columns["ROLID"].Visible = false;
            }

            return dgv;
        }

        public virtual void editar_empleado(int empleadoID, string Nombre, string Apellido, string Cedula, int RolID, string Usuario, int Estado)
        {
            string sp = "spEditarEmpleados";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@EmpleadoID", SqlDbType.Int);
            cmd.Parameters["@EmpleadoID"].Value = empleadoID;

            cmd.Parameters.Add("@Nombre", SqlDbType.NVarChar);
            cmd.Parameters["@Nombre"].Value = Nombre;

            cmd.Parameters.Add("@Apellido", SqlDbType.NVarChar);
            cmd.Parameters["@Apellido"].Value = Apellido;

            cmd.Parameters.Add("@Cedula", SqlDbType.NVarChar);
            cmd.Parameters["@Cedula"].Value = Cedula;

            cmd.Parameters.Add("@Usuario", SqlDbType.NVarChar);
            cmd.Parameters["@Usuario"].Value = Usuario;

            cmd.Parameters.Add("@RolID", SqlDbType.Int);
            cmd.Parameters["@RolID"].Value = RolID;

            cmd.Parameters.Add("@Estado", SqlDbType.Bit);
            cmd.Parameters["@Estado"].Value = Estado;

            cmd.ExecuteNonQuery();
            cerrarconexion();
        }

        public virtual void editar_contra(int empleadoID, string contrasena)
        {
            csFactura csEmpleado = new csFactura();
            string sp = "spEditarContra";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@EmpleadoID", SqlDbType.Int);
            cmd.Parameters["@EmpleadoID"].Value = empleadoID;

            byte[] hashContrasena = csEmpleado.EncriptarContrasena(contrasena);

            cmd.Parameters.Add("@Contrasenia", SqlDbType.VarBinary);
            cmd.Parameters["@Contrasenia"].Value = hashContrasena;

            cmd.ExecuteNonQuery();
            cerrarconexion();
        }

        public DataGridView buscar_empleado(string campo, string valor, DataGridView dgv)
        {
            string sp = "spBuscarEmpleado";
            abrirconexcion();
            cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@campo", campo);
            cmd.Parameters.AddWithValue("@valor", valor);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgv.DataSource = dt;
            cerrarconexion();
            if (dgv.Columns["ID EMPLEADO"] != null && dgv.Columns["ROLID"] != null)
            {
                dgv.Columns["ID EMPLEADO"].Visible = false;
                dgv.Columns["ROLID"].Visible = false;
            }
            return dgv;
        }
    }

    class csProveedores : CsPrincipal
    {
        public System.Windows.Forms.ComboBox lista_proveedores  (System.Windows.Forms.ComboBox cbx)
        {
            abrirconexcion();
            cmd = new SqlCommand("spListarProveedores", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            cbx.DataSource = dt;
            cerrarconexion();
            cbx.DisplayMember = "nombre";
            cbx.ValueMember = "proveedor_id";
            return cbx;
        }
    }
}
