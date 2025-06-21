using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AByteOf熊猫.Models
{
    public static class AppState
    {
        public static int IdUsuario { get; set; } = -1;
        public static List<Palabra> Palabras { get; set; } = new List<Palabra>();
    }
}
