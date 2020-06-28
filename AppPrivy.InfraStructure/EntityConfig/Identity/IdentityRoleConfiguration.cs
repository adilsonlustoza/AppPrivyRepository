using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Identity
{
    public class IdentityRoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> u)
        {
            u.ToTable("Role", "Security");
            u.HasKey("Id").HasName("RoleId");
            u.Property("Id").IsRequired().ValueGeneratedOnAdd();
        }
    }
}
