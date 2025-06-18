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
            label1 = new Label();
            btnRegresarR = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(239, 83);
            label1.Name = "label1";
            label1.Size = new Size(190, 38);
            label1.TabIndex = 0;
            label1.Text = "REGISTRARSE";
            // 
            // btnRegresarR
            // 
            btnRegresarR.Location = new Point(263, 274);
            btnRegresarR.Name = "btnRegresarR";
            btnRegresarR.Size = new Size(121, 56);
            btnRegresarR.TabIndex = 1;
            btnRegresarR.Text = "Regresar";
            btnRegresarR.UseVisualStyleBackColor = true;
            btnRegresarR.Click += btnRegresarR_Click;
            // 
            // FormRegistrarse
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}