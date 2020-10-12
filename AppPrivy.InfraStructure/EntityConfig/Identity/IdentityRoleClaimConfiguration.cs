using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Identity
{
    public class IdentityRoleClaimConfiguration : IEntityTypeConfiguration<IdentityRoleClaim<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityRoleClaim<string>> u)
        {
            u.ToTable("RoleClaim", "Security");
            u.HasKey("Id", "RoleId").HasName("RoleClaimPk");
            u.Property("Id").IsRequired().ValueGeneratedOnAdd();
        }
    }
}
