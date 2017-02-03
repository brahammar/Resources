namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_SectionTranslations
    {
        [Key]
        public Guid SectionTranslationID { get; set; }

        public Guid SectionID { get; set; }

        public Guid LanguageID { get; set; }

        [Required]
        public string SectionTitle { get; set; }

        public bool IsDefault { get; set; }

        public virtual APPR_Language APPR_Language { get; set; }

        public virtual APPR_Section APPR_Section { get; set; }
    }
}
