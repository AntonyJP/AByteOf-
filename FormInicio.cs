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

    public partial class FormInicio : Form
    {
        private Log_in formPrincipal;
        public FormInicio(Log_in form)
        {
            InitializeComponent();
            formPrincipal = form;
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            formPrincipal.CargarForm(new FormIniciarSesion(formPrincipal));
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            formPrincipal.CargarForm(new FormRegistrarse(formPrincipal));
        }
    }
}
