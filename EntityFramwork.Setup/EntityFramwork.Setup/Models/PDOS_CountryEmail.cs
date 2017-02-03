namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PDOS_CountryEmail
    {
        [StringLength(50)]
        public string countryID { get; set; }

        [StringLength(50)]
        public string position { get; set; }

        [StringLength(200)]
        public string name { get; set; }

        [StringLength(200)]
        public string email { get; set; }

        [Key]
        public int uniqueID { get; set; }
    }
}
