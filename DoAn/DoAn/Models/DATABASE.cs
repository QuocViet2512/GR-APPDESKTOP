namespace DoAn.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DATABASE : DbContext
    {
        public DATABASE()
            : base("name=DATABASE")
        {
        }

        public virtual DbSet<BANAN> BANAN { get; set; }
        public virtual DbSet<CTPN> CTPN { get; set; }
        public virtual DbSet<CTHD> CTHD { get; set; }
        public virtual DbSet<CHUCVU> CHUCVU { get; set; }
        public virtual DbSet<DONHANG> DONHANG { get; set; }
        public virtual DbSet<KHO> KHO { get; set; }
        public virtual DbSet<LOAIMON> LOAIMON { get; set; }
        public virtual DbSet<LOAINGUYENLIEU> LOAINGUYENLIEU { get; set; }
        public virtual DbSet<MONAN> MONAN { get; set; }
        public virtual DbSet<NGUYENLIEU> NGUYENLIEU { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAP { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIEN { get; set; }
        public virtual DbSet<PHIEUNHAP> PHIEUNHAP { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOAN> TAIKHOAN { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BANAN>()
                .HasMany(e => e.DONHANG)
                .WithRequired(e => e.BANAN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<CTPN>()
                .Property(e => e.MANL)
                .IsUnicode(false);

            modelBuilder.Entity<CTPN>()
                .HasMany(e => e.KHO)
                .WithOptional(e => e.CTPN)
                .HasForeignKey(e => e.IDPN);

            modelBuilder.Entity<CTHD>()
                .Property(e => e.MaMon)
                .IsUnicode(false);

            modelBuilder.Entity<CHUCVU>()
                .HasMany(e => e.NHANVIEN)
                .WithRequired(e => e.CHUCVU)
                .WillCascadeOnDelete(false);

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
                .HasMany(e => e.CTHD)
                .WithRequired(e => e.DONHANG)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<KHO>()
                .Property(e => e.MANL)
                .IsUnicode(false);

            modelBuilder.Entity<LOAIMON>()
                .HasMany(e => e.MONAN)
                .WithRequired(e => e.LOAIMON)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LOAINGUYENLIEU>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<LOAINGUYENLIEU>()
                .HasMany(e => e.NGUYENLIEU)
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
                .HasMany(e => e.CTPN)
                .WithRequired(e => e.NGUYENLIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NGUYENLIEU>()
                .HasMany(e => e.KHO)
                .WithRequired(e => e.NGUYENLIEU)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.MANCC)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .Property(e => e.SDT)
                .IsUnicode(false);

            modelBuilder.Entity<NHACUNGCAP>()
                .HasMany(e => e.LOAINGUYENLIEU)
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
                .HasMany(e => e.DONHANG)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.PHIEUNHAP)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<NHANVIEN>()
                .HasMany(e => e.TAIKHOAN)
                .WithRequired(e => e.NHANVIEN)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.MANV)
                .IsUnicode(false);

            modelBuilder.Entity<PHIEUNHAP>()
                .Property(e => e.TONGGIANL)
                .HasPrecision(19, 4);

            modelBuilder.Entity<PHIEUNHAP>()
                .HasMany(e => e.CTPN)
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
