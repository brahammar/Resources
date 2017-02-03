namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class site_Themes
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ThemeId { get; set; }

        [StringLength(255)]
        public string ThemeUrl { get; set; }

        [StringLength(255)]
        public string ThemeThumbUrl { get; set; }

        [StringLength(100)]
        public string ThemeName { get; set; }

        [StringLength(255)]
        public string ThemeDescription { get; set; }

        [StringLength(100)]
        public string ThemeCategory { get; set; }

        public bool? IsEnabled { get; set; }
    }
}
