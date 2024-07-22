using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facturacion
{
    public partial class frmEditarContrasenia : Form
    {
        
        public frmEditarContrasenia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ContraseñasCoinciden() && esnull())
            {
                csEmpleado empleado = new csEmpleado();
                empleado.editar_contra(CsSesionActiva.EmpleadoEditarID, txtContra1.Text);
                MessageBox.Show("Contraseña de " + CsSesionActiva.NombresEmpleadoEditarID + " cambiada con exito");
                this.Close();
            }
            else
            {
                MessageBox.Show("Las contraseñas no coinciden o estan en vacias. Por favor, inténtelo de nuevo.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool esnull()
        {
            if(string.IsNullOrWhiteSpace(txtContra1.Text) || string.IsNullOrWhiteSpace(txtContra1.Text))
                return false;
            return true;
        }
        private bool ContraseñasCoinciden()
        {
            string nuevaContraseña = txtContra1.Text;
            string confirmarContraseña = txtContra2.Text;

            return string.Equals(nuevaContraseña, confirmarContraseña);
        }

        private void frmEditarContrasenia_Load(object sender, EventArgs e)
        {
            label1.Text = CsSesionActiva.NombresEmpleadoEditarID;
            panel1.BackColor = Color.FromArgb(100, 0, 0, 0);
        }
    }
}
