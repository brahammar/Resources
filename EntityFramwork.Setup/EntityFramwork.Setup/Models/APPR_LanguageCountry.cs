namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_LanguageCountry
    {
        [Key]
        public Guid LanguageCountryID { get; set; }

        public Guid LanguageID { get; set; }

        public Guid CountryID { get; set; }

        public virtual APPR_Language APPR_Language { get; set; }

        public virtual Country Country { get; set; }
    }
}
