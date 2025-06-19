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
        bool mostrarContra = false;
        private void btnVerContrai_Click(object sender, EventArgs e)
        {
            mostrarContra = !mostrarContra;
            txtContraseñai.UseSystemPasswordChar = !mostrarContra;
            if (mostrarContra)
            {
                btnVerContrai.Image = Properties.Resources.ojoabierto;
            }
            else
            {
                btnVerContrai.Image = Properties.Resources.ojoCerrado;  
            }
        }
    }
}
