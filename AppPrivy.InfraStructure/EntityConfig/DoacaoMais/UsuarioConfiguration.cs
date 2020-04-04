
using AppPrivy.Domain.Entities.DoacaoMais;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;


namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{
    public class UsuarioConfiguration : IEntityTypeConfiguration<Usuario>
    {
       

        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
         
            builder.ToTable("Usuario", "DoacaoMais");

            builder.HasKey(x => x.UsuarioId);

            builder.Property(x => x.UsuarioId)
           .HasColumnName("UsuarioId")
           .IsRequired()
           .ValueGeneratedOnAdd();
        }
    }
}
