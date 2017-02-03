namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AssortmentAccountStatistic
    {
        [Key]
        public Guid AssortmentAccountID { get; set; }

        public Guid CountryID { get; set; }

        public Guid AssortmentID { get; set; }

        public int Year { get; set; }

        public int Month { get; set; }

        public Guid AccountId { get; set; }

        public virtual Assortment Assortment { get; set; }

        public virtual Country Country { get; set; }
    }
}
