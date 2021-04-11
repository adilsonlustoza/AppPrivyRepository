
using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{
    public class CampanhaConfiguration : IEntityTypeConfiguration<Campanha>
    {


        public void Configure(EntityTypeBuilder<Campanha> builder)
        {
            builder.ToTable("Campanha", "DoacaoMais");
            builder.HasKey(x => x.BoletimId);
            builder.Property(x => x.BoletimId)
           .HasColumnName("CampanhaId")
           .IsRequired()
           .ValueGeneratedOnAdd();
        }
    }
}
