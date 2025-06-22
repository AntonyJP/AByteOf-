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
            // Conteo total de palabras en el estado global
            int totalPalabras = AppState.Palabras.Count;
            // Palabras que tienen estado 6 o más → consideradas aprendidas
            int palabrasAprendidas = AppState.Palabras.Count(p => p.Estado >= 6);
            // Palabras en proceso de aprendizaje (entre 3 y 5 inclusive)
            int palabrasEnAprendizaje = AppState.Palabras.Count(p => p.Estado >= 3 && p.Estado <= 5);
            // Palabras nuevas o sin haber comenzado a estudiar (estado menor a 3)
            int palabrasNoIniciadas = AppState.Palabras.Count(p => p.Estado < 3);
            // Mostrar estadísticas en etiquetas (labels)
            lblTotal.Text = $"Total de palabras: {totalPalabras}";
            lblDominadas.Text = $"Palabras dominadas: {palabrasAprendidas}";
            lblPorPracticar.Text = $"Palabras por practicar: {palabrasEnAprendizaje}";
            lblPorcentaje.Text = $"Porcentaje de palabras dominadas: {(double)palabrasAprendidas / totalPalabras * 100:F2}%";

            pgbProgreso.Value = (int)((palabrasAprendidas / 150.0) * 100);

            dgvProgreso.AutoGenerateColumns = false;
            dgvProgreso.Columns.Clear();
            // Agregar y configurar columnas
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
            // Hacer todas las columnas de solo lectura
            foreach (DataGridViewColumn column in dgvProgreso.Columns)
            {
                column.ReadOnly = true;
            }
            // Mostrar solo las palabras aprendidas (Estado >= 6) en la tabla
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
