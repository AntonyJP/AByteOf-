using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net.Http;
using AByteOf熊猫.Models;

namespace AByteOf熊猫
{
    public partial class FormRegistrarse : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7159/") };
        private Log_in formPrincipal;
        public FormRegistrarse(Log_in form)
        {
            InitializeComponent();
            this.Load += FormRegistrarse_Load;
            formPrincipal = form;
           
            
        }

        private void btnRegresarR_Click(object sender, EventArgs e)
        {
            formPrincipal.CargarForm(new FormInicio(formPrincipal));
        }

        private async void btnRegistrarCuentaApp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioRe.Text) || string.IsNullOrWhiteSpace(txtCorreoRe.Text) ||
                string.IsNullOrWhiteSpace(txtContraseñaRe.Text) || string.IsNullOrWhiteSpace(txtConfirmarContraseñaRe.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validar que las contraseñas coincidan
            if (txtContraseñaRe.Text != txtConfirmarContraseñaRe.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Crear el modelo para el registro usando la clase Usuario
            var usuario = new Usuarios
            {
                Nombre = txtUsuarioRe.Text,
                Correo = txtCorreoRe.Text,
                Contrasena = txtContraseñaRe.Text
            };

            try
            {
                // Serializar el modelo a JSON y mostrarlo para depuración
                var jsonContent = new StringContent(
                    JsonConvert.SerializeObject(usuario),
                    Encoding.UTF8,
                    "application/json"
                );
                MessageBox.Show("JSON enviado: " + JsonConvert.SerializeObject(usuario), "Depuración");

                // Enviar la solicitud a la API
                var response = await client.PostAsync("api/users/register", jsonContent);
                var responseContent = await response.Content.ReadAsStringAsync();

                // Mostrar detalles de la respuesta para depuración
                MessageBox.Show($"Código de estado: {(int)response.StatusCode}\nRespuesta: {responseContent}", "Depuración");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(responseContent, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // Limpiar los campos
                    txtUsuarioRe.Text = "";
                    txtCorreoRe.Text = "";
                    txtContraseñaRe.Text = "";
                    txtConfirmarContraseñaRe.Text = "";
                }
                else
                {
                    MessageBox.Show($"Error: {responseContent}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void FormRegistrarse_Load(object sender, EventArgs e)
        {
            // Mostrar la imagen del ojo btncontra
           
            btnVerContraR.Image = RedimensionarImagen(Properties.Resources.ojoabierto, 40, 30);
            btnVerContraR.Text = ""; 
            btnVerContraR.ImageAlign = ContentAlignment.MiddleCenter;
            //Mostrar  imagen del ojo btnconfirmarcontra
           
            btnVerContraConfirmarR.Image = RedimensionarImagen(Properties.Resources.ojoabierto, 40, 30);
            btnVerContraConfirmarR.Text = "";
            btnVerContraConfirmarR.ImageAlign = ContentAlignment.MiddleCenter;

        }
        private Image RedimensionarImagen(Image img, int ancho, int alto)
        {
            Bitmap bmp = new Bitmap(ancho, alto);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(img, 0, 0, ancho, alto);
            }
            return bmp;
        }
        bool mostrarContra = false;
        private void btnVerContraR_Click(object sender, EventArgs e)
        {
            mostrarContra = !mostrarContra;
            txtContraseñaRe.UseSystemPasswordChar = !mostrarContra;
            if (mostrarContra)
            {
                btnVerContraR.Image = RedimensionarImagen(Properties.Resources.ojoabierto, 40, 30);
            }
            else
            {
                btnVerContraR.Image = RedimensionarImagen(Properties.Resources.ojoCerrado, 40, 30);
            }

        }

        private void btnVerContraConfirmarR_Click(object sender, EventArgs e)
        {
            mostrarContra = !mostrarContra;
            txtConfirmarContraseñaRe.UseSystemPasswordChar = !mostrarContra;
            if (mostrarContra)
            {
                btnVerContraConfirmarR.Image = RedimensionarImagen(Properties.Resources.ojoabierto, 40, 30);
            }
            else
            {
                btnVerContraConfirmarR.Image = RedimensionarImagen(Properties.Resources.ojoCerrado, 40, 30);
            }
        }
    }
}
