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
    public partial class Log_in : Form
    {
        public Log_in()
        {
            InitializeComponent();
            // Carga la imagen del logo al iniciar la aplicación
            string rutaLogo = Path.Combine(Application.StartupPath, "Assets", "A byte of.png");
            pcbLogo.Image = Image.FromFile(rutaLogo);

            CargarForm(new FormInicio(this));


        }
        // Método para cargar un formulario dentro del panel llamado "panelMenu"
        public void CargarForm(object formHijo)
        {
            // Si ya hay un formulario cargado, lo quita
            if (this.panelMenu.Controls.Count > 0)
                this.panelMenu.Controls.RemoveAt(0);
            // Convierte el objeto a Form, lo configura para que se acople al panel
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(fh);
            this.panelMenu.Tag = fh;
            fh.Show();
        }



        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
