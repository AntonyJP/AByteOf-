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
        // Referencia al formulario contenedor principal
        private Log_in formPrincipal;
        // Constructor que recibe una instancia del formulario principal
        public FormInicio(Log_in form)
        {
            InitializeComponent();
            formPrincipal = form;// Guardar la referencia para poder cargar formularios dentro de él
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
