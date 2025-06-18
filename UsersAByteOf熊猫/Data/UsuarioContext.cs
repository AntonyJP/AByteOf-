using Microsoft.EntityFrameworkCore;
using UsersAByteOf熊猫.Models;

namespace UsersAByteOf熊猫.Data
{
    public class UsuarioContext : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }
        public UsuarioContext(DbContextOptions<UsuarioContext> options) : base(options) { }
    }
}
