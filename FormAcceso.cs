using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AByteOf熊猫
{
    public partial class FormAcceso : Form
    {

        public FormAcceso()
        {
            InitializeComponent();
            CargarForm2parte(new FormMenuLearn());
        }
        public void CargarForm2parte(object formHijo2)
        {
            if (this.panelMenu2.Controls.Count > 0)
                this.panelMenu2.Controls.RemoveAt(0);

            Form j = formHijo2 as Form;
            j.TopLevel = false;
            j.Dock = DockStyle.Fill;
            this.panelMenu2.Controls.Add(j);
            this.panelMenu2.Tag = j;
            j.Show();
        }

        private void btnVocabulario_Click(object sender, EventArgs e)
        {
            CargarForm2parte(new FormVocabulario());
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            CargarForm2parte(new FormsPruebas());
        }

        private void btnProgreso_Click(object sender, EventArgs e)
        {
            CargarForm2parte(new FormProgreso());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picLogoMenu_Click(object sender, EventArgs e)
        {
            CargarForm2parte(new FormMenuLearn());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
             "¿Estás seguro de que deseas cerrar sesión?",
              "Confirma el cierre de sesion",
              MessageBoxButtons.YesNo,
              MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes) 
            {
                Log_in formLog = new Log_in();
                formLog.Show();
                this.Close();

            }

            
            
        }
    }
}
