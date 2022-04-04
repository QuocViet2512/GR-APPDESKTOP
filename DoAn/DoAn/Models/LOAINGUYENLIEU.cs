namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LOAINGUYENLIEU")]
    public partial class LOAINGUYENLIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LOAINGUYENLIEU()
        {
            NGUYENLIEU = new HashSet<NGUYENLIEU>();
        }

        [Key]
        public int MALOAINL { get; set; }

        [Required]
        [StringLength(5)]
        public string MANCC { get; set; }

        [Required]
        [StringLength(50)]
        public string TENLOAINL { get; set; }

        public bool LNLSTT { get; set; }

        public virtual NHACUNGCAP NHACUNGCAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<NGUYENLIEU> NGUYENLIEU { get; set; }
    }
}
