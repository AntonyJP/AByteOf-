using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AByteOf熊猫.Models
{
    public class Palabra
    {
        public int IdPalabra { get; set; }
        public string Caracter { get; set; }
        public string Pinyin { get; set; }
        public string Significado { get; set; }
        public int Estado { get; set; } /*0-10*/
        public int  VecesCorrectas { get; set; }
        public string Actividad { get; set; } 
    }
}
