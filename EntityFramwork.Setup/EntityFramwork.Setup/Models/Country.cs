namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Country")]
    public partial class Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Country()
        {
            Accounts = new HashSet<Account>();
            APPR_LanguageCountry = new HashSet<APPR_LanguageCountry>();
            AssortmentAccountStatistics = new HashSet<AssortmentAccountStatistic>();
            PlanogramCountries = new HashSet<PlanogramCountry>();
        }

        public Guid CountryId { get; set; }

        public Guid? ExternalId { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string Abbrevation { get; set; }

        [StringLength(50)]
        public string ThuleAbbrevation { get; set; }

        public DateTime RegDat { get; set; }

        public DateTime UppDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [Required]
        [StringLength(10)]
        public string DialingCode { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Account> Accounts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_LanguageCountry> APPR_LanguageCountry { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AssortmentAccountStatistic> AssortmentAccountStatistics { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanogramCountry> PlanogramCountries { get; set; }
    }
}
