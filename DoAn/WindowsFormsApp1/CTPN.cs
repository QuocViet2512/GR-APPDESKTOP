namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CTPN")]
    public partial class CTPN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CTPN()
        {
            KHOes = new HashSet<KHO>();
        }

        public int ID { get; set; }

        public int MAPN { get; set; }

        [Required]
        [StringLength(10)]
        public string MANL { get; set; }

        public int? SOLUONG { get; set; }

        public virtual NGUYENLIEU NGUYENLIEU { get; set; }

        public virtual PHIEUNHAP PHIEUNHAP { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO> KHOes { get; set; }
    }
}
