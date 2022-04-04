namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NHANVIEN")]
    public partial class NHANVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NHANVIEN()
        {
            DONHANG = new HashSet<DONHANG>();
            PHIEUNHAP = new HashSet<PHIEUNHAP>();
            TAIKHOAN = new HashSet<TAIKHOAN>();
        }

        [Key]
        [StringLength(10)]
        public string MANV { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNV { get; set; }

        public int MACV { get; set; }

        [StringLength(11)]
        public string SDT { get; set; }

        [StringLength(10)]
        public string CMND { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NSINH { get; set; }

        public bool? GTINH { get; set; }

        public bool NVSTT { get; set; }

        public virtual CHUCVU CHUCVU { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DONHANG> DONHANG { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUNHAP> PHIEUNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TAIKHOAN> TAIKHOAN { get; set; }
    }
}
