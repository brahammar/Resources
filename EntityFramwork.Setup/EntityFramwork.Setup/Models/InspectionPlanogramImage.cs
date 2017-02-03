namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InspectionPlanogramImage")]
    public partial class InspectionPlanogramImage
    {
        public Guid InspectionPlanogramImageId { get; set; }

        public Guid InspectionPlanogramId { get; set; }

        [Required]
        [StringLength(256)]
        public string FileName { get; set; }

        public int FileSizeBytes { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual InspectionPlanogram InspectionPlanogram { get; set; }
    }
}
