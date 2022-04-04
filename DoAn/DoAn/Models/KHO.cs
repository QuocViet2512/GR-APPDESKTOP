namespace DoAn.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KHO")]
    public partial class KHO
    {
        public int ID { get; set; }

        [Required]
        [StringLength(10)]
        public string MANL { get; set; }

        public int? IDPN { get; set; }

        public int SLTON { get; set; }

        public virtual CTPN CTPN { get; set; }

        public virtual NGUYENLIEU NGUYENLIEU { get; set; }
    }
}
