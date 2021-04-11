using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{
    public class CacccConfiguration : IEntityTypeConfiguration<Caccc>
    {

        public void Configure(EntityTypeBuilder<Caccc> builder)
        {
            builder.ToTable("Caccc", "DoacaoMais");

            builder.HasKey(x => x.CacccId);

            builder.OwnsOne(x => x.Endereco);

            builder.Property(x => x.CacccId)
           .HasColumnName("CacccId")
           .IsRequired()
           .ValueGeneratedOnAdd();

            builder.HasMany(e => e.Noticias)
           .WithOne(e => e.Caccc)
           .OnDelete(DeleteBehavior.ClientSetNull);


            builder.HasMany(e => e.Bazares)
           .WithOne(e => e.Caccc)
           .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasMany(e => e.Campanhas)
           .WithOne(e => e.Caccc)
           .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasMany(e => e.ContasBancarias)
           .WithOne(e => e.Caccc)
           .OnDelete(DeleteBehavior.ClientSetNull);


            builder.HasMany(e => e.Conteudos)
           .WithOne(e => e.Caccc)
           .OnDelete(DeleteBehavior.ClientSetNull);
                     



        }
    }
}
