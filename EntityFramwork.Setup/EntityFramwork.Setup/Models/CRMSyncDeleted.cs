namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMSyncDeleted")]
    public partial class CRMSyncDeleted
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string TableName { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid InternalId { get; set; }

        public Guid? ExternalId { get; set; }

        [Key]
        [Column(Order = 2)]
        public DateTime DelDat { get; set; }

        [StringLength(50)]
        public string DeletedBy { get; set; }

        public virtual CRMSync CRMSync { get; set; }
    }
}
