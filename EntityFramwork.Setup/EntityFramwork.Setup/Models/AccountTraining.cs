namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AccountTraining")]
    public partial class AccountTraining
    {
        public Guid AccountTrainingId { get; set; }

        public Guid? ExternalId { get; set; }

        public Guid AccountId { get; set; }

        public Guid TrainingId { get; set; }

        public DateTime CompletionDate { get; set; }

        public DateTime UppDat { get; set; }

        public DateTime RegDat { get; set; }

        [StringLength(50)]
        public string UpdatedBy { get; set; }

        public virtual Account Account { get; set; }
    }
}
