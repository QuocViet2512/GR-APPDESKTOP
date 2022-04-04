namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BANAN")]
    public partial class BANAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANAN()
        {
            DONHANG = new HashSet<DONHANG>();
        }

        [Key]
        public int MABAN { get; set; }

        [Required]
        [StringLength(5)]
        public string TENBAN { get; set; }

        [StringLength(10)]
        public string TRANGTHAI { get; set; }

        public bool BANSTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANG { get; set; }
    }
}
