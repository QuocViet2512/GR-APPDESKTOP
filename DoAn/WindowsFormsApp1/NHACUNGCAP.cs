namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHACUNGCAP")]
    public partial class NHACUNGCAP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHACUNGCAP()
        {
            LOAINGUYENLIEUx = new HashSet<LOAINGUYENLIEU>();
        }

        [Key]
        [StringLength(5)]
        public string MANCC { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNCC { get; set; }

        [Required]
        [StringLength(11)]
        public string SDT { get; set; }

        [Required]
        [StringLength(50)]
        public string DCHI { get; set; }

        public bool NCCSTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LOAINGUYENLIEU> LOAINGUYENLIEUx { get; set; }
    }
}
