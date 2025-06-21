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
    public partial class FormsPruebafacil : Form
    {
        private Random random = new Random();
        private Palabra palabraActual;
        private int modoSeleccionado;

        public FormsPruebafacil(int modoSeleccionado)
        {
            InitializeComponent();
            this.modoSeleccionado = modoSeleccionado;
        }

        private void FormsPruebas_Load(object sender, EventArgs e)
        {
            if (AppState.Palabras == null || !AppState.Palabras.Any())
            {
                MessageBox.Show("No hay palabras cargadas. Verifica el progreso del usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (modoSeleccionado == 1)
            {
                var palabrasDisponibles = AppState.Palabras.Where(p => p.Estado < 6).ToList();
                if (palabrasDisponibles.Count == 0)
                {
                    MessageBox.Show("¡No hay nuevas palabras por aprender! Prueba el modo.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
            }
            CargarNuevPalabra();
        }

        private void CargarNuevPalabra()
        {
            var palabrasDisponiles = AppState.Palabras.Where(p => p.Estado < 10).ToList();
            if (modoSeleccionado == 1)
            {
                palabrasDisponiles = palabrasDisponiles.Where(p => p.Estado < 6).ToList();
            }

            if (palabrasDisponiles.Count == 0)
            {
                MessageBox.Show("¡Has dominado todas las palabras! Regresa al menú.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            palabraActual = palabrasDisponiles[random.Next(palabrasDisponiles.Count)];
            if (lblPregunta == null)
            {
                MessageBox.Show("El control lblPregunta no está inicializado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lblPregunta.Text = $"¿Qué significa {palabraActual.Caracter}? ({palabraActual.Pinyin})";
            txtRespuesta.Text = "";
            txtRespuesta.Focus();
            btnEnviar.Enabled = true;
            btnSiguiente.Enabled = false;
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string respuestaUsuario = txtRespuesta.Text.Trim().ToLower();
            string significadoCorrecto = palabraActual.Significado.ToLower();

            if (respuestaUsuario == significadoCorrecto)
            {
                palabraActual.VecesCorrectas++;
                palabraActual.Estado = Math.Min(palabraActual.VecesCorrectas / 20, 10);
            }

            // Asegurarse de habilitar el botón "Siguiente" después de procesar  
            btnSiguiente.Enabled = true;
            btnEnviar.Enabled = false;

            GuardarYSeguir();
        }

        private void GuardarYSeguir()
        {
            FormAcceso formAcceso = this.ParentForm as FormAcceso;
            if (formAcceso != null)
            {
                formAcceso.GuardarProgreso();
            }
            CargarNuevPalabra();
            btnEnviar.Enabled = true;
            btnSiguiente.Enabled = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            GuardarYSeguir();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FormAcceso formAcceso = this.ParentForm as FormAcceso;
            if (formAcceso != null)
            {
                formAcceso.CargarForm2parte(new FormSeleccionModo());
            }
            this.Hide();
            }
    }
}
