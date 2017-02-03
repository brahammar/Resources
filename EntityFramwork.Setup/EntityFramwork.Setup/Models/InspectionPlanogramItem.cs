namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("InspectionPlanogramItem")]
    public partial class InspectionPlanogramItem
    {
        public Guid InspectionPlanogramItemId { get; set; }

        public Guid InspectionPlanogramId { get; set; }

        public Guid PlanogramItemId { get; set; }

        public bool Passed { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public Guid? SelectedPlanogramItemOptionId { get; set; }

        public virtual InspectionPlanogram InspectionPlanogram { get; set; }

        public virtual PlanogramItem PlanogramItem { get; set; }
    }
}
