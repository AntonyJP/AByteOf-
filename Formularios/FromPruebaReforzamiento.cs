using System;
using AByteOf熊猫.Models;
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
    public partial class FromPruebaReforzamiento : Form
    {
        private Random random = new Random();
        private Palabra palabraActual;
        private int modoSeleccionado;

        public FromPruebaReforzamiento(int modoSeleccionado)
        {
            InitializeComponent();
            this.modoSeleccionado = modoSeleccionado;
        }



        private void btnEnviar_Click(object sender, EventArgs e)
        {
            string respuestaUsuario = txtRespuesta.Text.Trim().ToLower();
            string significadoCorrecto = palabraActual.Significado.ToLower();

            if (respuestaUsuario == significadoCorrecto)
            {
                MessageBox.Show("¡Respuesta correcta!", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                palabraActual.VecesCorrectas++;
                palabraActual.Estado = Math.Min(palabraActual.VecesCorrectas / 20, 10);
            }
            else
            {
                MessageBox.Show($"Respuesta incorrecta. La respuesta correcta era: {palabraActual.Significado}", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEnviar.Enabled = false;
            }
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

        private void FromPruebaReforzamiento_Load(object sender, EventArgs e)
        {
            // Si está en modo 'aprender nuevas', filtra las palabras con estado menor a 6
            if (modoSeleccionado == 2)
            {
                var palabrasDisponibles = AppState.Palabras.Where(p => p.Estado >= 6).ToList();
                if (palabrasDisponibles.Count == 0)
                {
                    MessageBox.Show("¡No hay nuevas palabras por repasar!", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
            }
            CargarNuevPalabra();
        }

        private void CargarNuevPalabra()
        {
            var palabrasDisponiles = AppState.Palabras.Where(p => p.Estado < 10).ToList();
            if (modoSeleccionado == 2)
            {
                palabrasDisponiles = palabrasDisponiles.Where(p => p.Estado >= 6).ToList();
            }

            if (palabrasDisponiles.Count == 0)
            {
                MessageBox.Show("¡Has dominado todas las palabras! Regresa al menú.", "Completado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            palabraActual = palabrasDisponiles[random.Next(palabrasDisponiles.Count)];
            lblPregunta.Text = $"¿Qué significa {palabraActual.Caracter}? ({palabraActual.Pinyin})";
            txtRespuesta.Text = "";
            txtRespuesta.Focus();
            btnEnviar.Enabled = true;
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
        }
    }
}
