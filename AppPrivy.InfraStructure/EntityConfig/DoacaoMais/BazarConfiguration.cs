
using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppPrivy.Data.EntityConfig.DoacaoMais
{

    public class BazarConfiguration : IEntityTypeConfiguration<Bazar>
    {    


        public void Configure(EntityTypeBuilder<Bazar> builder)
        {          

            builder.ToTable("Bazar", "DoacaoMais");
            builder.HasKey(x => x.BazarId); 
            builder.Property(x => x.BazarId)
           .HasColumnName("BazarId")
           .IsRequired()
           .ValueGeneratedOnAdd(); 
        }
    }
}

