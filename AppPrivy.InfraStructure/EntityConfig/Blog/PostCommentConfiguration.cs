using AppPrivy.Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Blog
{
    public class PostCommentConfiguration : IEntityTypeConfiguration<PostComment>
    {
        public void Configure(EntityTypeBuilder<PostComment> builder)
        {
            builder.ToTable("PostComment", "Blog");

            builder.Property(e => e.Content).IsUnicode(false);

            builder.Property(e => e.CreatedAt).HasPrecision(0);

            builder.Property(e => e.PublishedAt).HasPrecision(0);

            builder.Property(e => e.Title).IsUnicode(false);

            builder.HasOne(d => d.Post)
                .WithMany(p => p.PostComments)
                .HasForeignKey(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_comment_post");
        }
    }
}
