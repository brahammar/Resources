namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BrandPartnerProgram")]
    public partial class BrandPartnerProgram
    {
        public Guid BrandPartnerProgramId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid BrandId { get; set; }

        public Guid PartnerProgramId { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Brand Brand { get; set; }

        public virtual PartnerProgram PartnerProgram { get; set; }
    }
}
