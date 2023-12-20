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
    public partial class Name : Form
    {
        public Name()
        {
            InitializeComponent();
        }

        private void Name_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Bienvenidos a C#");
        }

        private void Name_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Chau Chau ...");
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Se disparo el evento Click", "Atención");
            // this.BackColor = Color.Blue; // Cambia el color de la ventana al ejecutar.

            //MouseEventArgs click = (MouseEventArgs)e;
            //if (click.Button == MouseButtons.Left)
            //    MessageBox.Show("Presiono el botón Izquierdo", "Atención");
            //else if (click.Button == MouseButtons.Right)
            //    MessageBox.Show("Presiono el Botón Derecho", "Atención");
            //else
            //if (click.Button == MouseButtons.Middle)
            //    MessageBox.Show("Presiono el botón del Medio", "Atención");

            if (txtBox1.Text == "")
                txtBox1.BackColor = Color.Red;
            else
                txtBox1.BackColor = System.Drawing.SystemColors.Control;
        }

        private void lblName1_MouseMove(object sender, MouseEventArgs e)
        {
            lblName1.BackColor = Color.Cyan;
            lblName1.Cursor = Cursors.Hand; // Cuando hace contacto con el label, transforma el cursor en un mano.

        }

        private void lblName1_MouseLeave(object sender, EventArgs e)
        {
            lblName1.BackColor = System.Drawing.SystemColors.Control;
            // Restablece al color anterior.Dejando sin efecto el MouseMove.
            lblName1.Cursor = Cursors.Arrow;
        }

        private void txtBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 59) && e.KeyChar != 8)
                e.Handled = true;
            // Esta nos permite ingresar solamente numeros.

        }

        private void txtName2_Leave(object sender, EventArgs e)
        {
            MessageBox.Show("Tiene " + txtName2.Text.Length + " Caracteres");
            // muesta la cantidad de caracteres que tiene el txt.
        }
    }
}
