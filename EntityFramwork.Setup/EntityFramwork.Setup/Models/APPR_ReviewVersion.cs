namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_ReviewVersion
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APPR_ReviewVersion()
        {
            APPR_Review = new HashSet<APPR_Review>();
        }

        [Key]
        public Guid ReviewVersionID { get; set; }

        [Column(TypeName = "text")]
        [Required]
        public string Version { get; set; }

        public bool IsCurrent { get; set; }

        [Column(TypeName = "date")]
        public DateTime FromDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ToDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_Review> APPR_Review { get; set; }
    }
}
