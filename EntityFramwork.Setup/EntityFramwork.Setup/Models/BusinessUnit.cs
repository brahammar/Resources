namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessUnit")]
    public partial class BusinessUnit
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessUnit()
        {
            BusinessUnitAccounts = new HashSet<BusinessUnitAccount>();
            BusinessUnitBrands = new HashSet<BusinessUnitBrand>();
            BusinessUnitPartnerPrograms = new HashSet<BusinessUnitPartnerProgram>();
        }

        public Guid BusinessUnitId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid BusinessAreaId { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual BusinessArea BusinessArea { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitAccount> BusinessUnitAccounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitBrand> BusinessUnitBrands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BusinessUnitPartnerProgram> BusinessUnitPartnerPrograms { get; set; }
    }
}
