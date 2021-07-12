using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.Blog
{
    [Table("Tag", Schema = "Blog")]
    public partial class Tag : Entity
    {
        public Tag()
        {
            PostTags = new HashSet<PostTag>();
        }

        [Key]
        public long TagId { get; set; }

        [Required]
        [StringLength(75)]
        public string Title { get; set; }
        
        [StringLength(100)]
        public string MetaTitle { get; set; }
        
        [Required]
        [StringLength(100)]
        public string Slug { get; set; }
        
        public string Content { get; set; }

        [InverseProperty(nameof(PostTag.Tag))]
        public virtual ICollection<PostTag> PostTags { get; set; }
    }
}
