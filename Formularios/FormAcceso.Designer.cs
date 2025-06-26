namespace AByteOf熊猫
{
    partial class FormAcceso
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
            panelBotones = new Panel();
            btnCerrarSesion = new Button();
            btnProgreso = new Button();
            btnPruebas = new Button();
            btnVocabulario = new Button();
            pcbLogo = new PictureBox();
            panelMenu2 = new Panel();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.White;
            panelBotones.Controls.Add(btnCerrarSesion);
            panelBotones.Controls.Add(btnProgreso);
            panelBotones.Controls.Add(btnPruebas);
            panelBotones.Controls.Add(btnVocabulario);
            panelBotones.Dock = DockStyle.Left;
            panelBotones.Location = new Point(0, 0);
            panelBotones.Margin = new Padding(3, 2, 3, 2);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(221, 446);
            panelBotones.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.FromArgb(128, 255, 128);
            btnCerrarSesion.Location = new Point(47, 409);
            btnCerrarSesion.Margin = new Padding(3, 2, 3, 2);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(130, 26);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // btnProgreso
            // 
            btnProgreso.BackColor = Color.FromArgb(128, 255, 128);
            btnProgreso.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProgreso.Location = new Point(0, 126);
            btnProgreso.Margin = new Padding(3, 2, 3, 2);
            btnProgreso.Name = "btnProgreso";
            btnProgreso.Size = new Size(221, 54);
            btnProgreso.TabIndex = 0;
            btnProgreso.Text = "PROGRESO";
            btnProgreso.UseVisualStyleBackColor = false;
            btnProgreso.Click += btnProgreso_Click;
            // 
            // btnPruebas
            // 
            btnPruebas.BackColor = Color.FromArgb(128, 255, 128);
            btnPruebas.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPruebas.Location = new Point(0, 68);
            btnPruebas.Margin = new Padding(3, 2, 3, 2);
            btnPruebas.Name = "btnPruebas";
            btnPruebas.Size = new Size(221, 54);
            btnPruebas.TabIndex = 0;
            btnPruebas.Text = "PRUEBAS";
            btnPruebas.UseVisualStyleBackColor = false;
            btnPruebas.Click += btnPruebas_Click;
            // 
            // btnVocabulario
            // 
            btnVocabulario.BackColor = Color.FromArgb(128, 255, 128);
            btnVocabulario.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVocabulario.Location = new Point(0, 9);
            btnVocabulario.Margin = new Padding(3, 2, 3, 2);
            btnVocabulario.Name = "btnVocabulario";
            btnVocabulario.Size = new Size(221, 54);
            btnVocabulario.TabIndex = 0;
            btnVocabulario.Text = "VOCABULARIO";
            btnVocabulario.UseVisualStyleBackColor = false;
            btnVocabulario.Click += btnVocabulario_Click;
            // 
            // pcbLogo
            // 
            pcbLogo.BackColor = Color.White;
            pcbLogo.Location = new Point(0, 228);
            pcbLogo.Margin = new Padding(3, 2, 3, 2);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(221, 166);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 2;
            pcbLogo.TabStop = false;
            pcbLogo.Click += picLogoMenu_Click;
            // 
            // panelMenu2
            // 
            panelMenu2.BackColor = Color.White;
            panelMenu2.Dock = DockStyle.Right;
            panelMenu2.Location = new Point(225, 0);
            panelMenu2.Margin = new Padding(3, 2, 3, 2);
            panelMenu2.Name = "panelMenu2";
            panelMenu2.Size = new Size(713, 446);
            panelMenu2.TabIndex = 1;
            // 
            // FormAcceso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(938, 446);
            Controls.Add(panelMenu2);
            Controls.Add(pcbLogo);
            Controls.Add(panelBotones);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAcceso";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormAcceso";
            Load += FormAcceso_Load;
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotones;
        private Button btnVocabulario;
        private Button btnProgreso;
        private Button btnPruebas;
        private Panel panelMenu2;
        private PictureBox pcbLogo;
        private Button btnCerrarSesion;
    }
}