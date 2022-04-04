namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DONHANG")]
    public partial class DONHANG
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DONHANG()
        {
            CTHDs = new HashSet<CTHD>();
        }

        [Key]
        public int MaHD { get; set; }

        public decimal? TongHD { get; set; }

        public decimal? TienThu { get; set; }

        public decimal? TienTra { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayXuat { get; set; }

        public int? MaBan { get; set; }

        [Required]
        [StringLength(10)]
        public string MaNV { get; set; }

        public decimal? KhuyenMai { get; set; }

        public virtual BANAN BANAN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTHD> CTHDs { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
