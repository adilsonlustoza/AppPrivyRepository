
using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppPrivy.Data.EntityConfig.DoacaoMais
{
    public class CacccConfiguration : IEntityTypeConfiguration<Caccc> 
    {   

        public void Configure(EntityTypeBuilder<Caccc> builder)
        {
            builder.ToTable("Caccc", "DoacaoMais");

            builder.HasKey(x => x.CacccId);

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

            builder.HasMany(e => e.Boletins)
           .WithOne(e => e.Caccc)
           .OnDelete(DeleteBehavior.ClientSetNull);

            builder.HasMany(e => e.ContasBancarias)
           .WithOne(e => e.Caccc)
           .OnDelete(DeleteBehavior.ClientSetNull);


            builder.HasMany(e => e.Conteudos)
           .WithOne(e => e.Caccc)
           .OnDelete(DeleteBehavior.ClientSetNull);


            builder.HasMany(e => e.Pacientes)
            .WithOne(e => e.Caccc)
           .OnDelete(DeleteBehavior.ClientSetNull);

        }
    }
}
