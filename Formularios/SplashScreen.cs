using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace AByteOf熊猫
{
    public partial class SplashScreen : Form
    {
        // Variables de control para la barra de carga y cambio de texto
        private int progreso = 0;
        private int cambioTexto = 0;
        private bool esHola = true;
        public SplashScreen()
        {
            InitializeComponent();
            // Carga el logo desde la carpeta "Assets"
            string rutaLogo = Path.Combine(Application.StartupPath, "Assets", "A byte of.png");
            pcbLogo.Image = Image.FromFile(rutaLogo);
            // Inicializa la barra de progreso en cero
            pgbLoading.Value = 0;
            lblTextHello.Text = "Hola";
            // Inicia los temporizadores
            tmrLoading.Start();
            tmrText.Start();
        }
        // Este temporizador simula una carga con la barra de progreso
        private void tmrLoading_Tick(object sender, EventArgs e)
        {
            
            pgbLoading.Value += 1;
            // Cuando se llena la barra de progreso, se oculta el splash y se abre el login
            if (pgbLoading.Value >= pgbLoading.Maximum)
            {
                tmrLoading.Stop();
                this.Hide();
                Log_in loginForm = new Log_in();
                loginForm.ShowDialog();


            }
        }
        // Este temporizador alterna el texto entre "Hola" y "你好"
        private void tmrText_Tick(object sender, EventArgs e)
        {
            // Alterna el texto entre español y chino cada tick
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
            // Detener el cambio de texto después de 10 ciclos
            if (cambioTexto >= 10)
            {
                tmrText.Stop();
            }
        }
    }
}
