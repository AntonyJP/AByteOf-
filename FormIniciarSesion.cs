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
    public partial class FormIniciarSesion : Form
    {
        private Log_in formPrincipal;
        public FormIniciarSesion(Log_in form)
        {
            InitializeComponent();
            formPrincipal = form;
        }

        private void btnRegresarI_Click(object sender, EventArgs e)
        {
            formPrincipal.CargarForm(new FormInicio(formPrincipal));
        }
    }
}
