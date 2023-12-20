
namespace MiPrimerAplicacion
{
    partial class Name
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBoton1 = new System.Windows.Forms.Button();
            this.lblName1 = new System.Windows.Forms.Label();
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnBoton1
            // 
            this.btnBoton1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnBoton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBoton1.Location = new System.Drawing.Point(177, 153);
            this.btnBoton1.Name = "btnBoton1";
            this.btnBoton1.Size = new System.Drawing.Size(75, 23);
            this.btnBoton1.TabIndex = 0;
            this.btnBoton1.Text = "Presionar";
            this.btnBoton1.UseVisualStyleBackColor = false;
            this.btnBoton1.Click += new System.EventHandler(this.btnBoton1_Click);
            // 
            // lblName1
            // 
            this.lblName1.AutoSize = true;
            this.lblName1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblName1.Font = new System.Drawing.Font("Microsoft PhagsPa", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName1.ForeColor = System.Drawing.Color.Navy;
            this.lblName1.Location = new System.Drawing.Point(177, 65);
            this.lblName1.Name = "lblName1";
            this.lblName1.Size = new System.Drawing.Size(57, 23);
            this.lblName1.TabIndex = 1;
            this.lblName1.Text = "Titulo";
            this.lblName1.MouseLeave += new System.EventHandler(this.lblName1_MouseLeave);
            this.lblName1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblName1_MouseMove);
            // 
            // txtBox1
            // 
            this.txtBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBox1.Location = new System.Drawing.Point(177, 233);
            this.txtBox1.MaxLength = 100;
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 2;
            this.txtBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox1_KeyPress);
            // 
            // txtName2
            // 
            this.txtName2.Location = new System.Drawing.Point(177, 195);
            this.txtName2.Multiline = true;
            this.txtName2.Name = "txtName2";
            this.txtName2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtName2.Size = new System.Drawing.Size(100, 20);
            this.txtName2.TabIndex = 3;
            this.txtName2.Leave += new System.EventHandler(this.txtName2_Leave);
            // 
            // Name
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(471, 362);
            this.Controls.Add(this.txtName2);
            this.Controls.Add(this.txtBox1);
            this.Controls.Add(this.lblName1);
            this.Controls.Add(this.btnBoton1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Name";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PrimerAplicacion";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Name_FormClosed);
            this.Load += new System.EventHandler(this.Name_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBoton1;
        private System.Windows.Forms.Label lblName1;
        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtName2;
    }
}

