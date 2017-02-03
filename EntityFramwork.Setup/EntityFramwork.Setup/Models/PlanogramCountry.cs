namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PlanogramCountry")]
    public partial class PlanogramCountry
    {
        public Guid PlanogramCountryId { get; set; }

        public Guid PlanogramId { get; set; }

        public Guid CountryId { get; set; }

        public virtual Planogram Planogram { get; set; }
    }
}
