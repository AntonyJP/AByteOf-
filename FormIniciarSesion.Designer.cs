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
            label1 = new Label();
            btnRegresarI = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(263, 97);
            label1.Name = "label1";
            label1.Size = new Size(218, 38);
            label1.TabIndex = 0;
            label1.Text = "INICIAR SESION";
            // 
            // btnRegresarI
            // 
            btnRegresarI.Location = new Point(190, 306);
            btnRegresarI.Name = "btnRegresarI";
            btnRegresarI.Size = new Size(112, 41);
            btnRegresarI.TabIndex = 1;
            btnRegresarI.Text = "Regresar";
            btnRegresarI.UseVisualStyleBackColor = true;
            btnRegresarI.Click += btnRegresarI_Click;
            // 
            // FormIniciarSesion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegresarI);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormIniciarSesion";
            Text = "FormIniciarSesion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnRegresarI;
    }
}