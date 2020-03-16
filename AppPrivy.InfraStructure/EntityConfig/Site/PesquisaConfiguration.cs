using AppPrivy.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Site
{
    public class PesquisaConfiguration: IEntityTypeConfiguration<Pesquisa>
    {    

        public void Configure(EntityTypeBuilder<Pesquisa> builder)
        {

            builder.ToTable("Pesquisa", "Site");

            builder.HasKey(x => x.PesquisaId);

            builder.Property(x => x.PesquisaId)
           .HasColumnName("PesquisaId")
           .IsRequired()
           .ValueGeneratedOnAdd();
        }
    }
}
