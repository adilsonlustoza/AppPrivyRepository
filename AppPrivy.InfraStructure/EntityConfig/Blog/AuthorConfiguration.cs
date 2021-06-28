using AppPrivy.Domain.Entities.Blog;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AppPrivy.InfraStructure.EntityConfig.Blog
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.ToTable("Author", "Blog");

            builder.HasKey(x => x.AuthorId);

            builder.Property(e => e.Email).IsUnicode(false);

            builder.Property(e => e.Intro).IsUnicode(false);

            builder.Property(e => e.LastLogin).HasPrecision(0);

            builder.Property(e => e.Mobile).IsUnicode(false);

            builder.Property(e => e.Name).IsUnicode(false);

            builder.Property(e => e.PasswordHash).IsUnicode(false);

            builder.Property(e => e.Profile).IsUnicode(false);

            builder.Property(e => e.RegisteredAt).HasPrecision(0);

            builder.Property(e => e.UrlImage).IsUnicode(false);

        }
    }
}
