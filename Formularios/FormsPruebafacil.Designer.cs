namespace AByteOf熊猫
{
    partial class FormsPruebafacil
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
            lblPregunta = new Label();
            txtRespuesta = new TextBox();
            btnEnviar = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblPregunta
            // 
            lblPregunta.AutoSize = true;
            lblPregunta.Font = new Font("Noto Sans SC Medium", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPregunta.Location = new Point(138, 41);
            lblPregunta.Name = "lblPregunta";
            lblPregunta.Size = new Size(74, 30);
            lblPregunta.TabIndex = 0;
            lblPregunta.Text = "label1";
            lblPregunta.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtRespuesta
            // 
            txtRespuesta.Location = new Point(199, 125);
            txtRespuesta.Name = "txtRespuesta";
            txtRespuesta.Size = new Size(324, 23);
            txtRespuesta.TabIndex = 1;
            // 
            // btnEnviar
            // 
            btnEnviar.Location = new Point(441, 210);
            btnEnviar.Name = "btnEnviar";
            btnEnviar.Size = new Size(82, 35);
            btnEnviar.TabIndex = 3;
            btnEnviar.Text = "Enviar";
            btnEnviar.UseVisualStyleBackColor = true;
            btnEnviar.Click += btnEnviar_Click;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(33, 411);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 23);
            btnBack.TabIndex = 4;
            btnBack.Text = "Regresar";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // FormsPruebafacil
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(713, 446);
            Controls.Add(btnBack);
            Controls.Add(btnEnviar);
            Controls.Add(txtRespuesta);
            Controls.Add(lblPregunta);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormsPruebafacil";
            Text = "FormsPruebas";
            Load += FormsPruebas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPregunta;
        private TextBox txtRespuesta;
        private Button btnEnviar;
        private Button btnBack;
    }
}