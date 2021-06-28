using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.Blog
{
    [Table("PostTag", Schema = "Blog")]
    public partial class PostTag
    {
        [Key]
        public long PostId { get; set; }

        [Key]
        public long TagId { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("PostTags")]
        public virtual Post Post { get; set; }

        [ForeignKey(nameof(TagId))]
        [InverseProperty("PostTags")]
        public virtual Tag Tag { get; set; }
    }
}
