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
            panel1 = new Panel();
            pcbLogo = new PictureBox();
            panel2 = new Panel();
            btnClose = new Button();
            panelMenu = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcbLogo).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(pcbLogo);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 25);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(450, 525);
            panel1.TabIndex = 0;
            // 
            // pcbLogo
            // 
            pcbLogo.Location = new Point(-57, 4);
            pcbLogo.Margin = new Padding(3, 2, 3, 2);
            pcbLogo.Name = "pcbLogo";
            pcbLogo.Size = new Size(560, 463);
            pcbLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pcbLogo.TabIndex = 0;
            pcbLogo.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Top;
            panel2.ImeMode = ImeMode.NoControl;
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 25);
            panel2.TabIndex = 1;
            // 
            // btnClose
            // 
            btnClose.BackColor = Color.Transparent;
            btnClose.Location = new Point(866, 2);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(34, 18);
            btnClose.TabIndex = 0;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = false;
            btnClose.Click += btnClose_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.Lime;
            panelMenu.Dock = DockStyle.Right;
            panelMenu.Location = new Point(450, 25);
            panelMenu.Margin = new Padding(3, 2, 3, 2);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(450, 525);
            panelMenu.TabIndex = 2;
            // 
            // Log_in
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 550);
            Controls.Add(panelMenu);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Log_in";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Log_in";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pcbLogo).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panelMenu;
        private PictureBox pcbLogo;
        private Button btnClose;
    }
}