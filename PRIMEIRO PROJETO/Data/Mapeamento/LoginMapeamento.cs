using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PRIMEIRO_PROJETO.Models;
using Microsoft.EntityFrameworkCore;

namespace PRIMEIRO_PROJETO.Data.Mapeamento
{
    public class LoginMapeamento : IEntityTypeConfiguration<Login>
    {
        public void Configure(EntityTypeBuilder<Login> builder)
        {
                builder.ToTable("Login");

                builder.HasKey(t => t.Id);

                builder.Property(t => t.Email).HasColumnType("varchar(50)");
                builder.Property(t => t.Senha).HasColumnType("varchar(50)");
                

        }
    
    }
}
