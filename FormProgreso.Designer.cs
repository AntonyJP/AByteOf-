namespace AByteOf熊猫
{
    partial class FormProgreso
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
            lblTotal = new Label();
            lblDominadas = new Label();
            lblPorPracticar = new Label();
            lblPorcentaje = new Label();
            dgvProgreso = new DataGridView();
            pgbProgreso = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)dgvProgreso).BeginInit();
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(68, 9);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(38, 15);
            lblTotal.TabIndex = 0;
            lblTotal.Text = "label1";
            // 
            // lblDominadas
            // 
            lblDominadas.AutoSize = true;
            lblDominadas.Location = new Point(68, 34);
            lblDominadas.Name = "lblDominadas";
            lblDominadas.Size = new Size(38, 15);
            lblDominadas.TabIndex = 0;
            lblDominadas.Text = "label1";
            // 
            // lblPorPracticar
            // 
            lblPorPracticar.AutoSize = true;
            lblPorPracticar.Location = new Point(68, 59);
            lblPorPracticar.Name = "lblPorPracticar";
            lblPorPracticar.Size = new Size(38, 15);
            lblPorPracticar.TabIndex = 0;
            lblPorPracticar.Text = "label1";
            // 
            // lblPorcentaje
            // 
            lblPorcentaje.AutoSize = true;
            lblPorcentaje.Location = new Point(68, 85);
            lblPorcentaje.Name = "lblPorcentaje";
            lblPorcentaje.Size = new Size(38, 15);
            lblPorcentaje.TabIndex = 0;
            lblPorcentaje.Text = "label1";
            // 
            // dgvProgreso
            // 
            dgvProgreso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProgreso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProgreso.Location = new Point(33, 166);
            dgvProgreso.Name = "dgvProgreso";
            dgvProgreso.Size = new Size(652, 250);
            dgvProgreso.TabIndex = 1;
            // 
            // pgbProgreso
            // 
            pgbProgreso.Location = new Point(92, 137);
            pgbProgreso.Name = "pgbProgreso";
            pgbProgreso.Size = new Size(550, 23);
            pgbProgreso.TabIndex = 2;
            // 
            // FormProgreso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 446);
            Controls.Add(pgbProgreso);
            Controls.Add(dgvProgreso);
            Controls.Add(lblPorcentaje);
            Controls.Add(lblPorPracticar);
            Controls.Add(lblDominadas);
            Controls.Add(lblTotal);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormProgreso";
            Text = "FormProgreso";
            Load += FormProgreso_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProgreso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblDominadas;
        private Label lblPorPracticar;
        private Label lblPorcentaje;
        private DataGridView dgvProgreso;
        private ProgressBar pgbProgreso;
    }
}