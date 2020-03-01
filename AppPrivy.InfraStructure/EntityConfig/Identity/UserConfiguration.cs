
using AppPrivy.Domain.Entities.DoacaoMais;
using AppPrivy.Domain.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AppPrivy.InfraStructure.EntityConfig.DoacaoMais
{

    public class UserConfiguration : IEntityTypeConfiguration<User>
    {    
       

        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User", "dbo");
            builder.HasKey(x => x.Id);

            
        }
    }
}

