using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Identity
{
    public class IdentityUserTokenConfiguration : IEntityTypeConfiguration<IdentityUserToken<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserToken<string>> u)
        {
            u.ToTable("UserToken", "Security");
            u.HasKey("UserId").HasName("UserTokenPk");
        }
    }
}
