﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace AppPrivy.Domain
{
    [Table("PostComment", Schema = "Blog")]
    //[Index(nameof(ParentId), Name = "idx_comment_parent")]
    //[Index(nameof(PostId), Name = "idx_comment_post")]
    public partial class PostComment
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
        [InverseProperty("PostComment")]
        public virtual Post Post { get; set; }
    }
}