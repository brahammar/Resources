namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class site_ThemeCss
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CssId { get; set; }

        [StringLength(255)]
        public string CssUrl { get; set; }

        [StringLength(100)]
        public string CssName { get; set; }

        [StringLength(255)]
        public string CssDescription { get; set; }

        [StringLength(100)]
        public string ThemeCategory { get; set; }
    }
}
