namespace AByteOf熊猫
{
    public partial class SplashScreen : Form
    {
        private int progreso = 0;
        private int cambioTexto = 0;
        private bool esHola = true;
        public SplashScreen()
        {
            InitializeComponent();
            string rutaLogo = Path.Combine(Application.StartupPath, "Assets", "A byte of.png");
            pcbLogo.Image = Image.FromFile(rutaLogo);
            pgbLoading.Value = 0;
            lblTextHello.Text = "Hola";
            tmrLoading.Start();
            tmrText.Start();
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

        private void tmrText_Tick(object sender, EventArgs e)
        {
            if (esHola)
            {
                lblTextHello.Text = "你好";
            }
            else
            {
                lblTextHello.Text = "Hola";
            }
            esHola = !esHola;
            cambioTexto++;

            if (cambioTexto >= 10)
            {
                tmrText.Stop();
            }
        }
    }
}
