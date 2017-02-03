namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_Answer
    {
        [Key]
        public Guid AnswerID { get; set; }

        public Guid QuestionID { get; set; }

        public Guid ReviewID { get; set; }

        [Column(TypeName = "text")]
        public string Answer { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string CreatedBy { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string UpdatedBy { get; set; }

        public virtual APPR_Review APPR_Review { get; set; }

        public virtual APPR_Question APPR_Question { get; set; }
    }
}
