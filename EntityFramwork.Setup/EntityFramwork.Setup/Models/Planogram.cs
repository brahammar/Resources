namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Planogram")]
    public partial class Planogram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Planogram()
        {
            AccountPlanograms = new HashSet<AccountPlanogram>();
            InspectionPlanograms = new HashSet<InspectionPlanogram>();
            PlanogramConfigurations = new HashSet<PlanogramConfiguration>();
            PlanogramCountries = new HashSet<PlanogramCountry>();
            PlanogramItems = new HashSet<PlanogramItem>();
            PlanogramConnections = new HashSet<PlanogramConnection>();
            PlanogramConnections1 = new HashSet<PlanogramConnection>();
        }

        public Guid PlanogramId { get; set; }

        public Guid? ExternalId { get; set; }

        [Required]
        [StringLength(256)]
        public string Name { get; set; }

        [StringLength(256)]
        public string ImageName { get; set; }

        public int? ImageWidthInPX { get; set; }

        public int? ImageHeightInPX { get; set; }

        public int? MinInspectionImagesRequired { get; set; }

        public int? MaxInspectionImagesRequired { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public Guid PlanogramTypeId { get; set; }

        public bool IsConfigurable { get; set; }

        public int? ConfigurableWidthInMeters { get; set; }

        public bool IsActive { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountPlanogram> AccountPlanograms { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InspectionPlanogram> InspectionPlanograms { get; set; }

        public virtual PlanogramType PlanogramType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanogramConfiguration> PlanogramConfigurations { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanogramCountry> PlanogramCountries { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanogramItem> PlanogramItems { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanogramConnection> PlanogramConnections { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PlanogramConnection> PlanogramConnections1 { get; set; }
    }
}
