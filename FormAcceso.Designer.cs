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
            picLogoMenu = new PictureBox();
            btnProgreso = new Button();
            btnPruebas = new Button();
            btnVocabulario = new Button();
            panelMenu2 = new Panel();
            panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogoMenu).BeginInit();
            SuspendLayout();
            // 
            // panelBotones
            // 
            panelBotones.BackColor = Color.FromArgb(128, 255, 128);
            panelBotones.Controls.Add(btnCerrarSesion);
            panelBotones.Controls.Add(picLogoMenu);
            panelBotones.Controls.Add(btnProgreso);
            panelBotones.Controls.Add(btnPruebas);
            panelBotones.Controls.Add(btnVocabulario);
            panelBotones.Dock = DockStyle.Left;
            panelBotones.Location = new Point(0, 0);
            panelBotones.Name = "panelBotones";
            panelBotones.Size = new Size(253, 595);
            panelBotones.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.Location = new Point(0, 566);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(131, 29);
            btnCerrarSesion.TabIndex = 3;
            btnCerrarSesion.Text = "Cerrar Sesion";
            btnCerrarSesion.UseVisualStyleBackColor = true;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // picLogoMenu
            // 
            picLogoMenu.BackColor = Color.FromArgb(255, 128, 128);
            picLogoMenu.Location = new Point(47, 282);
            picLogoMenu.Name = "picLogoMenu";
            picLogoMenu.Size = new Size(152, 142);
            picLogoMenu.SizeMode = PictureBoxSizeMode.StretchImage;
            picLogoMenu.TabIndex = 2;
            picLogoMenu.TabStop = false;
            picLogoMenu.Click += picLogoMenu_Click;
            // 
            // btnProgreso
            // 
            btnProgreso.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProgreso.Location = new Point(0, 168);
            btnProgreso.Name = "btnProgreso";
            btnProgreso.Size = new Size(250, 72);
            btnProgreso.TabIndex = 0;
            btnProgreso.Text = "PROGRESO";
            btnProgreso.UseVisualStyleBackColor = true;
            btnProgreso.Click += btnProgreso_Click;
            // 
            // btnPruebas
            // 
            btnPruebas.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPruebas.Location = new Point(0, 90);
            btnPruebas.Name = "btnPruebas";
            btnPruebas.Size = new Size(250, 72);
            btnPruebas.TabIndex = 0;
            btnPruebas.Text = "PRUEBAS";
            btnPruebas.UseVisualStyleBackColor = true;
            btnPruebas.Click += btnPruebas_Click;
            // 
            // btnVocabulario
            // 
            btnVocabulario.Font = new Font("Times New Roman", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVocabulario.Location = new Point(0, 12);
            btnVocabulario.Name = "btnVocabulario";
            btnVocabulario.Size = new Size(250, 72);
            btnVocabulario.TabIndex = 0;
            btnVocabulario.Text = "VOCABULARIO";
            btnVocabulario.UseVisualStyleBackColor = true;
            btnVocabulario.Click += btnVocabulario_Click;
            // 
            // panelMenu2
            // 
            panelMenu2.Location = new Point(256, 0);
            panelMenu2.Name = "panelMenu2";
            panelMenu2.Size = new Size(815, 595);
            panelMenu2.TabIndex = 1;
            // 
            // FormAcceso
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 595);
            Controls.Add(panelMenu2);
            Controls.Add(panelBotones);
            Name = "FormAcceso";
            Text = "FormAcceso";
            panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picLogoMenu).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelBotones;
        private Button btnVocabulario;
        private Button btnProgreso;
        private Button btnPruebas;
        private Panel panelMenu2;
        private PictureBox picLogoMenu;
        private Button btnCerrarSesion;
    }
}