namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesChannelPlanogramType")]
    public partial class SalesChannelPlanogramType
    {
        public Guid SalesChannelPlanogramTypeId { get; set; }

        public Guid SalesChannelId { get; set; }

        public Guid PlanogramTypeId { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual PlanogramType PlanogramType { get; set; }

        public virtual SalesChannel SalesChannel { get; set; }
    }
}
