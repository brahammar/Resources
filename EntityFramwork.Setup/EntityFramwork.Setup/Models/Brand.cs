namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Brand")]
    public partial class Brand
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Brand()
        {
            AssortmentBrands = new HashSet<AssortmentBrand>();
            BrandPartnerPrograms = new HashSet<BrandPartnerProgram>();
            BusinessUnitBrands = new HashSet<BusinessUnitBrand>();
        }

        public Guid BrandId { get; set; }

        public Guid? ExternalId { get; set; }

        [Column("Brand")]
        [Required]
        [StringLength(50)]
        public string Brand1 { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssortmentBrand> AssortmentBrands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BrandPartnerProgram> BrandPartnerPrograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitBrand> BusinessUnitBrands { get; set; }
    }
}
