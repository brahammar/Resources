namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanogramItemOption")]
    public partial class PlanogramItemOption
    {
        public Guid PlanogramItemOptionId { get; set; }

        public Guid PlanogramItemId { get; set; }

        [Required]
        [StringLength(128)]
        public string Name { get; set; }

        public int? OrderIndex { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool IsActive { get; set; }

        public virtual PlanogramItem PlanogramItem { get; set; }
    }
}
