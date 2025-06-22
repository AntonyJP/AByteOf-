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
    public partial class FormVocabulario : Form
    {
        public FormVocabulario()
        {
            InitializeComponent();
        }

        private void FormVocabulario_Load(object sender, EventArgs e)
        {
            // Configuración del DataGridView manualmente 
            dgvPalabras.AutoGenerateColumns = false;
            dgvPalabras.Columns.Clear();
            // Se agregan las columnas que mostrarán los datos de las palabras
            dgvPalabras.Columns.Add("IdPalabra", "ID");
            dgvPalabras.Columns["IdPalabra"].DataPropertyName = "IdPalabra";
            dgvPalabras.Columns.Add("Caracter", "Caracter");
            dgvPalabras.Columns["Caracter"].DataPropertyName = "Caracter";
            dgvPalabras.Columns.Add("Pinyin", "Pinyin");
            dgvPalabras.Columns["Pinyin"].DataPropertyName = "Pinyin";
            dgvPalabras.Columns.Add("Significado", "Significado");
            dgvPalabras.Columns["Significado"].DataPropertyName = "Significado";
            dgvPalabras.Columns.Add("Estado", "Estado");
            dgvPalabras.Columns["Estado"].DataPropertyName = "Estado";
            dgvPalabras.Columns.Add("VecesCorrectas", "VecesCorrectas");
            dgvPalabras.Columns["VecesCorrectas"].DataPropertyName = "VecesCorrectas";
            dgvPalabras.Columns.Add("Actividad", "Actividad");
            dgvPalabras.Columns["Actividad"].DataPropertyName = "Actividad";
            dgvPalabras.Columns["Actividad"].Visible = false;
            // Todas las columnas son de solo lectura
            foreach (DataGridViewColumn column in dgvPalabras.Columns)
            {
                column.ReadOnly = true;
            }

            CargarDatos();
        }
        // Método para cargar las palabras al DataGridView, con filtro opcional
        private void CargarDatos(string filtro = "")
        {
            // Si el filtro está vacío, se muestran todas las palabras

            var palabrasFiltradas = string.IsNullOrWhiteSpace(filtro)
            ? AppState.Palabras
            : AppState.Palabras.Where(p => p.Significado.ToLower().Contains(filtro.ToLower()));
            // Se cargan los datos filtrados en la tabla
            dgvPalabras.DataSource = palabrasFiltradas.Select(p => new
            {
                IdPalabra = p.IdPalabra,
                Caracter = p.Caracter,
                Pinyin = p.Pinyin,
                Significado = p.Significado,
                Estado = p.Estado,
                VecesCorrectas = p.VecesCorrectas,
                Actividad = p.Actividad // Incluido pero oculto
            }).ToList();

            if (dgvPalabras.Columns["Actividad"] != null)
                dgvPalabras.Columns["Actividad"].Visible = false;
        }
        // Evento que se ejecuta cuando se escribe en el textbox de búsqueda
        private void txtPalabraAFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPalabraAFiltrar.Text;
            CargarDatos(filtro);//Filtra segun el texto ingresado
        }
    }
}
