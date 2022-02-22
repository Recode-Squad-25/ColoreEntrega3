using Colore_Entrega2.Models;
using Microsoft.EntityFrameworkCore;

namespace ColoreEntrega2.Models
{
    public class Conexao : DbContext
    {
        public Conexao(DbContextOptions<Conexao> options) : base(options)
        {

        }
        public DbSet<Curriculo> curriculo { get; set; }
        public DbSet<Empresa> empresa { get; set; }
        public DbSet<Vagas> vagas { get; set; }

    }
}
