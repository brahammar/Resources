namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inspection")]
    public partial class Inspection
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Inspection()
        {
            InspectionImages = new HashSet<InspectionImage>();
            InspectionPlanograms = new HashSet<InspectionPlanogram>();
        }

        public Guid InspectionId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid AccountId { get; set; }

        public Guid InspectorId { get; set; }

        public int Score { get; set; }

        public DateTime Date { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [StringLength(2000)]
        public string Comment { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionImage> InspectionImages { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionPlanogram> InspectionPlanograms { get; set; }
    }
}
