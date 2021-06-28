using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.Blog
{
    [Table("PostMeta", Schema = "Blog")]
    public partial class PostMeta
    {
        [Key]
        public long PostMetaId { get; set; }

        public long PostId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Nkey { get; set; }
        
        [StringLength(500)]
        public string Content { get; set; }

        [ForeignKey(nameof(PostId))]
        [InverseProperty("PostMetum")]
        public virtual Post Post { get; set; }
    }
}
