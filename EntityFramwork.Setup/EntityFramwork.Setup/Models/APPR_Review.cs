namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_Review
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APPR_Review()
        {
            APPR_Answer = new HashSet<APPR_Answer>();
        }

        public Guid DealerID { get; set; }

        [Key]
        public Guid ReviewID { get; set; }

        public Guid ReviewVersionID { get; set; }

        public Guid LanguageID { get; set; }

        public DateTime Created { get; set; }

        public DateTime Updated { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string CreatedBy { get; set; }

        public Guid ReviewerID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string UpdatedBy { get; set; }

        public byte[] PDFReport { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_Answer> APPR_Answer { get; set; }

        public virtual APPR_Language APPR_Language { get; set; }

        public virtual APPR_ReviewVersion APPR_ReviewVersion { get; set; }
    }
}
