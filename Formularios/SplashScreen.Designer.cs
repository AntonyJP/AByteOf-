namespace AByteOf熊猫
{
    partial class SplashScreen
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pcbLogo = new PictureBox();
            lblTextHello = new Label();
            pgbLoading = new ProgressBar();
            tmrLoading = new System.Windows.Forms.Timer(components);
            tmrText = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // pcbLogo
            // 
            pcbLogo.Location = new Point(-21, 17);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(515, 455);
            pcbLogo.SizeMode = PictureBoxSizeMode.Zoom;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblTextHello
            // 
            lblTextHello.AutoSize = true;
            lblTextHello.Font = new Font("Gill Sans Ultra Bold Condensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextHello.ForeColor = Color.Gray;
            lblTextHello.Location = new Point(450, 206);
            lblTextHello.Name = "lblTextHello";
            lblTextHello.Size = new Size(121, 67);
            lblTextHello.TabIndex = 1;
            lblTextHello.Text = "Hola";
            // 
            // pgbLoading
            // 
            pgbLoading.Dock = DockStyle.Bottom;
            pgbLoading.ForeColor = Color.Aquamarine;
            pgbLoading.Location = new Point(0, 495);
            pgbLoading.Name = "pgbLoading";
            pgbLoading.Size = new Size(700, 5);
            pgbLoading.Style = ProgressBarStyle.Continuous;
            pgbLoading.TabIndex = 3;
            // 
            // tmrLoading
            // 
            tmrLoading.Interval = 50;
            tmrLoading.Tick += tmrLoading_Tick;
            // 
            // tmrText
            // 
            tmrText.Interval = 2000;
            tmrText.Tick += tmrText_Tick;
            // 
            // SplashScreen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(700, 500);
            Controls.Add(pgbLoading);
            Controls.Add(lblTextHello);
            Controls.Add(pcbLogo);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SplashScreen";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SplashScreen";
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pcbLogo;
        private Label lblTextHello;
        private ProgressBar pgbLoading;
        private System.Windows.Forms.Timer tmrLoading;
        private System.Windows.Forms.Timer tmrText;
    }
}
