using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Identity
{
    public class IdentityUserClaimConfiguration : IEntityTypeConfiguration<IdentityUserClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserClaim<string>> u)
        {
            u.ToTable("UserClaim", "Security");
            u.HasKey("Id", "UserId").HasName("UserClaimPk");
            u.Property("Id").IsRequired().ValueGeneratedOnAdd();
        }
    }
}
