using System.ComponentModel.DataAnnotations;

namespace UsersAByteOf熊猫.Models
{
    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(75)]
        public string Nombre { get; set; }
        [Required, EmailAddress]
        public string Correo { get; set; }
        [Required, MinLength(6)]
        public string Contrasena { get; set; }
    }
}
