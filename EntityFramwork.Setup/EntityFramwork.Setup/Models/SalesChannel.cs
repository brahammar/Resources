namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesChannel")]
    public partial class SalesChannel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SalesChannel()
        {
            AccountSalesChannels = new HashSet<AccountSalesChannel>();
            SalesChannelPlanogramTypes = new HashSet<SalesChannelPlanogramType>();
        }

        public Guid SalesChannelId { get; set; }

        public Guid? ExternalId { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountSalesChannel> AccountSalesChannels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SalesChannelPlanogramType> SalesChannelPlanogramTypes { get; set; }
    }
}
