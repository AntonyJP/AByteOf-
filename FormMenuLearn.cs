using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AByteOf熊猫
{
    public partial class FormMenuLearn : Form
    {
        public FormMenuLearn()
        {
            InitializeComponent();
            // Ruta del logo dentro de la carpeta "Assets" ubicada en el directorio raíz de la aplicación
            string rutaLogo = Path.Combine(Application.StartupPath, "Assets", "A byte of.png");
            pcbLogo.Image = Image.FromFile(rutaLogo);
        }
    }
}
