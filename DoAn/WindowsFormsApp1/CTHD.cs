namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTHD")]
    public partial class CTHD
    {
        public int id { get; set; }

        public int MaHD { get; set; }

        [StringLength(10)]
        public string MaMon { get; set; }

        [StringLength(50)]
        public string TenMon { get; set; }

        public int? SoLuong { get; set; }

        public virtual DONHANG DONHANG { get; set; }

        public virtual MONAN MONAN { get; set; }
    }
}
