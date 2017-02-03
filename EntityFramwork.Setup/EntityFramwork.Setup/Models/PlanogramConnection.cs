namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanogramConnection")]
    public partial class PlanogramConnection
    {
        public Guid PlanogramConnectionId { get; set; }

        public Guid ParentPlanogramId { get; set; }

        public Guid ChildPlanogramId { get; set; }

        public virtual Planogram Planogram { get; set; }

        public virtual Planogram Planogram1 { get; set; }
    }
}
