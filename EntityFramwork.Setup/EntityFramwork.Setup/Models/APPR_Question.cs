namespace EntityFramwork.Setup.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class APPR_Question
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APPR_Question()
        {
            APPR_Answer = new HashSet<APPR_Answer>();
            APPR_QuestionTranslations = new HashSet<APPR_QuestionTranslations>();
        }

        [Key]
        public Guid QuestionID { get; set; }

        public bool ShowInExcel { get; set; }

        public bool ShowInReport { get; set; }

        [Column(TypeName = "date")]
        public DateTime ActiveFrom { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ActiveTo { get; set; }

        public Guid FieldTypeID { get; set; }

        public int? FontSize { get; set; }

        public Guid SectionID { get; set; }

        public int SortIndex { get; set; }

        public bool IsMandatory { get; set; }

        public bool ShowQuestionText { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_Answer> APPR_Answer { get; set; }

        public virtual APPR_FieldType APPR_FieldType { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<APPR_QuestionTranslations> APPR_QuestionTranslations { get; set; }

        public virtual APPR_Section APPR_Section { get; set; }
    }
}
