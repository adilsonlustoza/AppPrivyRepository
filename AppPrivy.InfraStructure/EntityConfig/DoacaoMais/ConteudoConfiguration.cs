
using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{

    public class ConteudoConfiguration : IEntityTypeConfiguration<Conteudo>
    {

        public void Configure(EntityTypeBuilder<Conteudo> builder)
        {
            builder.ToTable("Conteudo", "DoacaoMais");

            builder.HasKey(x => x.ConteudoId);

            builder.Property(x => x.ConteudoId)
           .HasColumnName("ConteudoId")
           .IsRequired()
           .ValueGeneratedOnAdd();
        }
    }
}

