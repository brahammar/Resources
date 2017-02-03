namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanogramItemType")]
    public partial class PlanogramItemType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanogramItemType()
        {
            PlanogramItems = new HashSet<PlanogramItem>();
        }

        public Guid PlanogramItemTypeId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanogramItem> PlanogramItems { get; set; }
    }
}
