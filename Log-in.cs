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
            CargarForm(new FormsMenu());
        }
        public void CargarForm(object formHijo)
        {
            if (this.panelMenu.Controls.Count > 0)
                this.panelMenu.Controls.RemoveAt(0);

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelMenu.Controls.Add(fh);
            this.panelMenu.Tag = fh;
            fh.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
