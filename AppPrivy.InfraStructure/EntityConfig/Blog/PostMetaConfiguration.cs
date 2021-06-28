using AppPrivy.Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Blog
{
    public class PostMetaConfiguration : IEntityTypeConfiguration<PostMeta>
    {
        public void Configure(EntityTypeBuilder<PostMeta> builder)
        {
            builder.ToTable("PostMeta", "Blog");

            builder.HasKey(e => e.PostMetaId)
                      .HasName("PK__PostMeta__3F68FFCF84F93CBC");

            builder.Property(e => e.Content).IsUnicode(false);

            builder.Property(e => e.Nkey).IsUnicode(false);

            builder.HasOne(d => d.Post)
                .WithOne(p => p.PostMeta)
                .HasForeignKey<PostMeta>(d => d.PostId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("fk_meta_post");
        }
    }
}
