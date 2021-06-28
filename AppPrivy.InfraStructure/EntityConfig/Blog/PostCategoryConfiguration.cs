using AppPrivy.Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Blog
{
    public class PostCategoryConfiguration : IEntityTypeConfiguration<PostCategory>
    {
        public void Configure(EntityTypeBuilder<PostCategory> builder)
        {
            builder.ToTable("PostCategory", "Blog");

            builder.HasKey(e => new { e.PostId, e.CategoryId })
                   .HasName("PK__PostCate__0B82F3B8184B5D0C");

            builder.HasOne(d => d.Category)
                .WithMany(p => p.PostCategories)
                .HasForeignKey(d => d.CategoryId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pc_category");

            builder.HasOne(d => d.Post)
                .WithMany(p => p.PostCategories)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_pc_post");

        }
    }
}
