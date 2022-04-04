namespace WindowsFormsApp1
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<BANAN> BANANs { get; set; }
        public virtual DbSet<CHUCVU> CHUCVUs { get; set; }
        public virtual DbSet<CTHD> CTHDs { get; set; }
        public virtual DbSet<CTPN> CTPNs { get; set; }
        public virtual DbSet<DONHANG> DONHANGs { get; set; }
        public virtual DbSet<KHO> KHOes { get; set; }
        public virtual DbSet<LOAIMON> LOAIMONs { get; set; }
        public virtual DbSet<LOAINGUYENLIEU> LOAINGUYENLIEUx { get; set; }
        public virtual DbSet<MONAN> MONANs { get; set; }
        public virtual DbSet<NGUYENLIEU> NGUYENLIEUx { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAPs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOANs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIENs)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<CTPN>()
                .Property(e => e.MANL)
                .IsUnicode(false);

            modelBuilder.Entity<CTPN>()
                .HasMany(e => e.KHOes)
                .WithOptional(e => e.CTPN)
                .HasForeignKey(e => e.IDPN);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.TongHD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.TienThu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.TienTra)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.MaNV)
                .IsUnicode(false);

            modelBuilder.Entity<DONHANG>()
                .Property(e => e.KhuyenMai)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DONHANG>()
                .HasMany(e => e.CTHDs)
                .WithRequired(e => e.DONHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHO>()
                .Property(e => e.MANL)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIMON>()
                .HasMany(e => e.MONANs)
                .WithRequired(e => e.LOAIMON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAINGUYENLIEU>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<LOAINGUYENLIEU>()
                .HasMany(e => e.NGUYENLIEUx)
                .WithRequired(e => e.LOAINGUYENLIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<MONAN>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<MONAN>()
                .Property(e => e.Gia)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NGUYENLIEU>()
                .Property(e => e.MANL)
                .IsUnicode(false);

            modelBuilder.Entity<NGUYENLIEU>()
                .Property(e => e.GIA)
                .HasPrecision(19, 4);

            modelBuilder.Entity<NGUYENLIEU>()
                .HasMany(e => e.CTPNs)
                .WithRequired(e => e.NGUYENLIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUYENLIEU>()
                .HasMany(e => e.KHOes)
                .WithRequired(e => e.NGUYENLIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.LOAINGUYENLIEUx)
                .WithRequired(e => e.NHACUNGCAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .Property(e => e.CMND)
                .IsUnicode(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.DONHANGs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUNHAPs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TAIKHOANs)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.TONGGIANL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUNHAP>()
                .HasMany(e => e.CTPNs)
                .WithRequired(e => e.PHIEUNHAP)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.TENTK)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<TAIKHOAN>()
                .Property(e => e.MATKHAU)
                .IsUnicode(false);
        }
    }
}
