namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InspectionPlanogram")]
    public partial class InspectionPlanogram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public InspectionPlanogram()
        {
            InspectionPlanogramImages = new HashSet<InspectionPlanogramImage>();
            InspectionPlanogramItems = new HashSet<InspectionPlanogramItem>();
        }

        public Guid InspectionPlanogramId { get; set; }

        public Guid InspectionId { get; set; }

        public Guid PlanogramId { get; set; }

        [StringLength(1024)]
        public string Comment { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Inspection Inspection { get; set; }

        public virtual Planogram Planogram { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionPlanogramImage> InspectionPlanogramImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionPlanogramItem> InspectionPlanogramItems { get; set; }
    }
}
