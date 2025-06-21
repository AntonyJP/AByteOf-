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
            this.Load += FormRegistrarse_Load;
        }
        private void FormRegistrarse_Load(object sender, EventArgs e)
        {
            // Mostrar la imagen del ojo btncontra

            btnVerContrai.Image = RedimensionarImagen(Properties.Resources.ojoabierto, 40, 30);
            btnVerContrai.Text = "";
            btnVerContrai.ImageAlign = ContentAlignment.MiddleCenter;
            
            

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
                btnVerContrai.Image = RedimensionarImagen(Properties.Resources.ojoabierto, 40, 30);
            }
            else
            {
                btnVerContrai.Image = RedimensionarImagen(Properties.Resources.ojoCerrado, 40, 30);
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

        var response = await client.PostAsync("api/users/login", jsonContent);
        var responseContent = await response.Content.ReadAsStringAsync();

        MessageBox.Show($"Código de estado: {(int)response.StatusCode}\nRespuesta: {responseContent}", "Depuración");

        if (response.IsSuccessStatusCode)
        {
            // Parsear la respuesta JSON
            dynamic responseObject = JsonConvert.DeserializeObject(responseContent);
            string message = responseObject.message;
            int idUsuario = responseObject.idUsuario;

            // Almacenar el idUsuario en AppState
            AppState.IdUsuario = idUsuario;

            MessageBox.Show($"{message} (ID: {idUsuario})", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Abrir FormAcceso pasando el idUsuario
            FormAcceso formAcceso = new FormAcceso(idUsuario); // Ajustar el constructor de FormAcceso
            formAcceso.Show();
            this.Close();
            if (formPrincipal != null) formPrincipal.Close(); // Opcional: cerrar el formulario padre
        }
    }
    catch (Exception ex)
    {
        MessageBox.Show($"Error: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
        }
    }
}
