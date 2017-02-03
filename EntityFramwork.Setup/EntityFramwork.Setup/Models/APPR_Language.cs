namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_Language
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APPR_Language()
        {
            APPR_PageTranslations = new HashSet<APPR_PageTranslations>();
            APPR_QuestionTranslations = new HashSet<APPR_QuestionTranslations>();
            APPR_Review = new HashSet<APPR_Review>();
            APPR_SectionTranslations = new HashSet<APPR_SectionTranslations>();
            APPR_LanguageCountry = new HashSet<APPR_LanguageCountry>();
        }

        [Key]
        public Guid LanguageID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Language { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_PageTranslations> APPR_PageTranslations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_QuestionTranslations> APPR_QuestionTranslations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_Review> APPR_Review { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_SectionTranslations> APPR_SectionTranslations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_LanguageCountry> APPR_LanguageCountry { get; set; }
    }
}
