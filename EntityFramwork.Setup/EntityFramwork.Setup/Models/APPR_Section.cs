namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_Section
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APPR_Section()
        {
            APPR_Question = new HashSet<APPR_Question>();
            APPR_SectionTranslations = new HashSet<APPR_SectionTranslations>();
        }

        [Key]
        public Guid SectionID { get; set; }

        public int? FontSize { get; set; }

        public Guid SectionTypeID { get; set; }

        public int SortIndex { get; set; }

        public Guid PageID { get; set; }

        public virtual APPR_Page APPR_Page { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_Question> APPR_Question { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_SectionTranslations> APPR_SectionTranslations { get; set; }

        public virtual APPR_SectionType APPR_SectionType { get; set; }
    }
}
