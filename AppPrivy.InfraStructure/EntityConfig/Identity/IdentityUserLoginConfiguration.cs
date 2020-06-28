using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Identity
{
    public class IdentityUserLoginConfiguration : IEntityTypeConfiguration<IdentityUserLogin<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserLogin<string>> u)
        {
            u.ToTable("UserLogin", "Security");            
            u.HasKey("UserId").HasName("UserLoginPk");
        }
    }
}
