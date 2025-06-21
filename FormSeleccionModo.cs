using AByteOf熊猫.Models;
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
    public partial class FormSeleccionModo : Form
    {

        public int ModoSeleccionado { get; private set; }

        public FormSeleccionModo()
        {
            InitializeComponent();
        }

        private void btnAprenderNuevasPalabras_Click(object sender, EventArgs e)
        {
            ModoSeleccionado = 1;
            CargarFormularioPrueba();
        }

        private void btnReforzar_Click(object sender, EventArgs e)
        {
            ModoSeleccionado = 2;
            CargarFormularioPrueba();
        }

        private void FormSeleccionModo_Load(object sender, EventArgs e)
        {
            var palabrasAvanzadas = AppState.Palabras.Count(p => p.Estado > 5);
            if (palabrasAvanzadas < 5)
            {
                btnReforzar.Enabled = false;
                lblMensaje.Text = "Necesitas al menos 5 palabras con estado > 5 para el modo reforzar.";
            }
            else
            {
                lblMensaje.Text = "Selecciona un modo de estudio:";
            }
        }

        private void CargarFormularioPrueba()
        {
            FormAcceso formAcceso = this.ParentForm as FormAcceso;
            if (formAcceso != null)
            {
                if (ModoSeleccionado == 1)
                {
                    formAcceso.CargarForm2parte(new FormsPruebafacil(ModoSeleccionado));
                }
                else if (ModoSeleccionado == 2)
                {
                    formAcceso.CargarForm2parte(new FormPruebaDificil());
                }
            }
            this.Hide();
        }
    }
}   
