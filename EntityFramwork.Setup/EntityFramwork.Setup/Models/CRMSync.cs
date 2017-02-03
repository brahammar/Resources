namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRMSync")]
    public partial class CRMSync
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CRMSync()
        {
            CRMSyncDeleteds = new HashSet<CRMSyncDeleted>();
        }

        [Key]
        [StringLength(100)]
        public string TableName { get; set; }

        [Required]
        [StringLength(100)]
        public string InternalIdColumn { get; set; }

        [Required]
        [StringLength(100)]
        public string ExternalIdColumn { get; set; }

        [Required]
        [StringLength(100)]
        public string LastUpdatedColumn { get; set; }

        [Required]
        [StringLength(100)]
        public string UpdatedByColumn { get; set; }

        public DateTime LastSync { get; set; }

        public bool Enabled { get; set; }

        public int OrderNo { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CRMSyncDeleted> CRMSyncDeleteds { get; set; }
    }
}
