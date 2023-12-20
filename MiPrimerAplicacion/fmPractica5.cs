using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiPrimerAplicacion
{
    public partial class fmPractica5 : Form
    {
        public fmPractica5()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool banderaText = true;

            if (txtApellido.Text == "") { 
                txtApellido.BackColor = Color.Red;
                banderaText = false;
            }
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

            if (txtNombre.Text == "")
            {
                txtNombre.BackColor = Color.Red;
                banderaText = false;
            }
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;

            if (txtEdad.Text == "")
            {
                txtEdad.BackColor = Color.Red;
                banderaText = false;
            }
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;

            if (txtDireccion.Text == "")
            {
                txtDireccion.BackColor = Color.Red;
                banderaText = false;
            }
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;

            if (banderaText) { 
                txtResultado.Text = "Apellido y Nombre:" + txtApellido.Text + " " + txtNombre.Text +
                "Edad:" + txtEdad.Text +
                "Direccion:" + txtDireccion.Text;
            }
            else
                MessageBox.Show("Complete los cuadros en rojo por favor.");


        }

        private void txtEdad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
