namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("NGUYENLIEU")]
    public partial class NGUYENLIEU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public NGUYENLIEU()
        {
            CTPN = new HashSet<CTPN>();
            KHO = new HashSet<KHO>();
        }

        [Key]
        [StringLength(10)]
        public string MANL { get; set; }

        public int MALOAINL { get; set; }

        [Required]
        [StringLength(50)]
        public string TENNL { get; set; }

        [Column(TypeName = "money")]
        public decimal? GIA { get; set; }

        public bool NLSTT { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPN> CTPN { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHO> KHO { get; set; }

        public virtual LOAINGUYENLIEU LOAINGUYENLIEU { get; set; }
    }
}
