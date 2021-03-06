namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssortmentBrand")]
    public partial class AssortmentBrand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AssortmentBrand()
        {
            AssortmentBrandAccounts = new HashSet<AssortmentBrandAccount>();
        }

        public Guid AssortmentBrandId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid AssortmentId { get; set; }

        public Guid BrandId { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        public virtual Assortment Assortment { get; set; }

        public virtual Brand Brand { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssortmentBrandAccount> AssortmentBrandAccounts { get; set; }
    }
}
