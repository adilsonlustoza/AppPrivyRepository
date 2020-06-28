using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AppPrivy.InfraStructure.EntityConfig.Identity
{
    public class IdentityUserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> u)
        {
            u.ToTable("UserRole", "Security");
            u.HasKey("UserId", "RoleId").HasName("UserRolePk");
        }
    }
}
