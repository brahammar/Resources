namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanogramItem")]
    public partial class PlanogramItem
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PlanogramItem()
        {
            InspectionPlanogramItems = new HashSet<InspectionPlanogramItem>();
            PlanogramItemOptions = new HashSet<PlanogramItemOption>();
        }

        public Guid PlanogramItemId { get; set; }

        public Guid PlanogramId { get; set; }

        public Guid PlanogramItemTypeId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        public int SectionNumber { get; set; }

        public Guid? ProductId { get; set; }

        public int ImageCoordinateX { get; set; }

        public int ImageCoordinateY { get; set; }

        public int InspectionPoints { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionPlanogramItem> InspectionPlanogramItems { get; set; }

        public virtual Planogram Planogram { get; set; }

        public virtual PlanogramItemType PlanogramItemType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanogramItemOption> PlanogramItemOptions { get; set; }
    }
}
