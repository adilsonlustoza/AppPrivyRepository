
using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppPrivy.Data.EntityConfig.DoacaoMais
{
    public class DispositivoConfiguration : IEntityTypeConfiguration<Dispositivo>
    {

        public void Configure(EntityTypeBuilder<Dispositivo> builder)
        {

            builder.ToTable("Dispositivo", "DoacaoMais");

            builder.HasKey(x => x.DispositivoId);

            builder.Property(x => x.DispositivoId)
            .HasColumnName("DispositivoId")
            .IsRequired()
           .ValueGeneratedOnAdd();

        }
    }
}
