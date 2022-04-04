namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TAIKHOAN")]
    public partial class TAIKHOAN
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TENTK { get; set; }

        [Required]
        [StringLength(10)]
        public string MANV { get; set; }

        [Required]
        [StringLength(50)]
        public string MATKHAU { get; set; }

        [Required]
        [StringLength(50)]
        public string TENHIENTHI { get; set; }

        public bool TKSTT { get; set; }

        public virtual NHANVIEN NHANVIEN { get; set; }
    }
}
