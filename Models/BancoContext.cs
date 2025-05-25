using Microsoft.EntityFrameworkCore;

namespace AgendaContatos.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<Contato> Contatos { get; set; }
    }
}
