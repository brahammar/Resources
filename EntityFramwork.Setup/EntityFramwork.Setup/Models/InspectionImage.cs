namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InspectionImage")]
    public partial class InspectionImage
    {
        public Guid InspectionImageId { get; set; }

        public Guid InspectionId { get; set; }

        [Required]
        [StringLength(256)]
        public string ImageName { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Inspection Inspection { get; set; }
    }
}
