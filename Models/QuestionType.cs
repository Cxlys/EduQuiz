using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace pleaseoftheloveofgodbethelastversionofthisproject.Models
{
    [Table("questionType")]
    public partial class QuestionType
    {
        public QuestionType()
        {
            UserContent = new HashSet<UserContent>();
            UserSessionTracker = new HashSet<UserSessionTracker>();
        }

        [Key]
        [Column("typeId")]
        public int TypeId { get; set; }
        [Required]
        [Column("questionType")]
        public string QuestionType1 { get; set; }

        [InverseProperty("QuestionTypeNavigation")]
        public virtual ICollection<UserContent> UserContent { get; set; }
        [InverseProperty("QuestionTypeNavigation")]
        public virtual ICollection<UserSessionTracker> UserSessionTracker { get; set; }
    }
}
