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
            dgvPalabras.AutoGenerateColumns = false;
            dgvPalabras.Columns.Clear();

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

            foreach (DataGridViewColumn column in dgvPalabras.Columns)
            {
                column.ReadOnly = true;
            }

            CargarDatos();
        }

        private void CargarDatos(string filtro = "")
        {
            var palabrasFiltradas = string.IsNullOrWhiteSpace(filtro)
            ? AppState.Palabras
            : AppState.Palabras.Where(p => p.Significado.ToLower().Contains(filtro.ToLower()));

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

        private void txtPalabraAFiltrar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtPalabraAFiltrar.Text;
            CargarDatos(filtro);
        }
    }
}
