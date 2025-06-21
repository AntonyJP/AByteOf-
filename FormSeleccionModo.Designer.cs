namespace AByteOf熊猫
{
    partial class FormSeleccionModo
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
            btnAprenderNuevasPalabras = new Button();
            btnReforzar = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // btnAprenderNuevasPalabras
            // 
            btnAprenderNuevasPalabras.BackColor = Color.FromArgb(128, 255, 128);
            btnAprenderNuevasPalabras.Location = new Point(269, 89);
            btnAprenderNuevasPalabras.Name = "btnAprenderNuevasPalabras";
            btnAprenderNuevasPalabras.Size = new Size(234, 79);
            btnAprenderNuevasPalabras.TabIndex = 0;
            btnAprenderNuevasPalabras.Text = "Nuevas Palabras";
            btnAprenderNuevasPalabras.UseVisualStyleBackColor = false;
            btnAprenderNuevasPalabras.Click += btnAprenderNuevasPalabras_Click;
            // 
            // btnReforzar
            // 
            btnReforzar.BackColor = Color.FromArgb(128, 255, 128);
            btnReforzar.Location = new Point(269, 241);
            btnReforzar.Name = "btnReforzar";
            btnReforzar.Size = new Size(234, 79);
            btnReforzar.TabIndex = 1;
            btnReforzar.Text = "Reforzamiento";
            btnReforzar.UseVisualStyleBackColor = false;
            btnReforzar.Click += btnReforzar_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(214, 380);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(38, 15);
            lblMensaje.TabIndex = 2;
            lblMensaje.Text = "label1";
            // 
            // FormSeleccionModo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblMensaje);
            Controls.Add(btnReforzar);
            Controls.Add(btnAprenderNuevasPalabras);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormSeleccionModo";
            Text = "FormSeleccionModo";
            Load += FormSeleccionModo_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAprenderNuevasPalabras;
        private Button btnReforzar;
        private Label lblMensaje;
    }
}