
using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{
    public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
    {
      
        public void Configure(EntityTypeBuilder<Paciente> builder)
        {

            builder.ToTable("Paciente", "DoacaoMais");
       

            builder.HasKey(x => x.PacienteId);

            builder.Property(x => x.PacienteId)
           .HasColumnName("PacienteId")
           .IsRequired()
           .ValueGeneratedOnAdd();
        }
    }
}
