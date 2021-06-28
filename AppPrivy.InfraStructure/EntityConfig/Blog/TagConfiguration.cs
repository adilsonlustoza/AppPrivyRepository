using AppPrivy.Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Blog
{
    public class TagConfiguration : IEntityTypeConfiguration<Tag>
    {
        public void Configure(EntityTypeBuilder<Tag> builder)
        {
            builder.ToTable("Tag", "Blog");

            builder.HasKey(x => x.TagId);

            builder.Property(e => e.Content).IsUnicode(false);

            builder.Property(e => e.MetaTitle).IsUnicode(false);

            builder.Property(e => e.Slug).IsUnicode(false);

            builder.Property(e => e.Title).IsUnicode(false);

        }
    }
}
