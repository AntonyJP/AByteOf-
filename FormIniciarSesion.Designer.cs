namespace AByteOf熊猫
{
    partial class FormIniciarSesion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIniciarSesion));
            label1 = new Label();
            btnRegresarI = new Button();
            label2 = new Label();
            txtUsuarioOCorreoi = new TextBox();
            txtContraseñai = new TextBox();
            label3 = new Label();
            btnIniciarCuentaApp = new Button();
            btnVerContrai = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(134, 103);
            label1.Name = "label1";
            label1.Size = new Size(302, 38);
            label1.TabIndex = 0;
            label1.Text = "Cuenta A Byte Of 熊猫";
            // 
            // btnRegresarI
            // 
            btnRegresarI.Location = new Point(48, 616);
            btnRegresarI.Name = "btnRegresarI";
            btnRegresarI.Size = new Size(112, 41);
            btnRegresarI.TabIndex = 1;
            btnRegresarI.Text = "Regresar";
            btnRegresarI.UseVisualStyleBackColor = true;
            btnRegresarI.Click += btnRegresarI_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(203, 200);
            label2.Name = "label2";
            label2.Size = new Size(160, 23);
            label2.TabIndex = 2;
            label2.Text = "Usuario o Correo ";
            // 
            // txtUsuarioOCorreoi
            // 
            txtUsuarioOCorreoi.BorderStyle = BorderStyle.FixedSingle;
            txtUsuarioOCorreoi.ForeColor = SystemColors.InactiveCaptionText;
            txtUsuarioOCorreoi.Location = new Point(134, 228);
            txtUsuarioOCorreoi.Name = "txtUsuarioOCorreoi";
            txtUsuarioOCorreoi.Size = new Size(272, 27);
            txtUsuarioOCorreoi.TabIndex = 3;
            // 
            // txtContraseñai
            // 
            txtContraseñai.BorderStyle = BorderStyle.FixedSingle;
            txtContraseñai.Location = new Point(134, 323);
            txtContraseñai.Name = "txtContraseñai";
            txtContraseñai.Size = new Size(272, 27);
            txtContraseñai.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(215, 295);
            label3.Name = "label3";
            label3.Size = new Size(129, 23);
            label3.TabIndex = 2;
            label3.Text = "Tu contraseña";
            // 
            // btnIniciarCuentaApp
            // 
            btnIniciarCuentaApp.BackColor = Color.Transparent;
            btnIniciarCuentaApp.BackgroundImage = (Image)resources.GetObject("btnIniciarCuentaApp.BackgroundImage");
            btnIniciarCuentaApp.BackgroundImageLayout = ImageLayout.Zoom;
            btnIniciarCuentaApp.ForeColor = Color.Transparent;
            btnIniciarCuentaApp.Location = new Point(368, 608);
            btnIniciarCuentaApp.Name = "btnIniciarCuentaApp";
            btnIniciarCuentaApp.Size = new Size(83, 56);
            btnIniciarCuentaApp.TabIndex = 5;
            btnIniciarCuentaApp.UseVisualStyleBackColor = false;
            btnIniciarCuentaApp.Click += btnIniciarCuentaApp_Click;
            // 
            // btnVerContrai
            // 
            btnVerContrai.BackColor = Color.FromArgb(125, 250, 90);
            btnVerContrai.BackgroundImageLayout = ImageLayout.Zoom;
            btnVerContrai.FlatStyle = FlatStyle.Flat;
            btnVerContrai.ForeColor = Color.Transparent;
            btnVerContrai.Location = new Point(419, 325);
            btnVerContrai.Name = "btnVerContrai";
            btnVerContrai.Size = new Size(40, 30);
            btnVerContrai.TabIndex = 6;
            btnVerContrai.UseVisualStyleBackColor = false;
            btnVerContrai.Click += btnVerContrai_Click;
            // 
            // FormIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(125, 250, 90);
            ClientSize = new Size(514, 733);
            Controls.Add(btnVerContrai);
            Controls.Add(btnIniciarCuentaApp);
            Controls.Add(txtContraseñai);
            Controls.Add(txtUsuarioOCorreoi);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegresarI);
            Controls.Add(label1);
            ForeColor = Color.Black;
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIniciarSesion";
            Text = "FormIniciarSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegresarI;
        private Label label2;
        private TextBox txtUsuarioOCorreoi;
        private TextBox txtContraseñai;
        private Label label3;
        private Button btnIniciarCuentaApp;
        private Button btnVerContrai;
    }
}