using AppPrivy.Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Blog
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category", "Blog");

            builder.HasKey(x => x.CategoryId);

            builder.Property(e => e.Content).IsUnicode(false);

            builder.Property(e => e.MetaTitle).IsUnicode(false);

            builder.Property(e => e.Slug).IsUnicode(false);

            builder.Property(e => e.Title).IsUnicode(false);

            builder.Property(e => e.UrlImage).IsUnicode(false);

            builder.HasOne(d => d.Parent)
                .WithMany(p => p.InverseParent)
                .HasForeignKey(d => d.ParentId)
                .HasConstraintName("fk_category_parent");

        }
    }
}
