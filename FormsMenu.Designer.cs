namespace AByteOf熊猫
{
    partial class FormsMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormsMenu));
            btnInciarSesion = new Button();
            btnRegistrarse = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // btnInciarSesion
            // 
            btnInciarSesion.Location = new Point(308, 196);
            btnInciarSesion.Name = "btnInciarSesion";
            btnInciarSesion.Size = new Size(180, 42);
            btnInciarSesion.TabIndex = 0;
            btnInciarSesion.Text = "INICIAR SESION";
            btnInciarSesion.UseVisualStyleBackColor = true;
            btnInciarSesion.Click += btnInciarSesion_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.Location = new Point(308, 282);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(180, 40);
            btnRegistrarse.TabIndex = 0;
            btnRegistrarse.Text = "REGISTRARSE";
            btnRegistrarse.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(357, 110);
            label1.Name = "label1";
            label1.Size = new Size(72, 20);
            label1.TabIndex = 1;
            label1.Text = "Wolcome";
            // 
            // FormsMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnInciarSesion);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormsMenu";
            Text = "FormsMenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInciarSesion;
        private Button btnRegistrarse;
        private Label label1;
    }
}