namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountBusinessUnitPartnerProgram")]
    public partial class AccountBusinessUnitPartnerProgram
    {
        public Guid AccountBusinessUnitPartnerProgramId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid AccountId { get; set; }

        public Guid BusinessUnitPartnerProgramId { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Account Account { get; set; }
    }
}
