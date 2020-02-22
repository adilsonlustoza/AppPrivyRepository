using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.Data.EntityConfig.DoacaoMais
{
    public class NoticiaConfiguration : IEntityTypeConfiguration<Noticia>
    {


        public void Configure(EntityTypeBuilder<Noticia> builder)
        {


            builder.ToTable("Noticia", "DoacaoMais");

            builder.HasKey(x => x.NoticiaId);

            builder.Property(x => x.NoticiaId)
          .HasColumnName("NoticiaId")
          .IsRequired()
          .ValueGeneratedOnAdd();
        }
    }
}
