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
            string apellido = txtApellido.Text;
            string nombre = txtNombre.Text;
            string edad = txtEdad.Text;
            string direccion = txtDireccion.Text;

            if (apellido == "") { 
                txtApellido.BackColor = Color.Red;
                banderaText = false;
            }
            else
                txtApellido.BackColor = System.Drawing.SystemColors.Control;

            if (nombre == ""){
                txtNombre.BackColor = Color.Red;
                banderaText = false;
            }
            else
                txtNombre.BackColor = System.Drawing.SystemColors.Control;

            if (edad == ""){ 
                txtEdad.BackColor = Color.Red;
                banderaText = false;
            }
            else
                txtEdad.BackColor = System.Drawing.SystemColors.Control;

            if (direccion == "")
            {
                txtDireccion.BackColor = Color.Red;
                banderaText = false;
            }
            else
                txtDireccion.BackColor = System.Drawing.SystemColors.Control;

            if (banderaText) { 
                txtResultado.Text = "Apellido y Nombre:" + apellido + " " + nombre + "\r\nEdad:" + edad + "\r\nDireccion:" + direccion;
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
