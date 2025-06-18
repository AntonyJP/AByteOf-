namespace AByteOf熊猫
{
    partial class FormRegistrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegistrarse));
            label1 = new Label();
            btnRegresarR = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtUsuarioRe = new TextBox();
            txtCorreoRe = new TextBox();
            txtContraseñaRe = new TextBox();
            txtConfirmarContraseñaRe = new TextBox();
            btnRegistrarCuentaApp = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 9);
            label1.Name = "label1";
            label1.Size = new Size(405, 38);
            label1.TabIndex = 0;
            label1.Text = " Crea tu cuenta A Byte Of 熊猫";
            // 
            // btnRegresarR
            // 
            btnRegresarR.Location = new Point(64, 364);
            btnRegresarR.Name = "btnRegresarR";
            btnRegresarR.Size = new Size(92, 43);
            btnRegresarR.TabIndex = 1;
            btnRegresarR.Text = "Regresar";
            btnRegresarR.UseVisualStyleBackColor = true;
            btnRegresarR.Click += btnRegresarR_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(323, 69);
            label2.Name = "label2";
            label2.Size = new Size(90, 25);
            label2.TabIndex = 2;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(323, 137);
            label3.Name = "label3";
            label3.Size = new Size(84, 25);
            label3.TabIndex = 2;
            label3.Text = "Correo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(302, 207);
            label4.Name = "label4";
            label4.Size = new Size(129, 25);
            label4.TabIndex = 2;
            label4.Text = "Contraseña";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(251, 274);
            label5.Name = "label5";
            label5.Size = new Size(241, 25);
            label5.TabIndex = 2;
            label5.Text = "Confirmar Contraseña";
            // 
            // txtUsuarioRe
            // 
            txtUsuarioRe.BorderStyle = BorderStyle.FixedSingle;
            txtUsuarioRe.Location = new Point(251, 97);
            txtUsuarioRe.Name = "txtUsuarioRe";
            txtUsuarioRe.Size = new Size(235, 27);
            txtUsuarioRe.TabIndex = 3;
            // 
            // txtCorreoRe
            // 
            txtCorreoRe.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoRe.Location = new Point(251, 165);
            txtCorreoRe.Name = "txtCorreoRe";
            txtCorreoRe.Size = new Size(235, 27);
            txtCorreoRe.TabIndex = 3;
            // 
            // txtContraseñaRe
            // 
            txtContraseñaRe.BorderStyle = BorderStyle.FixedSingle;
            txtContraseñaRe.Location = new Point(251, 235);
            txtContraseñaRe.Name = "txtContraseñaRe";
            txtContraseñaRe.Size = new Size(235, 27);
            txtContraseñaRe.TabIndex = 3;
            // 
            // txtConfirmarContraseñaRe
            // 
            txtConfirmarContraseñaRe.BorderStyle = BorderStyle.FixedSingle;
            txtConfirmarContraseñaRe.Location = new Point(251, 316);
            txtConfirmarContraseñaRe.Name = "txtConfirmarContraseñaRe";
            txtConfirmarContraseñaRe.Size = new Size(235, 27);
            txtConfirmarContraseñaRe.TabIndex = 3;
            // 
            // btnRegistrarCuentaApp
            // 
            btnRegistrarCuentaApp.BackColor = Color.Transparent;
            btnRegistrarCuentaApp.BackgroundImage = (Image)resources.GetObject("btnRegistrarCuentaApp.BackgroundImage");
            btnRegistrarCuentaApp.BackgroundImageLayout = ImageLayout.Zoom;
            btnRegistrarCuentaApp.ForeColor = Color.Transparent;
            btnRegistrarCuentaApp.Location = new Point(658, 351);
            btnRegistrarCuentaApp.Name = "btnRegistrarCuentaApp";
            btnRegistrarCuentaApp.Size = new Size(83, 56);
            btnRegistrarCuentaApp.TabIndex = 6;
            btnRegistrarCuentaApp.UseVisualStyleBackColor = false;
            // 
            // FormRegistrarse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarCuentaApp);
            Controls.Add(txtConfirmarContraseñaRe);
            Controls.Add(txtContraseñaRe);
            Controls.Add(txtCorreoRe);
            Controls.Add(txtUsuarioRe);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnRegresarR);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarse";
            Text = "FormRegistrarse";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegresarR;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtUsuarioRe;
        private TextBox txtCorreoRe;
        private TextBox txtContraseñaRe;
        private TextBox txtConfirmarContraseñaRe;
        private Button btnRegistrarCuentaApp;
    }
}