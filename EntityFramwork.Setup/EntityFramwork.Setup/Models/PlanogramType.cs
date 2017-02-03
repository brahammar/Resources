namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanogramType")]
    public partial class PlanogramType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanogramType()
        {
            Planograms = new HashSet<Planogram>();
        }

        public Guid PlanogramTypeId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public bool IsPlanogram { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public Guid? ExternalId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Planogram> Planograms { get; set; }
    }
}
