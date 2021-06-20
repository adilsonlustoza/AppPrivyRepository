
using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{

    public class EstatisticoConfiguration : IEntityTypeConfiguration<Estatistico>
    {


        public void Configure(EntityTypeBuilder<Estatistico> builder)
        {

            builder.ToTable("Estatistico", "DoacaoMais");
            builder.HasKey(x => x.EstatisticoId);
            builder.Property(x => x.EstatisticoId)
           .HasColumnName("EstatisticoId")
           .IsRequired()
           .ValueGeneratedOnAdd();


            builder.Property(x => x.Valor)
           .HasColumnName("Valor")
           .HasColumnType("decimal")
           .HasDefaultValue(0.0m);

            builder.Property(x => x.Descricao)
           .HasColumnName("Descricao")
           .HasColumnType("varchar(250)")
           .HasDefaultValue(null);

            builder.Property(x => x.Fonte)
           .HasColumnName("Fonte")
           .HasColumnType("varchar(300)")
           .HasDefaultValue(null);

        }
    }
}

