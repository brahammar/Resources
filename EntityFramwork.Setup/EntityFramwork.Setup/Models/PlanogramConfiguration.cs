namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanogramConfiguration")]
    public partial class PlanogramConfiguration
    {
        public Guid PlanogramConfigurationId { get; set; }

        public Guid PlanogramId { get; set; }

        public Guid AccountPlanogramConfigurationId { get; set; }

        public int? NumberOfUnits { get; set; }

        public int? SortOrder { get; set; }

        public virtual AccountPlanogramConfiguration AccountPlanogramConfiguration { get; set; }

        public virtual Planogram Planogram { get; set; }
    }
}
