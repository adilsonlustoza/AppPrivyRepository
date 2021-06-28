using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.Blog
{
    [Table("PostCategory", Schema = "Blog")]
    public partial class PostCategory
    {
        [Key]
        public long PostId { get; set; }
        [Key]
        public long CategoryId { get; set; }

        [ForeignKey(nameof(CategoryId))]
        [InverseProperty("PostCategories")]
        public virtual Category Category { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("PostCategories")]
        public virtual Post Post { get; set; }
    }
}
