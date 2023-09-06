using Microsoft.EntityFrameworkCore;
using PRIMEIRO_PROJETO.Data.Mapeamento;
using PRIMEIRO_PROJETO.Models;

namespace PRIMEIRO_PROJETO.Data
{
    public class BancoContexto : DbContext
    {
        public BancoContexto(DbContextOptions<BancoContexto> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AlunoMapeamento());
        }

        public DbSet<Aluno> Aluno { get; set; }
        public DbSet<Login> Login { get; set; }

    }
}
