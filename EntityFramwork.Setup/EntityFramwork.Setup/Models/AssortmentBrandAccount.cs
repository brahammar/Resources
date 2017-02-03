namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AssortmentBrandAccount")]
    public partial class AssortmentBrandAccount
    {
        public Guid AssortmentBrandAccountId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid AssortmentBrandId { get; set; }

        public Guid AccountId { get; set; }

        public bool VisibleDealerLocator { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public byte Rating { get; set; }

        public virtual Account Account { get; set; }

        public virtual AssortmentBrand AssortmentBrand { get; set; }
    }
}
