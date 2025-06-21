using System;
using System.Collections.Generic;
using AByteOf熊猫.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace AByteOf熊猫
{
    public partial class FormProgreso : Form
    {
        public FormProgreso()
        {
            InitializeComponent();
        }

        private void FormProgreso_Load(object sender, EventArgs e)
        {
            int totalPalabras = AppState.Palabras.Count;
            int palabrasAprendidas = AppState.Palabras.Count(p => p.Estado >= 6);
            int palabrasEnAprendizaje = AppState.Palabras.Count(p => p.Estado >= 3 && p.Estado <= 5);
            int palabrasNoIniciadas = AppState.Palabras.Count(p => p.Estado < 3);

            lblTotal.Text = $"Total de palabras: {totalPalabras}";
            lblDominadas.Text = $"Palabras dominadas: {palabrasAprendidas}";
            lblPorPracticar.Text = $"Palabras por practicar: {palabrasEnAprendizaje}";
            lblPorcentaje.Text = $"Porcentaje de palabras dominadas: {(double)palabrasAprendidas / totalPalabras * 100:F2}%";

            pgbProgreso.Value = (int)((palabrasAprendidas / 150.0) * 100);

            dgvProgreso.AutoGenerateColumns = false;
            dgvProgreso.Columns.Clear();

            dgvProgreso.Columns.Add("IdPalabra", "ID");
            dgvProgreso.Columns["IdPalabra"].DataPropertyName = "IdPalabra";
            dgvProgreso.Columns.Add("Caracter", "Caracter");
            dgvProgreso.Columns["Caracter"].DataPropertyName = "Caracter";
            dgvProgreso.Columns.Add("Pinyin", "Pinyin");
            dgvProgreso.Columns["Pinyin"].DataPropertyName = "Pinyin";
            dgvProgreso.Columns.Add("Significado", "Significado");
            dgvProgreso.Columns["Significado"].DataPropertyName = "Significado";
            dgvProgreso.Columns.Add("Estado", "Estado");
            dgvProgreso.Columns["Estado"].DataPropertyName = "Estado";
            dgvProgreso.Columns.Add("VecesCorrectas", "Veces Correctas");
            dgvProgreso.Columns["VecesCorrectas"].DataPropertyName = "VecesCorrectas";
            dgvProgreso.Columns.Add("Actividad", "Actividad");
            dgvProgreso.Columns["Actividad"].DataPropertyName = "Actividad";
            dgvProgreso.Columns["Actividad"].Visible = false;

            foreach (DataGridViewColumn column in dgvProgreso.Columns)
            {
                column.ReadOnly = true;
            }

            dgvProgreso.DataSource = AppState.Palabras.Where(p => p.Estado >= 6).Select(p => new
            {
                IdPalabra = p.IdPalabra,
                Caracter = p.Caracter,
                Pinyin = p.Pinyin,
                Significado = p.Significado,
                Estado = p.Estado,
                VecesCorrectas = p.VecesCorrectas,
                Actividad = p.Actividad
            }).ToList();
            dgvProgreso.Refresh();
        }
    }
}
