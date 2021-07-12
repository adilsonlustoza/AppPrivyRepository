using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.Blog
{
    [Table("PostComment", Schema = "Blog")]
    public partial class PostComment : Entity
    {
        [Key]
        public long PostCommentId { get; set; }
        public long PostId { get; set; }
        public long? ParentId { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }
        public short Published { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? PublishedAt { get; set; }
        public string Content { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("PostComments")]
        public virtual Post Post { get; set; }
    }
}
