namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BusinessUnitAccount")]
    public partial class BusinessUnitAccount
    {
        public Guid BusinessUnitAccountId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid BusinessUnitId { get; set; }

        public Guid AccountId { get; set; }

        [StringLength(100)]
        public string CustomerNo { get; set; }

        public bool B2BEnable { get; set; }

        [StringLength(50)]
        public string Division { get; set; }

        [StringLength(50)]
        public string OrderType { get; set; }

        [StringLength(50)]
        public string StandardWarehouse { get; set; }

        [StringLength(50)]
        public string Currency { get; set; }

        [StringLength(10)]
        public string PriceList { get; set; }

        [StringLength(50)]
        public string PriceType { get; set; }

        public int? Vat { get; set; }

        [StringLength(100)]
        public string FreightLimit { get; set; }

        [StringLength(50)]
        public string Facility { get; set; }

        public decimal? FreeFreightLimit { get; set; }

        public Guid? UserId { get; set; }

        [StringLength(100)]
        public string ErpId { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public Guid? DealerId { get; set; }

        public virtual Account Account { get; set; }

        public virtual BusinessUnit BusinessUnit { get; set; }
    }
}
