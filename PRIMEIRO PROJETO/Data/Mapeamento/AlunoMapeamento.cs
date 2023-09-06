using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRIMEIRO_PROJETO.Models;

namespace PRIMEIRO_PROJETO.Data.Mapeamento
{
    public class AlunoMapeamento : IEntityTypeConfiguration<Aluno>
    {
        public void Configure(EntityTypeBuilder<Aluno> builder)
        {
            builder.ToTable("Aluno");
        
            builder.HasKey(t => t.Id);

            builder.Property(t => t.Nome).HasColumnType("varchar(50)");
            builder.Property(t => t.DataNascimento).HasColumnType("varchar(20)");
            builder.Property(t => t.Curso).HasColumnType("varchar(50)");
            builder.Property(t => t.Endereco).HasColumnType("varchar(50)");
            builder.Property(t => t.Matricula).HasColumnType("varchar(10)");
            builder.Property(t => t.Cep).HasColumnType("varchar(10)");



        }
    }
}
