using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Models
{
    [Table("userContent")]
    public partial class UserContent
    {
        [Key]
        [Column("postId")]
        public int PostId { get; set; }
        [Required]
        [Column("userRef")]
        [StringLength(450)]
        public string UserRef { get; set; }
        [Column("questionContent")]
        [StringLength(256)]
        public string QuestionContent { get; set; }
        [Column("answerContent")]
        [StringLength(256)]
        public string AnswerContent { get; set; }
        [Column("questionType")]
        [Range(1, 5)]
        public int QuestionType { get; set; } 
        [Column("likes")]
        public int? Likes { get; set; }
        [Column("dislikes")]
        public int? Dislikes { get; set; }
        [Column("flags")]
        public int? Flags { get; set; }
        [Column("shadowed")]
        public bool Shadowed { get; set; }

        [ForeignKey(nameof(QuestionType))]
        [InverseProperty("UserContent")]
        public virtual QuestionType QuestionTypeNavigation { get; set; }
        [ForeignKey(nameof(UserRef))]
        [InverseProperty(nameof(AspNetUsers.UserContent))]
        public virtual AspNetUsers UserRefNavigation { get; set; }
    }
}


