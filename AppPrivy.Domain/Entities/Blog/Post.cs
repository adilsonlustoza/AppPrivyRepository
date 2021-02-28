﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AppPrivy.Domain
{
    [Table("Post", Schema = "Blog")]
    //[Index(nameof(ParentId), Name = "idx_post_parent")]
    //[Index(nameof(AuthorId), Name = "idx_post_user")]
    //[Index(nameof(Slug), Name = "uq_slug", IsUnique = true)]
    public partial class Post
    {
        public Post()
        {
            InverseParent = new HashSet<Post>();
            PostCategory = new HashSet<PostCategory>();
            PostComment = new HashSet<PostComment>();
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
        [InverseProperty("Post")]
        public virtual Author Author { get; set; }
        [ForeignKey(nameof(ParentId))]
        [InverseProperty(nameof(Post.InverseParent))]
        public virtual Post Parent { get; set; }
        [InverseProperty("Post")]
        public virtual PostMeta PostMeta { get; set; }
        [InverseProperty(nameof(Post.Parent))]
        public virtual ICollection<Post> InverseParent { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<PostCategory> PostCategory { get; set; }
        [InverseProperty("Post")]
        public virtual ICollection<PostComment> PostComment { get; set; }
    }
}