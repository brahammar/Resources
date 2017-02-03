namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountAddressbackup")]
    public partial class AccountAddressbackup
    {
        [Key]
        [Column(Order = 0)]
        public Guid AccountAddressId { get; set; }

        public Guid? ExternalId { get; set; }

        [Key]
        [Column(Order = 1)]
        public Guid AccountId { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int AccountAddressTypeId { get; set; }

        [StringLength(100)]
        public string FirstName { get; set; }

        [StringLength(100)]
        public string LastName { get; set; }

        [StringLength(100)]
        public string PhoneAreaCodeAndNumber { get; set; }

        [StringLength(100)]
        public string FaxAreaCodeAndNumber { get; set; }

        [StringLength(100)]
        public string CustomerAddressTitle { get; set; }

        [StringLength(100)]
        public string CustomerAddressFirstName { get; set; }

        [StringLength(100)]
        public string CustomerAddressLastName { get; set; }

        [StringLength(100)]
        public string CustomerAddressLine1 { get; set; }

        [StringLength(100)]
        public string CustomerAddressLine2 { get; set; }

        [StringLength(100)]
        public string CustomerAddressLine3 { get; set; }

        [StringLength(100)]
        public string CustomerAddressCity { get; set; }

        [StringLength(100)]
        public string CustomerAddressStateCD { get; set; }

        [StringLength(100)]
        public string CustomerAddressCountryCD { get; set; }

        [StringLength(100)]
        public string CustomerAddressPostalCD { get; set; }

        [StringLength(100)]
        public string CustomerAddressPhoneAreaCodeAndNumber { get; set; }

        [Key]
        [Column(Order = 3)]
        public DateTime UppDat { get; set; }

        [Key]
        [Column(Order = 4)]
        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        [StringLength(50)]
        public string AddressId { get; set; }

        public int? AddressTypeId { get; set; }
    }
}
