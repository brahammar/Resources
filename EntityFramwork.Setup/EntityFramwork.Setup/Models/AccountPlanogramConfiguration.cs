namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountPlanogramConfiguration")]
    public partial class AccountPlanogramConfiguration
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AccountPlanogramConfiguration()
        {
            PlanogramConfigurations = new HashSet<PlanogramConfiguration>();
        }

        public Guid AccountPlanogramConfigurationId { get; set; }

        public Guid AccountId { get; set; }

        [StringLength(255)]
        public string Name { get; set; }

        public virtual Account Account { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanogramConfiguration> PlanogramConfigurations { get; set; }
    }
}
