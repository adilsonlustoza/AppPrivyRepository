

using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;



namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{

    public class ContaBancariaConfiguration : IEntityTypeConfiguration<ContaBancaria>
    {


        public void Configure(EntityTypeBuilder<ContaBancaria> builder)
        {

            builder.ToTable("ContaBancaria", "DoacaoMais");
            builder.HasKey(x => x.ContaBancariaId);
            builder.Property(x => x.ContaBancariaId)
            .HasColumnName("ContaBancariaId")
            .ValueGeneratedOnAdd();
        }
    }
}

