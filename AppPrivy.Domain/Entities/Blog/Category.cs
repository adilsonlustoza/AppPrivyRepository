using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AppPrivy.Domain.Entities.Blog
{
    [Table("Category", Schema = "Blog")]
    public partial class Category
    {
        public Category()
        {
            InverseParent = new HashSet<Category>();
            PostCategories = new HashSet<PostCategory>();
        }

        [Key]
        public long CategoryId { get; set; }
        public long? ParentId { get; set; }

        [Required]
        [StringLength(75)]
        public string Title { get; set; }
        [StringLength(100)]
        public string MetaTitle { get; set; }
        [Required]
        [StringLength(100)]
        public string Slug { get; set; }
        public string Content { get; set; }
        [StringLength(255)]
        public string UrlImage { get; set; }

        [ForeignKey(nameof(ParentId))]
        [InverseProperty(nameof(Category.InverseParent))]
        public virtual Category Parent { get; set; }
        
        [InverseProperty(nameof(Category.Parent))]
        public virtual ICollection<Category> InverseParent { get; set; }

        [InverseProperty(nameof(PostCategory.Category))]
        public virtual ICollection<PostCategory> PostCategories { get; set; }
    }
}
