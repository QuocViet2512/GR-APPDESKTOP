namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("MONAN")]
    public partial class MONAN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MONAN()
        {
            CTHD = new HashSet<CTHD>();
        }

        [Key]
        [StringLength(10)]
        public string MaMon { get; set; }

        [StringLength(50)]
        public string TenMon { get; set; }

        public int MaLoaiMon { get; set; }

        public decimal? Gia { get; set; }

        [Column(TypeName = "image")]
        public byte[] HinhAnh { get; set; }

        public bool? MAstatus { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHD { get; set; }

        public virtual LOAIMON LOAIMON { get; set; }
    }
}
