
using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{
    public class BoletimConfiguration : IEntityTypeConfiguration<Boletim>
    {


        public void Configure(EntityTypeBuilder<Boletim> builder)
        {
            builder.ToTable("Boletim", "DoacaoMais");
            builder.HasKey(x => x.BoletimId);
            builder.Property(x => x.BoletimId)
           .HasColumnName("BoletimId")
           .IsRequired()
           .ValueGeneratedOnAdd();
        }
    }
}
