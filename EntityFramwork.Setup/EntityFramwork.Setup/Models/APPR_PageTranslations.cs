namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_PageTranslations
    {
        [Key]
        public Guid PageTranslationID { get; set; }

        public Guid PageID { get; set; }

        public Guid LanguageID { get; set; }

        [Required]
        public string PageTitle { get; set; }

        public bool IsDefault { get; set; }

        public virtual APPR_Language APPR_Language { get; set; }

        public virtual APPR_Page APPR_Page { get; set; }
    }
}
