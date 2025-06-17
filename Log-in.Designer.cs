namespace AByteOf熊猫
{
    partial class Log_in
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
            pnlMainHuWelcome = new Panel();
            flpMainHub = new FlowLayoutPanel();
            pcbLogo = new PictureBox();
            lblWelcome = new Label();
            pnlMainHuWelcome.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnlMainHuWelcome
            // 
            pnlMainHuWelcome.Controls.Add(lblWelcome);
            pnlMainHuWelcome.Controls.Add(pcbLogo);
            pnlMainHuWelcome.Dock = DockStyle.Left;
            pnlMainHuWelcome.Location = new Point(0, 0);
            pnlMainHuWelcome.Name = "pnlMainHuWelcome";
            pnlMainHuWelcome.Size = new Size(450, 650);
            pnlMainHuWelcome.TabIndex = 0;
            // 
            // flpMainHub
            // 
            flpMainHub.Dock = DockStyle.Right;
            flpMainHub.Location = new Point(450, 0);
            flpMainHub.Name = "flpMainHub";
            flpMainHub.Size = new Size(450, 650);
            flpMainHub.TabIndex = 1;
            // 
            // pcbLogo
            // 
            pcbLogo.Location = new Point(50, 70);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(349, 343);
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(200, 425);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 1;
            lblWelcome.Text = "label1";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Log_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 650);
            Controls.Add(flpMainHub);
            Controls.Add(pnlMainHuWelcome);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Log_in";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log_in";
            pnlMainHuWelcome.ResumeLayout(false);
            pnlMainHuWelcome.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMainHuWelcome;
        private Label lblWelcome;
        private PictureBox pcbLogo;
        private FlowLayoutPanel flpMainHub;
    }
}