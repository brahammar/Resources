namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_QuestionTranslations
    {
        [Key]
        public Guid QuestionTranslationID { get; set; }

        public Guid QuestionID { get; set; }

        public Guid LanguageID { get; set; }

        public string Question { get; set; }

        public bool IsDefault { get; set; }

        public virtual APPR_Language APPR_Language { get; set; }

        public virtual APPR_Question APPR_Question { get; set; }
    }
}
