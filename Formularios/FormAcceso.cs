using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using AByteOf熊猫.Models;

namespace AByteOf熊猫
{
    public partial class FormAcceso : Form
    {
        private int idUsuario;

        // Constructor que recibe el ID del usuario que inició sesión
        public FormAcceso(int idUsuario)
        {
            InitializeComponent();
            // Cargar el logo desde la carpeta Assets
            string rutaLogo = Path.Combine(Application.StartupPath, "Assets", "A byte of.png");
            pcbLogo.Image = Image.FromFile(rutaLogo);
            // Guardar ID de usuario y asignarlo a AppState (estado global)
            this.idUsuario = idUsuario;
            AppState.IdUsuario = idUsuario;
           
            CargarOCrearProgreso();
            CargarForm2parte(new FormMenuLearn());

        }
        // Método para cargar un formulario hijo en el panel (panelMenu2)
        public void CargarForm2parte(object formHijo2)
        {
            // Quitar cualquier formulario ya cargado en el panel
            if (this.panelMenu2.Controls.Count > 0)
                this.panelMenu2.Controls.RemoveAt(0);
            // Convierte el objeto a Form, lo configura para que se acople al panel
            Form j = formHijo2 as Form;
            j.TopLevel = false;
            j.Dock = DockStyle.Fill;
            this.panelMenu2.Controls.Add(j);
            this.panelMenu2.Tag = j;
            j.Show();
        }
        // Carga el progreso del usuario desde XML o lo crea si no existe
        private void CargarOCrearProgreso()
        {
            // Rutas de los archivos XML
            string PathBase = Path.Combine(Application.StartupPath, "Recursos", "HSK1.xml");
            string PathUsuario = Path.Combine(Application.StartupPath, "ProgresoUsuarios", $"Usuario_{idUsuario}.xml");
            // Asegurarse que exista la carpeta donde se guardarán los progresos
            Directory.CreateDirectory(Path.Combine(Application.StartupPath, "ProgresoUsuarios"));

            if (!File.Exists(PathUsuario))
            {
                XDocument baseDoc = XDocument.Load(PathBase);
                // Crear un nuevo XML con nodos que copian cada palabra del archivo base
                var nuevasPalabras = new XElement("ProgresoUsuario",
                    new XAttribute("IdUsuario", idUsuario),
                    from pal in baseDoc.Descendants("Palabra")
                    select new XElement("Palabra",
                    new XElement("IdPalabra", pal.Element("IdPalabra").Value),
                    new XElement("Caracter", pal.Element("Caracter").Value),
                    new XElement("Pinyin", pal.Element("Pinyin")?.Value ?? ""),
                    new XElement("Significado", pal.Element("Significado").Value),
                    new XElement("Estado", 0),
                    new XElement("VecesCorrectas", 0),
                    new XElement("Actividad", pal.Element("Actividad1")?.Value ?? "")
                    )
                );
                nuevasPalabras.Save(PathUsuario);
            }

            XDocument userDoc = XDocument.Load(PathUsuario);
            // Cargar las palabras a una lista global (AppState) usando LINQ
            AppState.Palabras = (from pal in userDoc.Descendants("Palabra")
                                select new Palabra
                                {
                                    IdPalabra = int.Parse(pal.Element("IdPalabra").Value),
                                    Caracter = pal.Element("Caracter").Value,
                                    Pinyin = pal.Element("Pinyin")?.Value ?? "",
                                    Significado = pal.Element("Significado").Value,
                                    Estado = int.Parse(pal.Element("Estado").Value),
                                    VecesCorrectas = int.Parse(pal.Element("VecesCorrectas").Value),
                                    Actividad = pal.Element("Actividad").Value
                                }).ToList();
            MessageBox.Show($"Palabras cargadas: {AppState.Palabras.Count}");
        }
        // Guarda el progreso actual del usuario en su archivo XML
        public void GuardarProgreso()
        {
            string userPath = Path.Combine(Application.StartupPath, "ProgresoUsuarios", $"Usuario_{idUsuario}.xml");

            try
            {
                if (AppState.Palabras == null || !AppState.Palabras.Any())
                {
                    MessageBox.Show("No hay palabras para guardar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                // Crear el documento XML con los datos actuales del usuario
                var doc = new XDocument(
                    new XElement("ProgresoUsuario",
                        new XAttribute("IdUsuario", idUsuario),
                        from pal in AppState.Palabras
                        select new XElement("Palabra",
                            new XElement("IdPalabra", pal.IdPalabra),
                            new XElement("Caracter", pal.Caracter),
                            new XElement("Pinyin", pal.Pinyin),
                            new XElement("Significado", pal.Significado),
                            new XElement("Estado", pal.Estado),
                            new XElement("VecesCorrectas", pal.VecesCorrectas),
                            new XElement("Actividad", pal.Actividad)
                        )
                    )
                );
                doc.Save(userPath);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el progreso: {ex.Message}\nStackTrace: {ex.StackTrace}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnVocabulario_Click(object sender, EventArgs e)
        {
            CargarForm2parte(new FormVocabulario());
        }

        private void btnPruebas_Click(object sender, EventArgs e)
        {
            CargarForm2parte(new FormSeleccionModo());
        }

        private void btnProgreso_Click(object sender, EventArgs e)
        {
            CargarForm2parte(new FormProgreso());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void picLogoMenu_Click(object sender, EventArgs e)
        {
            CargarForm2parte(new FormMenuLearn());
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Estás seguro de que deseas cerrar sesión?",
            "Confirma el cierre de sesion",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Log_in formLog = new Log_in();
                formLog.Show();
                this.Close();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            GuardarProgreso();
            base.OnFormClosing(e);
        }

        private void FormAcceso_Load(object sender, EventArgs e)
        {

        }
    }
}
