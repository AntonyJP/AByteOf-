namespace AByteOf熊猫
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            string rutaLogo = Path.Combine(Application.StartupPath, "Assets", "A byte of.png");
            pcbLogo .Image = Image.FromFile(rutaLogo);
            pgbLoading.Value = 0;
            tmrLoading.Start();
        }

        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            pgbLoading.Value += 1;
            if (pgbLoading.Value >= pgbLoading.Maximum)
            {
                tmrLoading.Stop();
                this.Hide();
                Log_in loginForm = new Log_in();
                loginForm.ShowDialog();
                
                
            }
        }
    }
}
