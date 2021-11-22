using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Models
{
    [Table("userSessionTracker")]
    public partial class UserSessionTracker
    {
        [Key]
        [Column("sessionId")]
        public int SessionId { get; set; }
        [Required]
        [Column("userId")]
        [StringLength(450)]
        public string UserId { get; set; }
        [Column("questionCount")]
        public int QuestionCount { get; set; }
        [Column("currentQuestion")]
        public int CurrentQuestion { get; set; }
        [Column("correctAnswerCount")]
        public int CorrectAnswerCount { get; set; }
        [Column("questionType")]
        public int QuestionType { get; set; }
        [Required]
        [Column("queryCriteria")]
        [StringLength(20)]
        public string QueryCriteria { get; set; }

        [ForeignKey(nameof(QuestionType))]
        [InverseProperty("UserSessionTracker")]
        public virtual QuestionType QuestionTypeNavigation { get; set; }
    }
}
