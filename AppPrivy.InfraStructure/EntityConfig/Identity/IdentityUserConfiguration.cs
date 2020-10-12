using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Identity
{
    public class IdentityUserConfiguration : IEntityTypeConfiguration<IdentityUser>
    {
        public void Configure(EntityTypeBuilder<IdentityUser> u)
        {

            u.ToTable("User", "Security");
            u.HasKey("Id").HasName("UserId");
            u.Property("Id").IsRequired().ValueGeneratedOnAdd();

        }
    }
}
