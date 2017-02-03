namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Account")]
    public partial class Account
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Account()
        {
            AccountAddresses = new HashSet<AccountAddress>();
            AccountBusinessUnitPartnerPrograms = new HashSet<AccountBusinessUnitPartnerProgram>();
            AccountContracts = new HashSet<AccountContract>();
            AccountPlanograms = new HashSet<AccountPlanogram>();
            AccountPlanogramConfigurations = new HashSet<AccountPlanogramConfiguration>();
            AccountSalesChannels = new HashSet<AccountSalesChannel>();
            AccountTrainings = new HashSet<AccountTraining>();
            Inspections = new HashSet<Inspection>();
        }

        public Guid AccountId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid? ParentAccountId { get; set; }

        [StringLength(200)]
        public string AccountName { get; set; }

        public Guid CountryId { get; set; }

        [StringLength(50)]
        public string Postal_code { get; set; }

        [StringLength(200)]
        public string City { get; set; }

        [StringLength(50)]
        public string Latitude { get; set; }

        [StringLength(50)]
        public string Longitude { get; set; }

        [StringLength(200)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(200)]
        public string Monday { get; set; }

        [StringLength(200)]
        public string Tuesday { get; set; }

        [StringLength(200)]
        public string Wednesday { get; set; }

        [StringLength(200)]
        public string Thursday { get; set; }

        [StringLength(200)]
        public string Friday { get; set; }

        [StringLength(200)]
        public string Saturday { get; set; }

        [StringLength(200)]
        public string Sunday { get; set; }

        public DateTime? LastUpdate { get; set; }

        [StringLength(50)]
        public string CustomerNo { get; set; }

        [StringLength(200)]
        public string Street { get; set; }

        [StringLength(100)]
        public string SalesManager { get; set; }

        public bool? VisibleInDealerLocator { get; set; }

        public bool? OnlineDealer { get; set; }

        public int? SortOrder { get; set; }

        public string Information { get; set; }

        [StringLength(200)]
        public string Adress2 { get; set; }

        [StringLength(200)]
        public string Adress3 { get; set; }

        [StringLength(50)]
        public string Subdivision { get; set; }

        [StringLength(100)]
        public string URL { get; set; }

        [StringLength(50)]
        public string rep_no { get; set; }

        [StringLength(50)]
        public string account_no { get; set; }

        [StringLength(50)]
        public string username { get; set; }

        [StringLength(50)]
        public string password { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ECustomerNo { get; set; }

        [StringLength(200)]
        public string ContactName { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public bool ShowStreetView { get; set; }

        public bool CanDownloadAssets { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountAddress> AccountAddresses { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBusinessUnitPartnerProgram> AccountBusinessUnitPartnerPrograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountContract> AccountContracts { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountPlanogram> AccountPlanograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountPlanogramConfiguration> AccountPlanogramConfigurations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountSalesChannel> AccountSalesChannels { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountTraining> AccountTrainings { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inspection> Inspections { get; set; }
    }
}
