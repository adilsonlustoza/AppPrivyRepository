using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.Blog
{
    [Table("Post", Schema = "Blog")]
    public partial class Post
    {
        public Post()
        {
            InverseParent = new HashSet<Post>();
            PostCategories = new HashSet<PostCategory>();
            PostComments = new HashSet<PostComment>();
            PostTags = new HashSet<PostTag>();
        }

        [Key]
        public long PostId { get; set; }
        public long AuthorId { get; set; }
        public long? ParentId { get; set; }
        [Required]
        [StringLength(75)]
        public string Title { get; set; }
        [StringLength(100)]
        public string MetaTitle { get; set; }
        [Required]
        [StringLength(100)]
        public string Slug { get; set; }
        [StringLength(255)]
        public string Summary { get; set; }
        public short Published { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }
        [StringLength(255)]
        public string UrlImage { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Posts")]
        public virtual Author Author { get; set; }


        [ForeignKey(nameof(ParentId))]
        [InverseProperty(nameof(Post.InverseParent))]
        public virtual Post Parent { get; set; }


        [InverseProperty("Post")]
        public virtual PostMeta PostMeta { get; set; }


        [InverseProperty(nameof(Post.Parent))]
        public virtual ICollection<Post> InverseParent { get; set; }


        [InverseProperty(nameof(PostCategory.Post))]
        public virtual ICollection<PostCategory> PostCategories { get; set; }


        [InverseProperty(nameof(PostComment.Post))]
        public virtual ICollection<PostComment> PostComments { get; set; }


        [InverseProperty(nameof(PostTag.Post))]
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
