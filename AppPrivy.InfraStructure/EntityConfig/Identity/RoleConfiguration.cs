
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{

    public class RoleConfiguration : IEntityTypeConfiguration<Role>
    {    
       

        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.ToTable("Role", "dbo");
            builder.HasKey(x => x.Id);         
        }
    }
}

