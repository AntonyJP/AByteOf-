namespace AByteOf熊猫
{
    partial class FormVocabulario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvPalabras = new DataGridView();
            lblIndicacion = new Label();
            txtPalabraAFiltrar = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvPalabras).BeginInit();
            SuspendLayout();
            // 
            // dgvPalabras
            // 
            dgvPalabras.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPalabras.Location = new Point(34, 64);
            dgvPalabras.Name = "dgvPalabras";
            dgvPalabras.Size = new Size(650, 348);
            dgvPalabras.TabIndex = 1;
            // 
            // lblIndicacion
            // 
            lblIndicacion.AutoSize = true;
            lblIndicacion.Location = new Point(203, 34);
            lblIndicacion.Name = "lblIndicacion";
            lblIndicacion.Size = new Size(41, 15);
            lblIndicacion.TabIndex = 2;
            lblIndicacion.Text = "Busca:";
            // 
            // txtPalabraAFiltrar
            // 
            txtPalabraAFiltrar.Location = new Point(276, 31);
            txtPalabraAFiltrar.Name = "txtPalabraAFiltrar";
            txtPalabraAFiltrar.Size = new Size(323, 23);
            txtPalabraAFiltrar.TabIndex = 3;
            txtPalabraAFiltrar.TextChanged += txtPalabraAFiltrar_TextChanged;
            // 
            // FormVocabulario
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 446);
            Controls.Add(txtPalabraAFiltrar);
            Controls.Add(lblIndicacion);
            Controls.Add(dgvPalabras);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormVocabulario";
            Text = "FormVocabulario";
            Load += FormVocabulario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPalabras).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvPalabras;
        private Label lblIndicacion;
        private TextBox txtPalabraAFiltrar;
    }
}