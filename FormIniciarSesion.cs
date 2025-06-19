using AByteOf熊猫.Models;
using Newtonsoft.Json;
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
        private static readonly HttpClient client = new HttpClient { BaseAddress = new Uri("https://localhost:7159/") };
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
               
            }
            else
            {
               
            }
        }

        private async void btnIniciarCuentaApp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsuarioOCorreoi.Text) || string.IsNullOrWhiteSpace(txtContraseñai.Text))
            {
                MessageBox.Show("El correo o usuario y la contraseña son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var usuario = new Usuarios
            {
                Correo = txtUsuarioOCorreoi.Text,
                Contrasena = txtContraseñai.Text
            };

            try
            {
                var jsonContent = new StringContent(
                    JsonConvert.SerializeObject(usuario),
                    Encoding.UTF8,
                    "application/json"
                );
                MessageBox.Show("JSON enviado: " + JsonConvert.SerializeObject(usuario), "Depuración");

                var response = await client.PostAsync("api/users/login", jsonContent);
                var responseContent = await response.Content.ReadAsStringAsync();

                MessageBox.Show($"Código de estado: {(int)response.StatusCode}\nRespuesta: {responseContent}", "Depuración");

                if (response.IsSuccessStatusCode)
                {
                    MessageBox.Show(responseContent, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FormAcceso formAcceso = new FormAcceso();
                    formAcceso.Show();
                    this.Close();
                    if (formPrincipal != null) formPrincipal.Close(); // Opcional: cerrar el formulario padre si es necesario
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
    }
}
