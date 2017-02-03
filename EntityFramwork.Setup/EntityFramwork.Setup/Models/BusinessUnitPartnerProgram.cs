namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessUnitPartnerProgram")]
    public partial class BusinessUnitPartnerProgram
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BusinessUnitPartnerProgram()
        {
            AccountBusinessUnitPartnerPrograms = new HashSet<AccountBusinessUnitPartnerProgram>();
        }

        public Guid BusinessUnitPartnerProgramId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid BusinessUnitId { get; set; }

        public Guid PartnerProgramId { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccountBusinessUnitPartnerProgram> AccountBusinessUnitPartnerPrograms { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; }

        public virtual PartnerProgram PartnerProgram { get; set; }
    }
}
