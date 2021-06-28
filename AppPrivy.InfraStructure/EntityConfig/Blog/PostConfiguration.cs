using AppPrivy.Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace AppPrivy.InfraStructure.EntityConfig.Blog
{
    public class PostConfiguration : IEntityTypeConfiguration<Post>
    {
        public void Configure(EntityTypeBuilder<Post> builder)
        {

                builder.ToTable("Post", "Blog");
          
                builder.HasKey(x => x.PostId);
            
                builder.Property(e => e.Content).IsUnicode(false);

                builder.Property(e => e.CreatedAt).HasPrecision(0);

                builder.Property(e => e.MetaTitle).IsUnicode(false);

                builder.Property(e => e.PublishedAt).HasPrecision(0);

                builder.Property(e => e.Slug).IsUnicode(false);

                builder.Property(e => e.Summary).IsUnicode(false);

                builder.Property(e => e.Title).IsUnicode(false);

                builder.Property(e => e.UpdatedAt).HasPrecision(0);

                builder.Property(e => e.UrlImage).IsUnicode(false);

                builder.HasOne(d => d.Author)
                    .WithMany(p => p.Posts)
                    .HasForeignKey(d => d.AuthorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_post_user");

                builder.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("fk_post_parent");
            
        }
    }
}
