using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.Blog
{
    [Table("Author", Schema = "Blog")]   
    public partial class Author
    {
        public Author()
        {
            Posts = new HashSet<Post>();
        }

        [Key]
        public long AuthorId { get; set; }
        [StringLength(150)]
        public string Name { get; set; }
        [StringLength(15)]
        public string Mobile { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
        [Required]
        [StringLength(32)]
        public string PasswordHash { get; set; }
        public DateTime RegisteredAt { get; set; }
        public DateTime? LastLogin { get; set; }
        [StringLength(255)]
        public string Intro { get; set; }
        public string Profile { get; set; }
        [StringLength(255)]
        public string UrlImage { get; set; }

        [InverseProperty(nameof(Post.Author))]
        public virtual ICollection<Post> Posts { get; set; }
    }
}
