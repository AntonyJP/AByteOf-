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

namespace AByteOf熊猫
{
    public partial class FormRegistrarse : Form
    {
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7249/api/Users") };
        private Log_in formPrincipal;
        public FormRegistrarse(Log_in form)
        {
            InitializeComponent();
            formPrincipal = form;
        }

        private void btnRegresarR_Click(object sender, EventArgs e)
        {
            formPrincipal.CargarForm(new FormInicio(formPrincipal));
        }

        private async void btnRegistrarCuentaApp_Click(object sender, EventArgs e)
        {
            // Validar que los campos no estén vacíos
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

            // Crear el modelo para el registro
            var registerModel = new
            {
                Name = txtUsuarioRe.Text, // Usando "Usuario" como nombre
                Email = txtCorreoRe.Text,
                Password = txtContraseñaRe.Text,
                ConfirmPassword = txtConfirmarContraseñaRe.Text
            };

            try
            {
                // Serializar el modelo a JSON
                var jsonContent = new StringContent(
                    JsonConvert.SerializeObject(registerModel),
                    Encoding.UTF8,
                    "application/json"
                );

                // Enviar la solicitud a la API
                var response = await client.PostAsync("api/users/register", jsonContent);
                var responseContent = await response.Content.ReadAsStringAsync();

                // Mostrar el resultado
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
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        bool mostrarContra = false;
        private void btnVerContraR_Click(object sender, EventArgs e)
        {
            mostrarContra = !mostrarContra;
            txtContraseñaRe.UseSystemPasswordChar = !mostrarContra;
            if (mostrarContra)
            {
                btnVerContraR.Image = Properties.Resources.ojoabierto;
            }
            else
            {
                btnVerContraR.Image = Properties.Resources.ojoCerrado;
            }

        }

        private void btnVerContraConfirmarR_Click(object sender, EventArgs e)
        {
            mostrarContra = !mostrarContra;
            txtConfirmarContraseñaRe.UseSystemPasswordChar = !mostrarContra;
            if (mostrarContra)
            {
                btnVerContraConfirmarR.Image = Properties.Resources.ojoabierto;
            }
            else
            {
                btnVerContraConfirmarR.Image = Properties.Resources.ojoCerrado;
            }
        }
    }
}
